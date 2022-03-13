
namespace SDEV240_GroupProject
{
    partial class SmallPricingBuild_NotSaved
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
            this.gvMaterialCost = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSaveToMainList = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.ddlSearchFilter = new System.Windows.Forms.ComboBox();
            this.btnPrintCSV = new System.Windows.Forms.Button();
            this.btnSaveText = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtUnitCost = new System.Windows.Forms.TextBox();
            this.ddlCategory = new System.Windows.Forms.ComboBox();
            this.ddlMaterial = new System.Windows.Forms.ComboBox();
            this.lblCate = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblUnitCost = new System.Windows.Forms.Label();
            this.btnSaveDataToGrid = new System.Windows.Forms.Button();
            this.btnClearGrid = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSmallListBinding = new System.Windows.Forms.BindingSource(this.components);
            this.btnEditRow = new System.Windows.Forms.Button();
            this.lblEditId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvMaterialCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSmallListBinding)).BeginInit();
            this.SuspendLayout();
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
            this.idDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.itemDataGridViewTextBoxColumn,
            this.materialDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.unitCostDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn});
            this.gvMaterialCost.DataSource = this.gvSmallListBinding;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvMaterialCost.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvMaterialCost.Location = new System.Drawing.Point(81, 148);
            this.gvMaterialCost.Name = "gvMaterialCost";
            this.gvMaterialCost.ReadOnly = true;
            this.gvMaterialCost.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvMaterialCost.Size = new System.Drawing.Size(841, 357);
            this.gvMaterialCost.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(162, 100);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(224, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // btnSaveToMainList
            // 
            this.btnSaveToMainList.Location = new System.Drawing.Point(392, 100);
            this.btnSaveToMainList.Name = "btnSaveToMainList";
            this.btnSaveToMainList.Size = new System.Drawing.Size(111, 23);
            this.btnSaveToMainList.TabIndex = 3;
            this.btnSaveToMainList.Text = "Save To DataBase";
            this.btnSaveToMainList.UseVisualStyleBackColor = true;
            this.btnSaveToMainList.Click += new System.EventHandler(this.btnSaveToMainList_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(81, 98);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(81, 121);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(852, 132);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(70, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total: $00.00";
            // 
            // ddlSearchFilter
            // 
            this.ddlSearchFilter.FormattingEnabled = true;
            this.ddlSearchFilter.Location = new System.Drawing.Point(162, 121);
            this.ddlSearchFilter.Name = "ddlSearchFilter";
            this.ddlSearchFilter.Size = new System.Drawing.Size(121, 21);
            this.ddlSearchFilter.TabIndex = 7;
            this.ddlSearchFilter.SelectedIndexChanged += new System.EventHandler(this.ddlSearchFilter_SelectedIndexChanged);
            // 
            // btnPrintCSV
            // 
            this.btnPrintCSV.Location = new System.Drawing.Point(509, 100);
            this.btnPrintCSV.Name = "btnPrintCSV";
            this.btnPrintCSV.Size = new System.Drawing.Size(75, 23);
            this.btnPrintCSV.TabIndex = 8;
            this.btnPrintCSV.Text = "Save CSV";
            this.btnPrintCSV.UseVisualStyleBackColor = true;
            this.btnPrintCSV.Click += new System.EventHandler(this.btnPrintCSV_Click);
            // 
            // btnSaveText
            // 
            this.btnSaveText.Location = new System.Drawing.Point(593, 100);
            this.btnSaveText.Name = "btnSaveText";
            this.btnSaveText.Size = new System.Drawing.Size(75, 23);
            this.btnSaveText.TabIndex = 9;
            this.btnSaveText.Text = "Save Text";
            this.btnSaveText.UseVisualStyleBackColor = true;
            this.btnSaveText.Click += new System.EventHandler(this.btnSaveText_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(462, 51);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 20);
            this.txtDescription.TabIndex = 10;
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(216, 50);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(113, 20);
            this.txtItem.TabIndex = 11;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(568, 51);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(100, 20);
            this.txtQty.TabIndex = 12;
            // 
            // txtUnitCost
            // 
            this.txtUnitCost.Location = new System.Drawing.Point(674, 51);
            this.txtUnitCost.Name = "txtUnitCost";
            this.txtUnitCost.Size = new System.Drawing.Size(100, 20);
            this.txtUnitCost.TabIndex = 13;
            // 
            // ddlCategory
            // 
            this.ddlCategory.FormattingEnabled = true;
            this.ddlCategory.Location = new System.Drawing.Point(89, 49);
            this.ddlCategory.Name = "ddlCategory";
            this.ddlCategory.Size = new System.Drawing.Size(121, 21);
            this.ddlCategory.TabIndex = 14;
            // 
            // ddlMaterial
            // 
            this.ddlMaterial.FormattingEnabled = true;
            this.ddlMaterial.Location = new System.Drawing.Point(335, 50);
            this.ddlMaterial.Name = "ddlMaterial";
            this.ddlMaterial.Size = new System.Drawing.Size(121, 21);
            this.ddlMaterial.TabIndex = 15;
            // 
            // lblCate
            // 
            this.lblCate.AutoSize = true;
            this.lblCate.Location = new System.Drawing.Point(86, 33);
            this.lblCate.Name = "lblCate";
            this.lblCate.Size = new System.Drawing.Size(49, 13);
            this.lblCate.TabIndex = 16;
            this.lblCate.Text = "Category";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(220, 33);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(27, 13);
            this.lblItem.TabIndex = 17;
            this.lblItem.Text = "Item";
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Location = new System.Drawing.Point(332, 33);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(44, 13);
            this.lblMaterial.TabIndex = 18;
            this.lblMaterial.Text = "Material";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(459, 33);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 19;
            this.lblDescription.Text = "Description";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(565, 33);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(23, 13);
            this.lblQty.TabIndex = 20;
            this.lblQty.Text = "Qty";
            // 
            // lblUnitCost
            // 
            this.lblUnitCost.AutoSize = true;
            this.lblUnitCost.Location = new System.Drawing.Point(671, 33);
            this.lblUnitCost.Name = "lblUnitCost";
            this.lblUnitCost.Size = new System.Drawing.Size(50, 13);
            this.lblUnitCost.TabIndex = 21;
            this.lblUnitCost.Text = "Unit Cost";
            // 
            // btnSaveDataToGrid
            // 
            this.btnSaveDataToGrid.Location = new System.Drawing.Point(814, 47);
            this.btnSaveDataToGrid.Name = "btnSaveDataToGrid";
            this.btnSaveDataToGrid.Size = new System.Drawing.Size(75, 23);
            this.btnSaveDataToGrid.TabIndex = 22;
            this.btnSaveDataToGrid.Text = "Save";
            this.btnSaveDataToGrid.UseVisualStyleBackColor = true;
            this.btnSaveDataToGrid.Click += new System.EventHandler(this.btnSaveDataToGrid_Click);
            // 
            // btnClearGrid
            // 
            this.btnClearGrid.Location = new System.Drawing.Point(814, 98);
            this.btnClearGrid.Name = "btnClearGrid";
            this.btnClearGrid.Size = new System.Drawing.Size(108, 23);
            this.btnClearGrid.TabIndex = 23;
            this.btnClearGrid.Text = "Clear Grid";
            this.btnClearGrid.UseVisualStyleBackColor = true;
            this.btnClearGrid.Click += new System.EventHandler(this.btnClearGrid_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemDataGridViewTextBoxColumn
            // 
            this.itemDataGridViewTextBoxColumn.DataPropertyName = "Item";
            this.itemDataGridViewTextBoxColumn.HeaderText = "Item";
            this.itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
            this.itemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materialDataGridViewTextBoxColumn
            // 
            this.materialDataGridViewTextBoxColumn.DataPropertyName = "Material";
            this.materialDataGridViewTextBoxColumn.HeaderText = "Material";
            this.materialDataGridViewTextBoxColumn.Name = "materialDataGridViewTextBoxColumn";
            this.materialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitCostDataGridViewTextBoxColumn
            // 
            this.unitCostDataGridViewTextBoxColumn.DataPropertyName = "UnitCost";
            this.unitCostDataGridViewTextBoxColumn.HeaderText = "UnitCost";
            this.unitCostDataGridViewTextBoxColumn.Name = "unitCostDataGridViewTextBoxColumn";
            this.unitCostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gvSmallListBinding
            // 
            this.gvSmallListBinding.DataSource = typeof(MaterialCostLib.Models.MainDTO);
            // 
            // btnEditRow
            // 
            this.btnEditRow.Location = new System.Drawing.Point(392, 122);
            this.btnEditRow.Name = "btnEditRow";
            this.btnEditRow.Size = new System.Drawing.Size(111, 23);
            this.btnEditRow.TabIndex = 24;
            this.btnEditRow.Text = "Edit Row";
            this.btnEditRow.UseVisualStyleBackColor = true;
            this.btnEditRow.Click += new System.EventHandler(this.btnEditRow_Click);
            // 
            // lblEditId
            // 
            this.lblEditId.AutoSize = true;
            this.lblEditId.Location = new System.Drawing.Point(86, 9);
            this.lblEditId.Name = "lblEditId";
            this.lblEditId.Size = new System.Drawing.Size(0, 13);
            this.lblEditId.TabIndex = 25;
            // 
            // SmallPricingBuild_NotSaved
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 508);
            this.Controls.Add(this.lblEditId);
            this.Controls.Add(this.btnEditRow);
            this.Controls.Add(this.btnClearGrid);
            this.Controls.Add(this.btnSaveDataToGrid);
            this.Controls.Add(this.lblUnitCost);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblCate);
            this.Controls.Add(this.ddlMaterial);
            this.Controls.Add(this.ddlCategory);
            this.Controls.Add(this.txtUnitCost);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnSaveText);
            this.Controls.Add(this.btnPrintCSV);
            this.Controls.Add(this.ddlSearchFilter);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSaveToMainList);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.gvMaterialCost);
            this.Name = "SmallPricingBuild_NotSaved";
            this.Text = "SmallPricingBuild_NotSaved";
            ((System.ComponentModel.ISupportInitialize)(this.gvMaterialCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSmallListBinding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvMaterialCost;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSaveToMainList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ComboBox ddlSearchFilter;
        private System.Windows.Forms.Button btnPrintCSV;
        private System.Windows.Forms.Button btnSaveText;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtUnitCost;
        private System.Windows.Forms.ComboBox ddlCategory;
        private System.Windows.Forms.ComboBox ddlMaterial;
        private System.Windows.Forms.Label lblCate;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblUnitCost;
        private System.Windows.Forms.Button btnSaveDataToGrid;
        private System.Windows.Forms.BindingSource gvSmallListBinding;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnClearGrid;
        private System.Windows.Forms.Button btnEditRow;
        private System.Windows.Forms.Label lblEditId;
    }
}