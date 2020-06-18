namespace Pleres.Forms
{
    partial class AddProduct
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
            this.txtBrandName = new System.Windows.Forms.TextBox();
            this.cmbProductCategory = new System.Windows.Forms.ComboBox();
            this.txtGenericName = new System.Windows.Forms.TextBox();
            this.txtFDARegistrationNumber = new System.Windows.Forms.TextBox();
            this.txtLotNumber = new System.Windows.Forms.TextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.MaskedTextBox();
            this.txtPrice = new System.Windows.Forms.MaskedTextBox();
            this.cmbDistrict = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBrandName
            // 
            this.txtBrandName.Location = new System.Drawing.Point(17, 127);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.Size = new System.Drawing.Size(121, 20);
            this.txtBrandName.TabIndex = 0;
            // 
            // cmbProductCategory
            // 
            this.cmbProductCategory.FormattingEnabled = true;
            this.cmbProductCategory.Items.AddRange(new object[] {
            "Food",
            "Drug",
            "Cosmetic"});
            this.cmbProductCategory.Location = new System.Drawing.Point(17, 86);
            this.cmbProductCategory.Name = "cmbProductCategory";
            this.cmbProductCategory.Size = new System.Drawing.Size(121, 21);
            this.cmbProductCategory.TabIndex = 1;
            // 
            // txtGenericName
            // 
            this.txtGenericName.Location = new System.Drawing.Point(17, 166);
            this.txtGenericName.Name = "txtGenericName";
            this.txtGenericName.Size = new System.Drawing.Size(121, 20);
            this.txtGenericName.TabIndex = 2;
            // 
            // txtFDARegistrationNumber
            // 
            this.txtFDARegistrationNumber.Location = new System.Drawing.Point(155, 86);
            this.txtFDARegistrationNumber.Name = "txtFDARegistrationNumber";
            this.txtFDARegistrationNumber.Size = new System.Drawing.Size(167, 20);
            this.txtFDARegistrationNumber.TabIndex = 3;
            // 
            // txtLotNumber
            // 
            this.txtLotNumber.Location = new System.Drawing.Point(155, 127);
            this.txtLotNumber.Name = "txtLotNumber";
            this.txtLotNumber.Size = new System.Drawing.Size(167, 20);
            this.txtLotNumber.TabIndex = 3;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(17, 242);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(305, 39);
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.Text = "Add New Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Brand Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Generic Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "FDA Registration Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Lot Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bebas Neue Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(113, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Add New Product";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(155, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Cost";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Price";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(155, 167);
            this.txtCost.Mask = "9999999.99";
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(167, 20);
            this.txtCost.TabIndex = 6;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(16, 208);
            this.txtPrice.Mask = "9999999.99";
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(122, 20);
            this.txtPrice.TabIndex = 7;
            // 
            // cmbDistrict
            // 
            this.cmbDistrict.FormattingEnabled = true;
            this.cmbDistrict.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbDistrict.Location = new System.Drawing.Point(155, 208);
            this.cmbDistrict.Name = "cmbDistrict";
            this.cmbDistrict.Size = new System.Drawing.Size(167, 21);
            this.cmbDistrict.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(155, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "District";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(348, 293);
            this.Controls.Add(this.cmbDistrict);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.txtLotNumber);
            this.Controls.Add(this.txtFDARegistrationNumber);
            this.Controls.Add(this.txtGenericName);
            this.Controls.Add(this.cmbProductCategory);
            this.Controls.Add(this.txtBrandName);
            this.Name = "AddProduct";
            this.Opacity = 0.9D;
            this.Text = "AddProduct";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBrandName;
        private System.Windows.Forms.ComboBox cmbProductCategory;
        private System.Windows.Forms.TextBox txtGenericName;
        private System.Windows.Forms.TextBox txtFDARegistrationNumber;
        private System.Windows.Forms.TextBox txtLotNumber;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtCost;
        private System.Windows.Forms.MaskedTextBox txtPrice;
        private System.Windows.Forms.ComboBox cmbDistrict;
        private System.Windows.Forms.Label label9;
    }
}