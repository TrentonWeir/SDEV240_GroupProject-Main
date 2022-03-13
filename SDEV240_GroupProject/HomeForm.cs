using MaterialCostLib.BusinessLayer;
using MaterialCostLib.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SDEV240_GroupProject
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            btnSearch.Text = "Search";
            RefreshForm();
            btnClearAllData.Visible = false;
        }
        private void RefreshForm()
        {
            //Refreshes text fields and drop down lists
            gvDataBind();
            SetComboBox();
        }
        private void gvDataBind()
        {
            // binds data to grid
            ddlSearchType.Items.Clear();
            gvMaterialCost.DataSource = string.Empty;
            var list = CreateTableLayout();
            gvMaterialCost.DataSource = list;
            GetCurrentTotal(list);
        }
        private void GetCurrentTotal(List<SavedEstimatesDTO> list)
        {
            //Gets Total from grid data
            double total = 0;
            foreach (var item in list)
            {
                total += (item.Total);
            }
            lblTotal.Text = $"${total.ToString("0.00")}";
        }

        private List<SavedEstimatesDTO> CreateTableLayout()
        {
            //Gets data from database to use for databind
            try
            {
                var main = new Main();
                var list = main.SelectEstimates();
                return list;
            }
            catch
            {
                return new List<SavedEstimatesDTO>();
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Searches for dat based on a what is in the search box and selected search type
            var index = ddlSearchType.SelectedIndex;
            var db = new Main();
            var list = db.SelectEstimates();
            var newList = new List<SavedEstimatesDTO>();
            gvMaterialCost.DataSource = list;
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                try
                {
                    if (index == 0)
                    {
                        foreach (var item in list)
                        {
                            if (item.EstimateId.ToString().ToUpper().Substring(0, txtSearch.Text.Length) == txtSearch.Text.ToUpper())
                                newList.Add(item);
                        }
                        gvMaterialCost.DataSource = newList;
                    }
                    if (index == 1)
                    {
                        foreach (var item in list)
                        {
                            if (item.Description.ToString().ToUpper().Substring(0, txtSearch.Text.Length) == txtSearch.Text.ToUpper())
                                newList.Add(item);
                        }
                        gvMaterialCost.DataSource = newList;
                    }
                    if (index == 2)
                    {
                        foreach (var item in list)
                        {
                            if (item.Total.ToString().ToUpper().Substring(0, txtSearch.Text.Length) == txtSearch.Text.ToUpper())
                                newList.Add(item);
                        }
                        gvMaterialCost.DataSource = newList;
                    }
                    if (index == 3)
                    {
                        foreach (var item in list)
                        {
                            if (item.Date.ToString().ToUpper().Substring(0, txtSearch.Text.Length) == txtSearch.Text.ToUpper())
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
            // sets drop down list items
            ddlSearchType.Items.Add("EstimateId");
            ddlSearchType.Items.Add("Description");
            ddlSearchType.Items.Add("Total");
            ddlSearchType.Items.Add("Date");
            ddlSearchType.SelectedIndex = 0;
        }

        private void btnNavInput_Click(object sender, EventArgs e)
        {
            // opens a new input form
            InputForm inp = new InputForm();
            inp.Show();
        }

        private void btnSaveGrid_Click(object sender, EventArgs e)
        {
            // saves data as a CSV file for export use
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
            //deletes selected/searched items
            try
            {
                if (MessageBox.Show("Are you sure you wish to delete the searched items?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var db = new Main();
                    db.DeleteGridSelection(ddlSearchType.Text, txtSearch.Text);
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText("../../../DataSource/ERRORLIST.csv", ex.Message);
            }
        }

        private void btnSmallList_Click(object sender, EventArgs e)
        {
            // opens a new estimate form
            SmallPricingBuild_NotSaved form = new SmallPricingBuild_NotSaved();
            form.Show();
        }

        //Admin use only for clearing all databases after testing. Btn hidden for user.
        private void btnClearAllData_Click(object sender, EventArgs e)
        {
            //Used only as admin when btnClearAllData is visable. used for Testing purposes
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
            // activates refresh opperation on click
            RefreshForm();
        }
        private List<MainDTO> GetEditData(int id)
        {
            //Gets data from a selected Id, and changes it to an object list for editable use.
            var list = new List<MainDTO>();
            var estimate = CreateTableLayout();
            var item = estimate.Where(x => x.EstimateId == id).First();
            var lines = item.Description.Split('~');
            foreach (var line in lines)
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    var newline = line.Split('|');
                    list.Add(new MainDTO
                    {
                        Id = Convert.ToInt32(newline[0]),
                        Category = Convert.ToString(newline[1]),
                        Item = Convert.ToString(newline[2]),
                        Material = Convert.ToString(newline[3]),
                        Description = Convert.ToString(newline[4]),
                        Qty = float.Parse(newline[5]),
                        UnitCost = float.Parse(newline[6]),
                        Cost = Convert.ToString(newline[7])
                    });
                }

            }

            return list;
        }
        private int GetIndexForId(string search = null)
        {
            //gets Id of item needed for edit
            int id = 0;
            if (ddlSearchType.SelectedIndex == 0)
            {
                id = CreateTableLayout().Where(x => x.EstimateId.ToString().ToUpper().StartsWith(search.ToUpper())).Select(x => x.EstimateId).First();
            }
            if (ddlSearchType.SelectedIndex == 1)
            {
                id = CreateTableLayout().Where(x => x.Description.ToUpper().StartsWith(search.ToUpper())).Select(x => x.EstimateId).First();
            }
            if (ddlSearchType.SelectedIndex == 2)
            {
                id = CreateTableLayout().Where(x => x.Total == Convert.ToDouble(search)).Select(x => x.EstimateId).First();
            }
            if (ddlSearchType.SelectedIndex == 3)
            {
                id = CreateTableLayout().Where(x => x.Date.ToString().StartsWith(search)).Select(x => x.EstimateId).First();
            }

            return id;
        }

        private void btnEditId_Click(object sender, EventArgs e)
        {
            //gets data from grid and opens in a new Extimater app for editing.
            try
            {
                var search = txtSearch.Text;
                var id = GetIndexForId(search);
                var list = GetEditData(id);
                SmallPricingBuild_NotSaved form = new SmallPricingBuild_NotSaved(list, id);
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("The search was in incorrect format. Search first and see if you get a result before using the editor" + ex.Message);
            }

        }
    }
}
