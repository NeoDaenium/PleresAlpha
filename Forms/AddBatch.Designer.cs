namespace Pleres.Forms
{
    partial class AddBatch
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtBatchId = new System.Windows.Forms.MaskedTextBox();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.txtProductId = new System.Windows.Forms.MaskedTextBox();
            this.dtpExpiry = new System.Windows.Forms.DateTimePicker();
            this.dtpManufacturing = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbHealth = new System.Windows.Forms.ComboBox();
            this.dtpActionDate = new System.Windows.Forms.DateTimePicker();
            this.txtQuantity = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAddbatch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Add New Batch";
            // 
            // txtBatchId
            // 
            this.txtBatchId.Location = new System.Drawing.Point(25, 88);
            this.txtBatchId.Mask = "999999";
            this.txtBatchId.Name = "txtBatchId";
            this.txtBatchId.Size = new System.Drawing.Size(47, 20);
            this.txtBatchId.TabIndex = 7;
            // 
            // txtOwner
            // 
            this.txtOwner.Location = new System.Drawing.Point(326, 181);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Size = new System.Drawing.Size(121, 20);
            this.txtOwner.TabIndex = 8;
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(25, 134);
            this.txtProductId.Mask = "999999";
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(47, 20);
            this.txtProductId.TabIndex = 7;
            // 
            // dtpExpiry
            // 
            this.dtpExpiry.Location = new System.Drawing.Point(118, 88);
            this.dtpExpiry.Name = "dtpExpiry";
            this.dtpExpiry.Size = new System.Drawing.Size(190, 20);
            this.dtpExpiry.TabIndex = 9;
            // 
            // dtpManufacturing
            // 
            this.dtpManufacturing.Location = new System.Drawing.Point(118, 134);
            this.dtpManufacturing.Name = "dtpManufacturing";
            this.dtpManufacturing.Size = new System.Drawing.Size(190, 20);
            this.dtpManufacturing.TabIndex = 9;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Ordered",
            "Acquired",
            "Storage",
            "Delivered",
            "Refunded"});
            this.cmbStatus.Location = new System.Drawing.Point(326, 88);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 10;
            // 
            // cmbHealth
            // 
            this.cmbHealth.FormattingEnabled = true;
            this.cmbHealth.Items.AddRange(new object[] {
            "Excellent",
            "Good",
            "Damage",
            "Unsellable"});
            this.cmbHealth.Location = new System.Drawing.Point(326, 133);
            this.cmbHealth.Name = "cmbHealth";
            this.cmbHealth.Size = new System.Drawing.Size(121, 21);
            this.cmbHealth.TabIndex = 10;
            // 
            // dtpActionDate
            // 
            this.dtpActionDate.Location = new System.Drawing.Point(118, 181);
            this.dtpActionDate.Name = "dtpActionDate";
            this.dtpActionDate.Size = new System.Drawing.Size(190, 20);
            this.dtpActionDate.TabIndex = 9;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(25, 184);
            this.txtQuantity.Mask = "999999";
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(47, 20);
            this.txtQuantity.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Action Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Manufacturing Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Expiry";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Batch ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Product ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(323, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Status";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(323, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Health";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(323, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Owner";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Quantity";
            // 
            // btnAddbatch
            // 
            this.btnAddbatch.Location = new System.Drawing.Point(25, 218);
            this.btnAddbatch.Name = "btnAddbatch";
            this.btnAddbatch.Size = new System.Drawing.Size(422, 26);
            this.btnAddbatch.TabIndex = 11;
            this.btnAddbatch.Text = "Add New Batch";
            this.btnAddbatch.UseVisualStyleBackColor = true;
            this.btnAddbatch.Click += new System.EventHandler(this.BtnAddbatch_Click);
            // 
            // AddBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(466, 263);
            this.Controls.Add(this.btnAddbatch);
            this.Controls.Add(this.cmbHealth);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.dtpActionDate);
            this.Controls.Add(this.dtpManufacturing);
            this.Controls.Add(this.dtpExpiry);
            this.Controls.Add(this.txtOwner);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtBatchId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Name = "AddBatch";
            this.Text = "AddBatch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtBatchId;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.MaskedTextBox txtProductId;
        private System.Windows.Forms.DateTimePicker dtpExpiry;
        private System.Windows.Forms.DateTimePicker dtpManufacturing;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbHealth;
        private System.Windows.Forms.DateTimePicker dtpActionDate;
        private System.Windows.Forms.MaskedTextBox txtQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAddbatch;
    }
}