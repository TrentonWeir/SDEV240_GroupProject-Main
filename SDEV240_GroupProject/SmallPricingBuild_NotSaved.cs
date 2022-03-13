using MaterialCostLib.BusinessLayer;
using MaterialCostLib.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SDEV240_GroupProject
{
    public partial class SmallPricingBuild_NotSaved : Form
    {
        public List<MainDTO> Main_List = new List<MainDTO>();
        public int _Edit_ID = 0;
        public SmallPricingBuild_NotSaved(List<MainDTO> list = null, int id = 0)
        {
            InitializeComponent();
            //checks if is Editing existing data.
            if (list != null)
            {
                Main_List = list;
                _Edit_ID = id;
                gvMaterialCost.DataSource = Main_List;
            }
            else
            {
                gvMaterialCost.DataSource = Main_List;
            }
            SetComboBox();
            TestConditions();//pass true for TestData
        }
        private void TestConditions(bool condition = false)
        {
            //used for testing only. 
            if (condition)
            {
                txtDescription.Text = "Description";
                txtItem.Text = "Item";
                txtQty.Text = "1";
                txtUnitCost.Text = "1.1";
                ddlCategory.Text = "new Category";
                ddlMaterial.Text = "New Material";
            }
        }
        private void SetComboBox()
        {
            // sets search items
            ddlSearchFilter.Items.Add("Id");
            ddlSearchFilter.Items.Add("Category");
            ddlSearchFilter.Items.Add("Item");
            ddlSearchFilter.Items.Add("Materials");
            ddlSearchFilter.Items.Add("Description");
            ddlSearchFilter.Items.Add("UnitCost");
            ddlSearchFilter.SelectedIndex = 0;
            Main main = new Main();
            foreach (var item in main.SelectCategorylData())
            {
                ddlCategory.Items.Add(item.Category);
            }
            foreach (var item in main.SelectMaterialData())
            {
                ddlMaterial.Items.Add(item.Material);
            }
        }
        private void ClearTxtBoxes()
        {
            //clears all data inputs
            txtDescription.Text = string.Empty;
            txtItem.Text = string.Empty;
            txtQty.Text = string.Empty;
            txtSearch.Text = string.Empty;
            txtUnitCost.Text = string.Empty;
            ddlCategory.Text = string.Empty;
            ddlMaterial.Text = string.Empty;
            lblEditId.Text = string.Empty;
        }

        private void AddDataToGrid()
        {
            //adds item to grid view
            try
            {
                var id = gvMaterialCost.Rows.Count + 1;
                double cost = Convert.ToDouble(txtUnitCost.Text) * Convert.ToDouble(txtQty.Text);
                var list = new List<MainDTO>();
                list.Add(new MainDTO()
                {
                    Id = id,
                    Category = ddlCategory.Text,
                    Item = txtItem.Text,
                    Material = ddlMaterial.Text,
                    Description = txtDescription.Text,
                    Qty = float.Parse(txtQty.Text),
                    UnitCost = float.Parse(txtUnitCost.Text),
                    Cost = cost.ToString("0.00"),
                });
                Main_List.AddRange(list);
                gvMaterialCost.DataSource = string.Empty;
                gvMaterialCost.DataSource = Main_List;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Make sure Qty and Unit Cost contain no letters or special characters! ie.($,*&^%#@)" + ex.Message);
            }
            GetTotal();
        }
        private string SaveToMainDataBase(List<MainDTO> list)
        {
            // sends list to the database that the main grid uses
            try
            {
                Main db = new Main();
                db.InsertEstimateDataToMain(list);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return $"{ex.Message}";
            }
        }
        private string SaveToMainDataBase(List<MainDTO> list, int id)
        {
            // sends an updated item to the database for updating
            try
            {
                Main db = new Main();
                db.InsertEstimateDataToMain(list, id);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return $"{ex.Message}";
            }
        }
        private List<MainDTO> GridToList()
        {
            //Takes the data from the grid and creates an Object list with it.
            List<MainDTO> list = new List<MainDTO>();
            if (gvMaterialCost.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in gvMaterialCost.Rows)
                {
                    list.Add(new MainDTO()
                    {
                        Id = (int)row.Cells[0].Value,
                        Category = (string)row.Cells[1].Value,
                        Item = (string)row.Cells[2].Value,
                        Material = (string)row.Cells[3].Value,
                        Description = (string)row.Cells[4].Value,
                        Qty = (float)row.Cells[5].Value,
                        UnitCost = (float)row.Cells[6].Value,
                        Cost = (string)row.Cells[7].Value,
                    });
                }
            }
            return list;
        }
        private void GetTotal()
        {
            //Sets total based on data in grid
            var total = 0.00;
            foreach (DataGridViewRow row in gvMaterialCost.Rows)
            {
                total += Convert.ToDouble(row.Cells[7].Value);
            }
            lblTotal.Text = $"${total.ToString("0.00")}";
        }
        private void FilterGrid()
        {
            //searches for items matching the users search
            var index = ddlSearchFilter.SelectedIndex;
            var list = new List<MainDTO>();


            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                try
                {
                    if (index == 0)
                        list = Main_List.Where(x => x.Id == Convert.ToInt32(txtSearch.Text)).ToList();
                    if (index == 1)
                        list = Main_List.Where(x => x.Category.ToLower() == txtSearch.Text).ToList();
                    if (index == 2)
                        list = Main_List.Where(x => x.Item.ToLower() == txtSearch.Text).ToList();
                    if (index == 3)
                        list = Main_List.Where(x => x.Material.ToLower() == (txtSearch.Text)).ToList();
                    if (index == 4)
                        list = Main_List.Where(x => x.Description.ToLower() == (txtSearch.Text)).ToList();
                    if (index == 5)
                        list = Main_List.Where(x => x.Qty == Convert.ToInt32(txtSearch.Text)).ToList();
                    if (index == 6)
                        list = Main_List.Where(x => x.UnitCost == float.Parse(txtSearch.Text)).ToList();
                    if (index == 7)
                        list = Main_List.Where(x => x.Cost == (txtSearch.Text)).ToList();
                    if (list.Count > 0)
                        gvMaterialCost.DataSource = list;
                    else
                        gvMaterialCost.DataSource = Main_List;
                }
                catch
                {
                    gvMaterialCost.DataSource = Main_List;
                    GetTotal();
                }

            }
            else
            {
                gvMaterialCost.DataSource = Main_List;
                GetTotal();
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Kind of self explanitory. Activates search and resets the total price.
            FilterGrid();
            GetTotal();
        }

        private void btnSaveToMainList_Click(object sender, EventArgs e)
        {
            //activates the save to list and desides if it was an updated list or a new item.
            if (_Edit_ID != 0)
            {
                SaveToMainDataBase(GridToList(), _Edit_ID);
            }
            else
            {
                var list = GridToList();
                SaveToMainDataBase(list);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Deletes where Id == Searched_Id
            var list = GridToList();
            foreach (DataGridViewRow row in gvMaterialCost.Rows)
            {
                if (row.Index > 0 && row.Visible == true)
                {
                    list.RemoveAll(x => x.Id == Convert.ToInt32(row.Cells[0].Value) - 1);
                }
            }
        }

        private void btnPrintCSV_Click(object sender, EventArgs e)
        {
            //prints CSV file where user wants them.
            var command = new CommonCommands();
            MessageBox.Show(command.ExportMainDTO_List_AsCSV(GridToList()));
        }
        private void btnSaveText_Click(object sender, EventArgs e)
        {
            // same as CSV but .txt format
            var command = new CommonCommands();
            MessageBox.Show(command.ExportMainDTO_List_AsText(GridToList()));
        }

        private void ddlSearchFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            //seach activation
            FilterGrid();
        }

        private void btnSaveDataToGrid_Click(object sender, EventArgs e)
        {
            // saves data to grid. Decides if it is an update or new and inserts into grid data
            if (string.IsNullOrWhiteSpace(lblEditId.Text))
            {
                AddDataToGrid();
                ClearTxtBoxes();
            }
            else
            {
                var item = Main_List.Where(x => x.Id == Convert.ToInt32(lblEditId.Text)).Select(x => x).First();
                item = EditOrder(item);
                Main_List.RemoveAll(x => x.Id == Convert.ToInt32(lblEditId.Text));
                Main_List.Add(item);
                Main_List = Main_List.OrderBy(x => x.Id).ToList();
                gvMaterialCost.DataSource = string.Empty;
                gvMaterialCost.DataSource = Main_List;
                GetTotal();
                ClearTxtBoxes();
            }
        }

        private MainDTO EditOrder(MainDTO item)
        {
            //Populates data into txtBoxes
            item.Category = ddlCategory.Text;
            item.Item = txtItem.Text;
            item.Material = ddlMaterial.Text;
            item.Description = txtDescription.Text;
            item.Qty = float.Parse(txtQty.Text);
            item.UnitCost = float.Parse(txtQty.Text);
            item.Cost = (item.Qty * item.UnitCost).ToString("0.00");
            return item;
        }

        private void btnClearGrid_Click(object sender, EventArgs e)
        {
            //Clears gridView Data
            lblTotal.Text = "Total: $00.00";
            gvMaterialCost.DataSource = string.Empty;
        }

        private void btnEditRow_Click(object sender, EventArgs e)
        {
            //selects a row for editing
            var search = txtSearch.Text;
            if (!string.IsNullOrWhiteSpace(search))
            {
                var item = GetIdForEditing(search);
                txtDescription.Text = item.Description;
                txtItem.Text = item.Item;
                txtQty.Text = item.Qty.ToString();
                txtUnitCost.Text = item.UnitCost.ToString("0.00");
                ddlCategory.Text = item.Category;
                ddlMaterial.Text = item.Material;
                lblEditId.Text = item.Id.ToString();
            }

        }

        private MainDTO GetIdForEditing(string search)
        {
            //finds searched item and gets id based on result
            MainDTO id = new MainDTO();
            if (ddlSearchFilter.SelectedIndex == 0)
                id = (Main_List.Where(x => x.Id.ToString().ToUpper().StartsWith(search.ToUpper())).Select(x => x).FirstOrDefault());
            if (ddlSearchFilter.SelectedIndex == 1)
                id = (Main_List.Where(x => x.Category.ToString().ToUpper().StartsWith(search.ToUpper())).Select(x => x).FirstOrDefault());
            if (ddlSearchFilter.SelectedIndex == 2)
                id = (Main_List.Where(x => x.Item.ToString().ToUpper().StartsWith(search.ToUpper())).Select(x => x).FirstOrDefault());
            if (ddlSearchFilter.SelectedIndex == 3)
                id = (Main_List.Where(x => x.Material.ToString().ToUpper().StartsWith(search.ToUpper())).Select(x => x).FirstOrDefault());
            if (ddlSearchFilter.SelectedIndex == 4)
                id = (Main_List.Where(x => x.Description.ToString().ToUpper().StartsWith(search.ToUpper())).Select(x => x).FirstOrDefault());
            if (ddlSearchFilter.SelectedIndex == 5)
                id = (Main_List.Where(x => x.UnitCost.ToString().ToUpper().StartsWith(search.ToUpper())).Select(x => x).FirstOrDefault());
            return id;
        }
    }
}
