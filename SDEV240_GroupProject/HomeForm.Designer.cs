
namespace SDEV240_GroupProject
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSaveGrid = new System.Windows.Forms.Button();
            this.btnNavInput = new System.Windows.Forms.Button();
            this.ddlSearchType = new System.Windows.Forms.ComboBox();
            this.btnNavHome = new System.Windows.Forms.Button();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalText = new System.Windows.Forms.Label();
            this.btnDeleteSearchItems = new System.Windows.Forms.Button();
            this.btnSmallList = new System.Windows.Forms.Button();
            this.btnClearAllData = new System.Windows.Forms.Button();
            this.btnRefreshGrid = new System.Windows.Forms.Button();
            this.gvMaterialCost = new System.Windows.Forms.DataGridView();
            this.estimateIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.savedEstimatesDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEditId = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvMaterialCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.savedEstimatesDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(164, 155);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(221, 23);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(83, 155);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSaveGrid
            // 
            this.btnSaveGrid.Location = new System.Drawing.Point(851, 195);
            this.btnSaveGrid.Name = "btnSaveGrid";
            this.btnSaveGrid.Size = new System.Drawing.Size(90, 23);
            this.btnSaveGrid.TabIndex = 3;
            this.btnSaveGrid.Text = "Save As Excel";
            this.btnSaveGrid.UseVisualStyleBackColor = true;
            this.btnSaveGrid.Click += new System.EventHandler(this.btnSaveGrid_Click);
            // 
            // btnNavInput
            // 
            this.btnNavInput.Location = new System.Drawing.Point(118, 12);
            this.btnNavInput.Name = "btnNavInput";
            this.btnNavInput.Size = new System.Drawing.Size(102, 23);
            this.btnNavInput.TabIndex = 4;
            this.btnNavInput.Text = "Adjust Drop Down";
            this.btnNavInput.UseVisualStyleBackColor = true;
            this.btnNavInput.Click += new System.EventHandler(this.btnNavInput_Click);
            // 
            // ddlSearchType
            // 
            this.ddlSearchType.FormattingEnabled = true;
            this.ddlSearchType.Location = new System.Drawing.Point(164, 184);
            this.ddlSearchType.Name = "ddlSearchType";
            this.ddlSearchType.Size = new System.Drawing.Size(121, 21);
            this.ddlSearchType.TabIndex = 5;
            // 
            // btnNavHome
            // 
            this.btnNavHome.Location = new System.Drawing.Point(37, 12);
            this.btnNavHome.Name = "btnNavHome";
            this.btnNavHome.Size = new System.Drawing.Size(75, 23);
            this.btnNavHome.TabIndex = 9;
            this.btnNavHome.Text = "Home";
            this.btnNavHome.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(849, 143);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(2, 19);
            this.lblTotal.TabIndex = 10;
            // 
            // lblTotalText
            // 
            this.lblTotalText.AutoSize = true;
            this.lblTotalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalText.Location = new System.Drawing.Point(788, 143);
            this.lblTotalText.Name = "lblTotalText";
            this.lblTotalText.Size = new System.Drawing.Size(55, 17);
            this.lblTotalText.TabIndex = 11;
            this.lblTotalText.Text = "Total: ";
            // 
            // btnDeleteSearchItems
            // 
            this.btnDeleteSearchItems.Location = new System.Drawing.Point(391, 155);
            this.btnDeleteSearchItems.Name = "btnDeleteSearchItems";
            this.btnDeleteSearchItems.Size = new System.Drawing.Size(125, 23);
            this.btnDeleteSearchItems.TabIndex = 12;
            this.btnDeleteSearchItems.Text = "Delete Searched Items";
            this.btnDeleteSearchItems.UseVisualStyleBackColor = true;
            this.btnDeleteSearchItems.Click += new System.EventHandler(this.btnDeleteSearchItems_Click);
            // 
            // btnSmallList
            // 
            this.btnSmallList.Location = new System.Drawing.Point(226, 12);
            this.btnSmallList.Name = "btnSmallList";
            this.btnSmallList.Size = new System.Drawing.Size(99, 23);
            this.btnSmallList.TabIndex = 13;
            this.btnSmallList.Text = "Estimate Builder";
            this.btnSmallList.UseVisualStyleBackColor = true;
            this.btnSmallList.Click += new System.EventHandler(this.btnSmallList_Click);
            // 
            // btnClearAllData
            // 
            this.btnClearAllData.Location = new System.Drawing.Point(817, 12);
            this.btnClearAllData.Name = "btnClearAllData";
            this.btnClearAllData.Size = new System.Drawing.Size(113, 23);
            this.btnClearAllData.TabIndex = 14;
            this.btnClearAllData.Text = "Clear All Data";
            this.btnClearAllData.UseVisualStyleBackColor = true;
            this.btnClearAllData.Click += new System.EventHandler(this.btnClearAllData_Click);
            // 
            // btnRefreshGrid
            // 
            this.btnRefreshGrid.Location = new System.Drawing.Point(736, 12);
            this.btnRefreshGrid.Name = "btnRefreshGrid";
            this.btnRefreshGrid.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshGrid.TabIndex = 15;
            this.btnRefreshGrid.Text = "Refresh";
            this.btnRefreshGrid.UseVisualStyleBackColor = true;
            this.btnRefreshGrid.Click += new System.EventHandler(this.btnRefreshGrid_Click);
            // 
            // gvMaterialCost
            // 
            this.gvMaterialCost.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvMaterialCost.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvMaterialCost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMaterialCost.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.estimateIdDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.gvMaterialCost.DataSource = this.savedEstimatesDTOBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvMaterialCost.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvMaterialCost.Location = new System.Drawing.Point(83, 224);
            this.gvMaterialCost.Name = "gvMaterialCost";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvMaterialCost.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gvMaterialCost.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvMaterialCost.Size = new System.Drawing.Size(858, 366);
            this.gvMaterialCost.TabIndex = 0;
            // 
            // estimateIdDataGridViewTextBoxColumn
            // 
            this.estimateIdDataGridViewTextBoxColumn.DataPropertyName = "EstimateId";
            this.estimateIdDataGridViewTextBoxColumn.HeaderText = "EstimateId";
            this.estimateIdDataGridViewTextBoxColumn.Name = "estimateIdDataGridViewTextBoxColumn";
            this.estimateIdDataGridViewTextBoxColumn.Width = 75;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MaxInputLength = 300000;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.descriptionDataGridViewTextBoxColumn.Width = 540;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.Width = 50;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 150;
            // 
            // savedEstimatesDTOBindingSource
            // 
            this.savedEstimatesDTOBindingSource.DataSource = typeof(MaterialCostLib.Models.SavedEstimatesDTO);
            // 
            // mainDTOBindingSource
            // 
            this.mainDTOBindingSource.DataSource = typeof(MaterialCostLib.Models.MainDTO);
            // 
            // btnEditId
            // 
            this.btnEditId.Location = new System.Drawing.Point(391, 182);
            this.btnEditId.Name = "btnEditId";
            this.btnEditId.Size = new System.Drawing.Size(125, 23);
            this.btnEditId.TabIndex = 16;
            this.btnEditId.Text = "Edit Searched Id";
            this.btnEditId.UseVisualStyleBackColor = true;
            this.btnEditId.Click += new System.EventHandler(this.btnEditId_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1056, 602);
            this.Controls.Add(this.btnEditId);
            this.Controls.Add(this.btnRefreshGrid);
            this.Controls.Add(this.btnClearAllData);
            this.Controls.Add(this.btnSmallList);
            this.Controls.Add(this.btnDeleteSearchItems);
            this.Controls.Add(this.lblTotalText);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnNavHome);
            this.Controls.Add(this.ddlSearchType);
            this.Controls.Add(this.btnNavInput);
            this.Controls.Add(this.btnSaveGrid);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.gvMaterialCost);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "HomeForm";
            this.Text = "SDEV_240Project";
            ((System.ComponentModel.ISupportInitialize)(this.gvMaterialCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.savedEstimatesDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSaveGrid;
        private System.Windows.Forms.Button btnNavInput;
        private System.Windows.Forms.BindingSource mainDTOBindingSource;
        private System.Windows.Forms.ComboBox ddlSearchType;
        private System.Windows.Forms.Button btnNavHome;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalText;
        private System.Windows.Forms.Button btnDeleteSearchItems;
        private System.Windows.Forms.Button btnSmallList;
        private System.Windows.Forms.Button btnClearAllData;
        private System.Windows.Forms.Button btnRefreshGrid;
        private System.Windows.Forms.BindingSource savedEstimatesDTOBindingSource;
        private System.Windows.Forms.DataGridView gvMaterialCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn estimateIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnEditId;
    }
}

