namespace Pleres.Forms
{
    partial class BatchEditor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Batch_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Batch_Expiry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Batch_MNFDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Batch_Status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Batch_Owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Batch_ActionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Batch_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Batch_Health = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Batch_ID,
            this.Product_ID,
            this.Batch_Expiry,
            this.Batch_MNFDate,
            this.Batch_Status,
            this.Batch_Owner,
            this.Batch_ActionDate,
            this.Batch_Quantity,
            this.Batch_Health});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.GridColor = System.Drawing.Color.DimGray;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(1046, 375);
            this.dataGridView1.TabIndex = 1;
            // 
            // Batch_ID
            // 
            this.Batch_ID.HeaderText = "Batch ID";
            this.Batch_ID.Name = "Batch_ID";
            this.Batch_ID.ReadOnly = true;
            this.Batch_ID.Width = 69;
            // 
            // Product_ID
            // 
            this.Product_ID.HeaderText = "Product ID";
            this.Product_ID.Name = "Product_ID";
            this.Product_ID.Width = 77;
            // 
            // Batch_Expiry
            // 
            this.Batch_Expiry.HeaderText = "Expiry Date";
            this.Batch_Expiry.Name = "Batch_Expiry";
            this.Batch_Expiry.Width = 79;
            // 
            // Batch_MNFDate
            // 
            this.Batch_MNFDate.HeaderText = "Manufacturing Date";
            this.Batch_MNFDate.Name = "Batch_MNFDate";
            this.Batch_MNFDate.Width = 115;
            // 
            // Batch_Status
            // 
            this.Batch_Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Batch_Status.HeaderText = "Status";
            this.Batch_Status.Items.AddRange(new object[] {
            "Ordered",
            "Acquired",
            "Stored",
            "Delivered",
            "Returned"});
            this.Batch_Status.Name = "Batch_Status";
            this.Batch_Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Batch_Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Batch_Status.Width = 62;
            // 
            // Batch_Owner
            // 
            this.Batch_Owner.HeaderText = "Owner";
            this.Batch_Owner.Name = "Batch_Owner";
            this.Batch_Owner.Width = 63;
            // 
            // Batch_ActionDate
            // 
            this.Batch_ActionDate.HeaderText = "Action Date";
            this.Batch_ActionDate.Name = "Batch_ActionDate";
            this.Batch_ActionDate.Width = 81;
            // 
            // Batch_Quantity
            // 
            this.Batch_Quantity.HeaderText = "Quantity";
            this.Batch_Quantity.Name = "Batch_Quantity";
            this.Batch_Quantity.Width = 71;
            // 
            // Batch_Health
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Batch_Health.DefaultCellStyle = dataGridViewCellStyle3;
            this.Batch_Health.HeaderText = "Health";
            this.Batch_Health.Items.AddRange(new object[] {
            "Excellent",
            "Good",
            "Damaged",
            "Unsellable"});
            this.Batch_Health.Name = "Batch_Health";
            this.Batch_Health.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Batch_Health.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Batch_Health.Width = 63;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(800, 393);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(258, 56);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // BatchEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1070, 461);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(1086, 500);
            this.Name = "BatchEditor";
            this.Text = "Batch Editor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Batch_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Batch_Expiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn Batch_MNFDate;
        private System.Windows.Forms.DataGridViewComboBoxColumn Batch_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Batch_Owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn Batch_ActionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Batch_Quantity;
        private System.Windows.Forms.DataGridViewComboBoxColumn Batch_Health;
    }
}