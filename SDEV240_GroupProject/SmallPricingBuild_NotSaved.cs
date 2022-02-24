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
        DataTable grid = new DataTable();
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
                txtDescription.Text = "THis";
                txtItem.Text = "hello";
                txtQty.Text = "1";
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
                var list = new List<MainDTO>();
                double cost = Convert.ToDouble(txtUnitCost.Text) * Convert.ToDouble(txtQty.Text);

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
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnPrintCSV_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveText_Click(object sender, EventArgs e)
        {

        }

        private void ddlSearchFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveDataToGrid_Click(object sender, EventArgs e)
        {
            AddDataToGrid();
        }
    }
}
