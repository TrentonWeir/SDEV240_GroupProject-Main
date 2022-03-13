using MaterialCostLib.BusinessLayer;
using MaterialCostLib.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;


namespace SDEV240_GroupProject
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
            btnNewCostRecord.Visible = false;
            txtItem.Visible = false;
            lblItem.Visible = false;
            txtDescription.Visible = false;
            lblDescription.Visible = false;
            txtQty.Visible = false;
            lblQty.Visible = false;
            txtUnitCost.Visible = false;
            lblUnitCost.Visible = false;
        }
        private void InputFunction()
        {
            //No longer used. This was the first method for inputing data before it was moved tot he SmallPricingBuild app. This is still used in the main group project.
            MainDTO item = new MainDTO();
            item.Category = ddlCategoryInput.Text;
            item.Item = txtItem.Text;
            item.Material = ddlMaterialInput.Text;
            item.Description = txtDescription.Text;
            item.Qty = Convert.ToInt32(txtQty.Value);
            item.UnitCost = float.Parse(txtUnitCost.Text);
            item.Cost = (item.UnitCost * item.Qty).ToString("C", CultureInfo.CurrentCulture);
            var list = new List<MainDTO>();
            list.Add(item);
            var db = new Main();
            db.InsertDataToMain(list.ToList());
        }

        private void InputForm_Load(object sender, EventArgs e)
        {
            // activates drop downs and populates with data from database
            LoadMaterials();
            LoadCategories();
        }
        private void LoadMaterials()
        {
            //finds data from database and populates dropdown
            try
            {
                var db = new MaterialCostLib.BusinessLayer.Main();
                var data = db.SelectMaterialData();
                foreach (var item in data)
                {
                    ddlMaterialInput.Items.Add(item.Material);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }

        }
        private void LoadCategories()
        {
            //finds data from database and populates dropdown
            try
            {
                var db = new MaterialCostLib.BusinessLayer.Main();
                var data = db.SelectCategorylData();
                foreach (var item in data)
                {
                    ddlCategoryInput.Items.Add(item.Category);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
        private void RefreshThisForm()
        {
            //Refreshes page
            try
            {
                DdlClear();
                LoadCategories();
                LoadMaterials();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
        private void DdlClear()
        {
            // clears dropdown data
            ddlCategoryInput.Items.Clear();
            ddlMaterialInput.Items.Clear();
        }

        private void btnCategorySave_Click(object sender, EventArgs e)
        {
            // saves Category to database
            try
            {
                var db = new MaterialCostLib.BusinessLayer.Main();
                db.InsertIntoCategory(txtCategory.Text);
                txtCategory.Text = string.Empty;
                RefreshThisForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void btnMaterialSave_Click(object sender, EventArgs e)
        {
            //saves material to database
            try
            {
                var db = new MaterialCostLib.BusinessLayer.Main();
                db.InsertIntoMaterial(txtMaterial.Text);
                txtMaterial.Text = string.Empty;
                RefreshThisForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void btnDeleteMaterial_Click(object sender, EventArgs e)
        {
            // deletes material from database
            var db = new Main();
            bool result = db.DeleteMaterial(txtMaterial.Text);
            if (!result)
            {
                MessageBox.Show("Failed to delete Material. Check your spelling. Copy and Paste from Material drop down if needed.");
            }
            else
            {
                MessageBox.Show($"{txtMaterial.Text} has been successfully removed.");
                txtMaterial.Text = string.Empty;
                RefreshThisForm();
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            //deletes category from database
            var db = new Main();
            bool result = db.DeleteCategroy(txtMaterial.Text);

            if (!result)
            {
                MessageBox.Show("Failed to delete Category. Make sure the text matches exactly. Copy and paste from the category drop down if needed.");
            }
            else
            {
                MessageBox.Show($"{txtCategory.Text} has been successfully removed.");
                txtCategory.Text = string.Empty;
                RefreshThisForm();
            }
        }
    }
}
