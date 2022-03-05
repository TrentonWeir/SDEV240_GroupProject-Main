using MaterialCostLib.BusinessLayer;
using MaterialCostLib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDEV240_GroupProject
{
    public partial class SmallPricingBuild_NotSaved : Form
    {
        public List<MainDTO> Main_List = new List<MainDTO>();
        public SmallPricingBuild_NotSaved()
        {
            InitializeComponent();
            gvMaterialCost.DataSource = string.Empty;
            SetComboBox();
            TestConditions(true);//change true for TestData
        }
        private void TestConditions(bool condition = false)
        {
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
            ddlSearchFilter.Items.Add("Id");
            ddlSearchFilter.Items.Add("Category");
            ddlSearchFilter.Items.Add("Item");
            ddlSearchFilter.Items.Add("Materials");
            ddlSearchFilter.Items.Add("Description");
            ddlSearchFilter.Items.Add("UnitCost");
            ddlSearchFilter.SelectedIndex = 0;
            Main main = new Main();
            foreach(var item in main.SelectCategorylData())
            {
                ddlCategory.Items.Add(item.Category);
            }
            foreach(var item in main.SelectMaterialData())
            {
                ddlMaterial.Items.Add(item.Material);
            }
        }

        private void AddDataToGrid()
        {
            try
            {  
                var id = gvMaterialCost.Rows.Count + 1;
                double cost = Convert.ToDouble(txtUnitCost.Text) * Convert.ToDouble(txtQty.Text);
                List<MainDTO> list = GridToList();
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
                gvMaterialCost.DataSource = list;
                Main_List = list;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Make sure Qty and Unit Cost contain no letters or special characters! ie.($,*&^%#@)" + ex.Message);
            }
            GetTotal();
        }
        private List<MainDTO> CreateTableLayout()
        {
            try
            {
                return new List<MainDTO>();
            }
            catch
            {
                return new List<MainDTO>();
            }
        }
        private string SaveToMainDataBase(List<MainDTO> list)
        {
            try
            {
                Main db = new Main();
                db.InsertEstimateDataToMain(list);
                return string.Empty;
            }
            catch(Exception ex)
            {
                return $"{ex.Message}";
            }
        }
        private List<MainDTO> GridToList()
        {
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
            var total = 0.00;
            foreach(DataGridViewRow row in gvMaterialCost.Rows)
            {
                total += Convert.ToDouble(row.Cells[7].Value);
            }
            lblTotal.Text = $"${total.ToString("0.00")}";
        }
        private void FilterGrid()
        {
            
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
            FilterGrid();
            GetTotal();
        }

        private void btnSaveToMainList_Click(object sender, EventArgs e)
        {
            var list = GridToList();
            SaveToMainDataBase(list);
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var list = GridToList();
            foreach (DataGridViewRow row in gvMaterialCost.Rows)
            {
                if (row.Index > 0 && row.Visible == true)
                {
                    list.RemoveAll(x => x.Id == Convert.ToInt32(row.Cells[0].Value)-1);
                }
            }
        }

        private void btnPrintCSV_Click(object sender, EventArgs e)
        {
            var command = new CommonCommands();
            MessageBox.Show(command.ExportMainDTO_List_AsCSV(GridToList()));
        }
        private void btnSaveText_Click(object sender, EventArgs e)
        {
            var command = new CommonCommands();
            MessageBox.Show(command.ExportMainDTO_List_AsText(GridToList()));
        }

        private void ddlSearchFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterGrid();
        }

        private void btnSaveDataToGrid_Click(object sender, EventArgs e)
        {
            AddDataToGrid();
        }

        private void btnClearGrid_Click(object sender, EventArgs e)
        {
            lblTotal.Text = "Total: $00.00";
            gvMaterialCost.DataSource = string.Empty;
        }
    }
}
