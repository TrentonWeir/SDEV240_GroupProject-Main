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
        }
        private void InputFunction()
        {
           //File.Delete("../../../DataSource/MainDataBase.csv");
            MainDTO item = new MainDTO();
            item.Category = ddlCategoryInput.Text;
            item.Item = textBox1.Text;
            item.Material = ddlMaterialInput.Text;
            item.Description = textBox3.Text;
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
            InputFunction();
        }

        private void InputForm_Load(object sender, EventArgs e)
        {
            LoadMaterials();
            LoadCategories();
        }
        private void LoadMaterials()
        {
            var db = new MaterialCostLib.BusinessLayer.Main();
            var data = db.SelectMaterialData();
            foreach (var item in data)
            {
                ddlMaterialInput.Items.Add(item.Material);
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
        private void Refresh()
        {
            DdlClear();
            LoadCategories();
            LoadMaterials();
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
            Refresh();
        }

        private void btnMaterialSave_Click(object sender, EventArgs e)
        {
            var db = new MaterialCostLib.BusinessLayer.Main();
            db.InsertIntoMaterial(txtMaterial.Text);
            txtMaterial.Text = string.Empty;
            Refresh();
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
                Refresh();
            }
        }
    }
}
