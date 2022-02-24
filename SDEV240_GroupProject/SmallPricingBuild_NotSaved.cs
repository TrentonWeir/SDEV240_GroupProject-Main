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
        public SmallPricingBuild_NotSaved()
        {
            InitializeComponent();
            gvMaterialCost.DataSource = string.Empty;
            SetComboBox();
            TestConditions(true);
        }
        private void TestConditions(bool condition = false)
        {
            if (condition)
            {
                txtDescription.Text = "Description";
                txtItem.Text = "Item";
                txtQty.Text = "Qty";
                txtUnitCost.Text = "1.1";
                ddlCategory.SelectedIndex = 1;
                ddlMaterial.SelectedIndex = 1;
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
            }
            catch(Exception ex)
            {
                MessageBox.Show("Make sure Qty and Unit Cost contain no letters or special characters! ie.($,*&^%#@)" + ex.ToString());
            }
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
                db.InsertDataToMain(list);
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
            return list;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var index = ddlSearchFilter.SelectedIndex;
            var list = CreateTableLayout();
            var newList = new List<MainDTO>();
            gvMaterialCost.DataSource = list;
            if (!string.IsNullOrWhiteSpace(txtUnitCost.Text))
            {
                try
                {
                    if (index == 0)
                    {
                        foreach (var item in list)
                        {
                            if (item.Id.ToString().ToUpper().Substring(0, txtUnitCost.Text.Length) == txtUnitCost.Text.ToUpper())
                                newList.Add(item);
                        }
                        gvMaterialCost.DataSource = newList;
                    }
                    if (index == 1)
                    {
                        foreach (var item in list)
                        {
                            if (item.Category.ToString().ToUpper().Substring(0, txtUnitCost.Text.Length) == txtUnitCost.Text.ToUpper())
                                newList.Add(item);
                        }
                        gvMaterialCost.DataSource = newList;
                    }
                    if (index == 2)
                    {
                        foreach (var item in list)
                        {
                            if (item.Item.ToString().ToUpper().Substring(0, txtUnitCost.Text.Length) == txtUnitCost.Text.ToUpper())
                                newList.Add(item);
                        }
                        gvMaterialCost.DataSource = newList;
                    }
                    if (index == 3)
                    {
                        foreach (var item in list)
                        {
                            if (item.Material.ToString().ToUpper().Substring(0, txtUnitCost.Text.Length) == txtUnitCost.Text.ToUpper())
                                newList.Add(item);
                        }
                        gvMaterialCost.DataSource = newList;
                    }
                    if (index == 3)
                    {
                        foreach (var item in list)
                        {
                            if (item.Description.ToString().ToUpper().Substring(0, txtUnitCost.Text.Length) == txtUnitCost.Text.ToUpper())
                                newList.Add(item);
                        }
                        gvMaterialCost.DataSource = newList;
                    }
                    if (index == 3)
                    {
                        foreach (var item in list)
                        {
                            if (item.UnitCost.ToString().ToUpper().Substring(0, txtUnitCost.Text.Length) == txtUnitCost.Text.ToUpper())
                                newList.Add(item);
                        }
                        gvMaterialCost.DataSource = newList;
                    }
                }
                catch
                {
                    gvMaterialCost.DataSource = newList;
                }

            }
        }

        private void btnSaveToMainList_Click(object sender, EventArgs e)
        {
            var list = GridToList();
            var processed = SaveToMainDataBase(list);
            if (string.IsNullOrEmpty(processed))
                MessageBox.Show(processed);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

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

        }

        private void btnSaveDataToGrid_Click(object sender, EventArgs e)
        {
            AddDataToGrid();
        }

        private void btnClearGrid_Click(object sender, EventArgs e)
        {
            gvMaterialCost.DataSource = string.Empty;
        }
    }
}
