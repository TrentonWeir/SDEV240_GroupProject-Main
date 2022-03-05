
namespace SDEV240_GroupProject
{
    partial class InputForm
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
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblUnitCost = new System.Windows.Forms.Label();
            this.btnNewCostRecord = new System.Windows.Forms.Button();
            this.ddlCategoryInput = new System.Windows.Forms.ComboBox();
            this.ddlMaterialInput = new System.Windows.Forms.ComboBox();
            this.lblMaterialList = new System.Windows.Forms.Label();
            this.lblCategroyList = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.btnCategorySave = new System.Windows.Forms.Button();
            this.btnMaterialSave = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnDeleteMaterial = new System.Windows.Forms.Button();
            this.txtQty = new System.Windows.Forms.NumericUpDown();
            this.txtUnitCost = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(34, 43);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(140, 43);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(27, 13);
            this.lblItem.TabIndex = 3;
            this.lblItem.Text = "Item";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(143, 59);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(100, 20);
            this.txtItem.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Material";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(352, 43);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(355, 59);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 20);
            this.txtDescription.TabIndex = 6;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(458, 43);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(46, 13);
            this.lblQty.TabIndex = 9;
            this.lblQty.Text = "Quantity";
            // 
            // lblUnitCost
            // 
            this.lblUnitCost.AutoSize = true;
            this.lblUnitCost.Location = new System.Drawing.Point(564, 43);
            this.lblUnitCost.Name = "lblUnitCost";
            this.lblUnitCost.Size = new System.Drawing.Size(50, 13);
            this.lblUnitCost.TabIndex = 11;
            this.lblUnitCost.Text = "Unit Cost";
            // 
            // btnNewCostRecord
            // 
            this.btnNewCostRecord.Location = new System.Drawing.Point(673, 57);
            this.btnNewCostRecord.Name = "btnNewCostRecord";
            this.btnNewCostRecord.Size = new System.Drawing.Size(102, 23);
            this.btnNewCostRecord.TabIndex = 14;
            this.btnNewCostRecord.Text = "Save this to List";
            this.btnNewCostRecord.UseVisualStyleBackColor = true;
            this.btnNewCostRecord.Click += new System.EventHandler(this.btnNewCostRecord_Click);
            // 
            // ddlCategoryInput
            // 
            this.ddlCategoryInput.FormattingEnabled = true;
            this.ddlCategoryInput.Location = new System.Drawing.Point(37, 58);
            this.ddlCategoryInput.Name = "ddlCategoryInput";
            this.ddlCategoryInput.Size = new System.Drawing.Size(100, 21);
            this.ddlCategoryInput.TabIndex = 15;
            // 
            // ddlMaterialInput
            // 
            this.ddlMaterialInput.FormattingEnabled = true;
            this.ddlMaterialInput.Location = new System.Drawing.Point(249, 59);
            this.ddlMaterialInput.Name = "ddlMaterialInput";
            this.ddlMaterialInput.Size = new System.Drawing.Size(100, 21);
            this.ddlMaterialInput.TabIndex = 16;
            // 
            // lblMaterialList
            // 
            this.lblMaterialList.AutoSize = true;
            this.lblMaterialList.Location = new System.Drawing.Point(34, 207);
            this.lblMaterialList.Name = "lblMaterialList";
            this.lblMaterialList.Size = new System.Drawing.Size(71, 13);
            this.lblMaterialList.TabIndex = 17;
            this.lblMaterialList.Text = "Material Input";
            // 
            // lblCategroyList
            // 
            this.lblCategroyList.AutoSize = true;
            this.lblCategroyList.Location = new System.Drawing.Point(34, 131);
            this.lblCategroyList.Name = "lblCategroyList";
            this.lblCategroyList.Size = new System.Drawing.Size(76, 13);
            this.lblCategroyList.TabIndex = 18;
            this.lblCategroyList.Text = "Category Input";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(37, 147);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(130, 20);
            this.txtCategory.TabIndex = 19;
            // 
            // txtMaterial
            // 
            this.txtMaterial.Location = new System.Drawing.Point(37, 223);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(130, 20);
            this.txtMaterial.TabIndex = 20;
            // 
            // btnCategorySave
            // 
            this.btnCategorySave.Location = new System.Drawing.Point(179, 144);
            this.btnCategorySave.Name = "btnCategorySave";
            this.btnCategorySave.Size = new System.Drawing.Size(75, 23);
            this.btnCategorySave.TabIndex = 21;
            this.btnCategorySave.Text = "Save";
            this.btnCategorySave.UseVisualStyleBackColor = true;
            this.btnCategorySave.Click += new System.EventHandler(this.btnCategorySave_Click);
            // 
            // btnMaterialSave
            // 
            this.btnMaterialSave.Location = new System.Drawing.Point(179, 220);
            this.btnMaterialSave.Name = "btnMaterialSave";
            this.btnMaterialSave.Size = new System.Drawing.Size(75, 23);
            this.btnMaterialSave.TabIndex = 22;
            this.btnMaterialSave.Text = "Save";
            this.btnMaterialSave.UseVisualStyleBackColor = true;
            this.btnMaterialSave.Click += new System.EventHandler(this.btnMaterialSave_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(260, 144);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCategory.TabIndex = 23;
            this.btnDeleteCategory.Text = "Delete";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            // 
            // btnDeleteMaterial
            // 
            this.btnDeleteMaterial.Location = new System.Drawing.Point(260, 220);
            this.btnDeleteMaterial.Name = "btnDeleteMaterial";
            this.btnDeleteMaterial.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteMaterial.TabIndex = 24;
            this.btnDeleteMaterial.Text = "Delete";
            this.btnDeleteMaterial.UseVisualStyleBackColor = true;
            this.btnDeleteMaterial.Click += new System.EventHandler(this.btnDeleteMaterial_Click);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(461, 60);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(100, 20);
            this.txtQty.TabIndex = 25;
            // 
            // txtUnitCost
            // 
            this.txtUnitCost.Location = new System.Drawing.Point(567, 60);
            this.txtUnitCost.Name = "txtUnitCost";
            this.txtUnitCost.Size = new System.Drawing.Size(100, 20);
            this.txtUnitCost.TabIndex = 26;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 408);
            this.Controls.Add(this.txtUnitCost);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.btnDeleteMaterial);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.btnMaterialSave);
            this.Controls.Add(this.btnCategorySave);
            this.Controls.Add(this.txtMaterial);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.lblCategroyList);
            this.Controls.Add(this.lblMaterialList);
            this.Controls.Add(this.ddlMaterialInput);
            this.Controls.Add(this.ddlCategoryInput);
            this.Controls.Add(this.btnNewCostRecord);
            this.Controls.Add(this.lblUnitCost);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.lblCategory);
            this.Name = "InputForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.InputForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblUnitCost;
        private System.Windows.Forms.Button btnNewCostRecord;
        private System.Windows.Forms.ComboBox ddlCategoryInput;
        private System.Windows.Forms.ComboBox ddlMaterialInput;
        private System.Windows.Forms.Label lblMaterialList;
        private System.Windows.Forms.Label lblCategroyList;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtMaterial;
        private System.Windows.Forms.Button btnCategorySave;
        private System.Windows.Forms.Button btnMaterialSave;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnDeleteMaterial;
        private System.Windows.Forms.NumericUpDown txtQty;
        private System.Windows.Forms.TextBox txtUnitCost;
    }
}