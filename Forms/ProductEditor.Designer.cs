namespace Pleres.Forms
{
    partial class ProductEditor
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
            this.gdvProducts = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_BrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_GenericName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_RegistrationNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Lot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_BasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.District = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gdvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // gdvProducts
            // 
            this.gdvProducts.AllowUserToResizeColumns = false;
            this.gdvProducts.AllowUserToResizeRows = false;
            this.gdvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.gdvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.gdvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.Product_Category,
            this.Product_BrandName,
            this.Product_GenericName,
            this.Product_RegistrationNumber,
            this.Product_Lot,
            this.Product_BasePrice,
            this.Product_Cost,
            this.District});
            this.gdvProducts.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gdvProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gdvProducts.GridColor = System.Drawing.Color.DimGray;
            this.gdvProducts.Location = new System.Drawing.Point(12, 513);
            this.gdvProducts.MultiSelect = false;
            this.gdvProducts.Name = "gdvProducts";
            this.gdvProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.gdvProducts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gdvProducts.Size = new System.Drawing.Size(812, 94);
            this.gdvProducts.TabIndex = 0;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.ToolTipText = "The Product\'s ID";
            this.ProductID.Width = 83;
            // 
            // Product_Category
            // 
            this.Product_Category.HeaderText = "Category";
            this.Product_Category.Name = "Product_Category";
            this.Product_Category.ToolTipText = "What kind of product is it?";
            this.Product_Category.Width = 74;
            // 
            // Product_BrandName
            // 
            this.Product_BrandName.HeaderText = "Brand Name";
            this.Product_BrandName.Name = "Product_BrandName";
            this.Product_BrandName.Width = 91;
            // 
            // Product_GenericName
            // 
            this.Product_GenericName.HeaderText = "Generic Name";
            this.Product_GenericName.Name = "Product_GenericName";
            // 
            // Product_RegistrationNumber
            // 
            this.Product_RegistrationNumber.HeaderText = "FDA Reg. #";
            this.Product_RegistrationNumber.Name = "Product_RegistrationNumber";
            this.Product_RegistrationNumber.Width = 89;
            // 
            // Product_Lot
            // 
            this.Product_Lot.HeaderText = "Lot Number";
            this.Product_Lot.Name = "Product_Lot";
            this.Product_Lot.Width = 87;
            // 
            // Product_BasePrice
            // 
            this.Product_BasePrice.HeaderText = "Price";
            this.Product_BasePrice.Name = "Product_BasePrice";
            this.Product_BasePrice.Width = 56;
            // 
            // Product_Cost
            // 
            this.Product_Cost.HeaderText = "Cost";
            this.Product_Cost.Name = "Product_Cost";
            this.Product_Cost.Width = 53;
            // 
            // District
            // 
            this.District.HeaderText = "District";
            this.District.Items.AddRange(new object[] {
            "1",
            "2"});
            this.District.Name = "District";
            this.District.Width = 45;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(679, 474);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToResizeColumns = false;
            this.dgvMain.AllowUserToResizeRows = false;
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvMain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dgvMain.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvMain.GridColor = System.Drawing.Color.DimGray;
            this.dgvMain.Location = new System.Drawing.Point(2, 12);
            this.dgvMain.MultiSelect = false;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvMain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvMain.Size = new System.Drawing.Size(812, 456);
            this.dgvMain.TabIndex = 4;
            // 
            // ProductEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(836, 502);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gdvProducts);
            this.Name = "ProductEditor";
            this.Text = "ProductEditor";
            ((System.ComponentModel.ISupportInitialize)(this.gdvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gdvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_BrandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_GenericName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_RegistrationNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Lot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_BasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Cost;
        private System.Windows.Forms.DataGridViewComboBoxColumn District;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvMain;
    }
}