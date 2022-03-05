using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialCostLib.BusinessLayer;
using MaterialCostLib.Models;


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
           //File.Delete("../../../DataSource/MainDataBase.csv");//Used for deleteing everthing inTests
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

        private void btnNewCostRecord_Click(object sender, EventArgs e)
        {
            try
            {
                if(ValidateTextBoxes())
                {
                    InputFunction();
                }
                else
                {
                    MessageBox.Show($"Please enter the Unit Cost with a number, No \"$\" or letters please.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
                
            
        }
        private bool ValidateTextBoxes()
        {
            var str = string.Empty;
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(txtUnitCost.Text) && Convert.ToDecimal(txtUnitCost.Text) > 0)
            {

            }
            else
                str += $"Please enter the Unit Cost with a number, No \"$\" or letters please.";

            return isValid;
            
        }

        private void InputForm_Load(object sender, EventArgs e)
        {
            LoadMaterials();
            LoadCategories();
        }
        private void LoadMaterials()
        {
            try
            {
                var db = new MaterialCostLib.BusinessLayer.Main();
                var data = db.SelectMaterialData();
                foreach (var item in data)
                {
                    ddlMaterialInput.Items.Add(item.Material);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex}");
            }

        }
        private void LoadCategories()
        {
            var db = new MaterialCostLib.BusinessLayer.Main();
            var data = db.SelectCategorylData();
            foreach (var item in data)
            {
                ddlCategoryInput.Items.Add(item.Category);
            }
        }
        private void RefreshThisForm()
        {
            try
            {
                DdlClear();
                LoadCategories();
                LoadMaterials();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }
        private void DdlClear()
        {
            ddlCategoryInput.Items.Clear();
            ddlMaterialInput.Items.Clear();
        }

        private void btnCategorySave_Click(object sender, EventArgs e)
        {
            var db = new MaterialCostLib.BusinessLayer.Main();
            db.InsertIntoCategory(txtCategory.Text);
            txtCategory.Text = string.Empty;
            RefreshThisForm();
        }

        private void btnMaterialSave_Click(object sender, EventArgs e)
        {
            var db = new MaterialCostLib.BusinessLayer.Main();
            db.InsertIntoMaterial(txtMaterial.Text);
            txtMaterial.Text = string.Empty;
            RefreshThisForm();
        }

        private void btnDeleteMaterial_Click(object sender, EventArgs e)
        {
            var db = new Main();
            bool result = db.DeleteMaterial(txtMaterial.Text);
            if (!result)
            {
                MessageBox.Show("Failed to delete Material. Check your spelling.");
            }
            else
            {
                MessageBox.Show($"{txtMaterial.Text} has been successfully removed.");
                txtMaterial.Text = string.Empty;
                RefreshThisForm();
            }
        }
    }
}
