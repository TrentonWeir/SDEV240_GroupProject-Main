using MaterialCostLib.BusinessLayer;
using MaterialCostLib.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace SDEV240_GroupProject
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            btnSearch.Text = "Search";
            btnSearch.BackColor = Color.Blue;
            btnSearch.ForeColor = Color.White;
            RefreshForm();
            //btnClearAllData.Visible = false;
        }
        private void RefreshForm()
        {
            gvDataBind();
            SetComboBox();
        }
        private void gvDataBind()
        {
            gvMaterialCost.DataSource = string.Empty;
            var list = CreateTableLayout();
            gvMaterialCost.DataSource = list;
            GetCurrentTotal(list);

        }
        private void GetCurrentTotal(List<SavedEstimatesDTO> list)
        {
            double total = 0;
            foreach (var item in list)
            {
                total += (item.Total);
            }
            lblTotal.Text = $"${total.ToString("0.00")}";
        }

        private List<SavedEstimatesDTO> CreateTableLayout()
        {
            try
            {
                var main = new Main();
                var list = main.SelectEstimates(); ;
                return list;
            }
            catch
            {
                return new List<SavedEstimatesDTO>();
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var index = ddlSearchType.SelectedIndex;
            var db = new Main();
            var list = db.SelectEstimates();
            var newList = new List<SavedEstimatesDTO>();
            gvMaterialCost.DataSource = list;
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                try
                {
                    if (index == 0)
                    {
                        foreach (var item in list)
                        {
                            if (item.EstimateId.ToString().ToUpper().Substring(0, textBox1.Text.Length) == textBox1.Text.ToUpper())
                                newList.Add(item);
                        }
                        gvMaterialCost.DataSource = newList;
                    }
                    if (index == 1)
                    {
                        foreach (var item in list)
                        {
                            if (item.Description.ToString().ToUpper().Substring(0, textBox1.Text.Length) == textBox1.Text.ToUpper())
                                newList.Add(item);
                        }
                        gvMaterialCost.DataSource = newList;
                    }
                    if (index == 2)
                    {
                        foreach (var item in list)
                        {
                            if (item.Total.ToString().ToUpper().Substring(0, textBox1.Text.Length) == textBox1.Text.ToUpper())
                                newList.Add(item);
                        }
                        gvMaterialCost.DataSource = newList;
                    }
                    if (index == 3)
                    {
                        foreach (var item in list)
                        {
                            if (item.Date.ToString().ToUpper().Substring(0, textBox1.Text.Length) == textBox1.Text.ToUpper())
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
        public void SetComboBox()
        {
            ddlSearchType.Items.Add("EstimateId");
            ddlSearchType.Items.Add("Description");
            ddlSearchType.Items.Add("Total");
            ddlSearchType.Items.Add("Date");

            ddlSearchType.SelectedIndex = 0;
        }

        private void btnNavInput_Click(object sender, EventArgs e)
        {
            InputForm inp = new InputForm();
            inp.Show();
        }

        private void btnSaveGrid_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "CSV File|*.csv";
            save.Title = "Save CSV File";
            save.ShowDialog();
            if (!string.IsNullOrWhiteSpace(save.FileName))
            {
                var csv = new StringBuilder();
                foreach (DataGridViewRow row in gvMaterialCost.Rows)
                {
                    var LastInRow = row.Cells.Count - 1;
                    string csvBuilder = string.Empty;
                    for (int i = 0; i < LastInRow; i++)
                    {
                        csvBuilder += $"{row.Cells[i].Value},";
                    }
                    csvBuilder += $"{row.Cells[LastInRow].Value}";
                    csv.AppendLine(csvBuilder);
                }
                File.AppendAllText(save.FileName, csv.ToString());
                MessageBox.Show("Saved!");
            }

        }

        private void btnDeleteSearchItems_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you wish to delete the searched items?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var db = new Main();
                    db.DeleteGridSelection(ddlSearchType.Text, textBox1.Text);
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("../../../DataSource/ERRORLIST.csv", ex.Message);
            }
        }

        private void btnSmallList_Click(object sender, EventArgs e)
        {
            SmallPricingBuild_NotSaved form = new SmallPricingBuild_NotSaved();
            form.Show();
        }
       
        //Admin use only for clearing all databases after testing. Btn hidden for user.
        private void btnClearAllData_Click(object sender, EventArgs e)
        {
            if (File.Exists("../../../DataSource/MainDataBase.csv"))
            {
                File.Delete("../../../DataSource/MainDataBase.csv");
            }
            if (File.Exists("../../../DataSource/MaterialDataBase.csv"))
            {
                File.Delete("../../../DataSource/MaterialDataBase.csv");
            }
            if (File.Exists("../../../DataSource/CategoryDataBase.csv"))
            {
                File.Delete("../../../DataSource/CategoryDataBase.csv");
            }
            gvDataBind();
        }

        private void btnRefreshGrid_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }
    }
}
