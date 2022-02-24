
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
            this.gvMaterialCost = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.gvMaterialCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDTOBindingSource)).BeginInit();
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
            this.Category,
            this.Item,
            this.materialDataGridViewTextBoxColumn,
            this.Description,
            this.Qty,
            this.UnitCost,
            this.Cost});
            this.gvMaterialCost.DataSource = this.mainDTOBindingSource;
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
            this.gvMaterialCost.Size = new System.Drawing.Size(883, 366);
            this.gvMaterialCost.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            // 
            // Item
            // 
            this.Item.DataPropertyName = "Item";
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            // 
            // materialDataGridViewTextBoxColumn
            // 
            this.materialDataGridViewTextBoxColumn.DataPropertyName = "Material";
            this.materialDataGridViewTextBoxColumn.HeaderText = "Material";
            this.materialDataGridViewTextBoxColumn.Name = "materialDataGridViewTextBoxColumn";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // Qty
            // 
            this.Qty.DataPropertyName = "Qty";
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            // 
            // UnitCost
            // 
            this.UnitCost.DataPropertyName = "UnitCost";
            this.UnitCost.HeaderText = "UnitCost";
            this.UnitCost.Name = "UnitCost";
            // 
            // Cost
            // 
            this.Cost.DataPropertyName = "Cost";
            this.Cost.HeaderText = "Cost";
            this.Cost.Name = "Cost";
            // 
            // mainDTOBindingSource
            // 
            this.mainDTOBindingSource.DataSource = typeof(MaterialCostLib.Models.MainDTO);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 155);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 23);
            this.textBox1.TabIndex = 1;
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
            this.btnSaveGrid.Location = new System.Drawing.Point(871, 195);
            this.btnSaveGrid.Name = "btnSaveGrid";
            this.btnSaveGrid.Size = new System.Drawing.Size(95, 23);
            this.btnSaveGrid.TabIndex = 3;
            this.btnSaveGrid.Text = "Save As Excel";
            this.btnSaveGrid.UseVisualStyleBackColor = true;
            this.btnSaveGrid.Click += new System.EventHandler(this.btnSaveGrid_Click);
            // 
            // btnNavInput
            // 
            this.btnNavInput.Location = new System.Drawing.Point(118, 12);
            this.btnNavInput.Name = "btnNavInput";
            this.btnNavInput.Size = new System.Drawing.Size(75, 23);
            this.btnNavInput.TabIndex = 4;
            this.btnNavInput.Text = "InputForm";
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
            this.btnSmallList.Location = new System.Drawing.Point(199, 12);
            this.btnSmallList.Name = "btnSmallList";
            this.btnSmallList.Size = new System.Drawing.Size(75, 23);
            this.btnSmallList.TabIndex = 13;
            this.btnSmallList.Text = "Small List";
            this.btnSmallList.UseVisualStyleBackColor = true;
            this.btnSmallList.Click += new System.EventHandler(this.btnSmallList_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1056, 602);
            this.Controls.Add(this.btnSmallList);
            this.Controls.Add(this.btnDeleteSearchItems);
            this.Controls.Add(this.lblTotalText);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnNavHome);
            this.Controls.Add(this.ddlSearchType);
            this.Controls.Add(this.btnNavInput);
            this.Controls.Add(this.btnSaveGrid);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gvMaterialCost);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "HomeForm";
            this.Text = "SDEV_240Project";
            ((System.ComponentModel.ISupportInitialize)(this.gvMaterialCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvMaterialCost;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSaveGrid;
        private System.Windows.Forms.Button btnNavInput;
        private System.Windows.Forms.BindingSource mainDTOBindingSource;
        private System.Windows.Forms.ComboBox ddlSearchType;
        private System.Windows.Forms.Button btnNavHome;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalText;
        private System.Windows.Forms.Button btnDeleteSearchItems;
        private System.Windows.Forms.Button btnSmallList;
    }
}

