namespace Pleres.Forms
{
    partial class Clients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clients));
            this.tlpContent = new System.Windows.Forms.TableLayoutPanel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pnlDataDisplay = new System.Windows.Forms.Panel();
            this.gbxTop = new System.Windows.Forms.GroupBox();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblBusinessName = new System.Windows.Forms.Label();
            this.txtClientType = new System.Windows.Forms.Label();
            this.lblContact1 = new System.Windows.Forms.Label();
            this.lblContact2 = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtBirthday = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnSaveNote = new System.Windows.Forms.Button();
            this.gbxMid = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnPicture = new System.Windows.Forms.Button();
            this.cmb = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIDNo = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.gbxBtm = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnMinimizeGroup3 = new System.Windows.Forms.Button();
            this.btnMinimizeGroup2 = new System.Windows.Forms.Button();
            this.btnMinimizeGroup1 = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.lblInventory = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ttpHelper = new System.Windows.Forms.ToolTip(this.components);
            this.tlpContent.SuspendLayout();
            this.panel10.SuspendLayout();
            this.pnlDataDisplay.SuspendLayout();
            this.gbxTop.SuspendLayout();
            this.gbxMid.SuspendLayout();
            this.gbxBtm.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpContent
            // 
            this.tlpContent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tlpContent.AutoSize = true;
            this.tlpContent.ColumnCount = 2;
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.92593F));
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.07407F));
            this.tlpContent.Controls.Add(this.pnlDataDisplay, 1, 0);
            this.tlpContent.Controls.Add(this.panel10, 0, 0);
            this.tlpContent.Location = new System.Drawing.Point(12, 100);
            this.tlpContent.Name = "tlpContent";
            this.tlpContent.RowCount = 1;
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.51576F));
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.48424F));
            this.tlpContent.Size = new System.Drawing.Size(1350, 867);
            this.tlpContent.TabIndex = 22;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.gbxBtm);
            this.panel10.Controls.Add(this.gbxMid);
            this.panel10.Controls.Add(this.gbxTop);
            this.panel10.Location = new System.Drawing.Point(3, 3);
            this.panel10.MinimumSize = new System.Drawing.Size(668, 692);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(668, 692);
            this.panel10.TabIndex = 33;
            // 
            // pnlDataDisplay
            // 
            this.pnlDataDisplay.AutoSize = true;
            this.pnlDataDisplay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlDataDisplay.Controls.Add(this.dataGridView1);
            this.pnlDataDisplay.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDataDisplay.Location = new System.Drawing.Point(677, 3);
            this.pnlDataDisplay.MinimumSize = new System.Drawing.Size(670, 692);
            this.pnlDataDisplay.Name = "pnlDataDisplay";
            this.tlpContent.SetRowSpan(this.pnlDataDisplay, 2);
            this.pnlDataDisplay.Size = new System.Drawing.Size(670, 692);
            this.pnlDataDisplay.TabIndex = 34;
            // 
            // gbxTop
            // 
            this.gbxTop.BackColor = System.Drawing.Color.Transparent;
            this.gbxTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gbxTop.Controls.Add(this.txtNotes);
            this.gbxTop.Controls.Add(this.lblContact2);
            this.gbxTop.Controls.Add(this.lblEmail);
            this.gbxTop.Controls.Add(this.btnSaveNote);
            this.gbxTop.Controls.Add(this.lblContact1);
            this.gbxTop.Controls.Add(this.lblAddress);
            this.gbxTop.Controls.Add(this.txtBirthday);
            this.gbxTop.Controls.Add(this.lblGender);
            this.gbxTop.Controls.Add(this.txtClientType);
            this.gbxTop.Controls.Add(this.lblBusinessName);
            this.gbxTop.Controls.Add(this.lblId);
            this.gbxTop.Controls.Add(this.lblClientName);
            this.gbxTop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbxTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxTop.Font = new System.Drawing.Font("Saira Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTop.ForeColor = System.Drawing.Color.White;
            this.gbxTop.Location = new System.Drawing.Point(0, 0);
            this.gbxTop.MinimumSize = new System.Drawing.Size(662, 280);
            this.gbxTop.Name = "gbxTop";
            this.gbxTop.Size = new System.Drawing.Size(668, 280);
            this.gbxTop.TabIndex = 11;
            this.gbxTop.TabStop = false;
            this.gbxTop.Text = "Client/Customer Data";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.BackColor = System.Drawing.Color.Transparent;
            this.lblClientName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblClientName.Font = new System.Drawing.Font("Saira Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.ForeColor = System.Drawing.Color.White;
            this.lblClientName.Location = new System.Drawing.Point(6, 33);
            this.lblClientName.MinimumSize = new System.Drawing.Size(24, 32);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(181, 46);
            this.lblClientName.TabIndex = 23;
            this.lblClientName.Text = "Client Name";
            // 
            // lblBusinessName
            // 
            this.lblBusinessName.AutoSize = true;
            this.lblBusinessName.BackColor = System.Drawing.Color.Transparent;
            this.lblBusinessName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBusinessName.Font = new System.Drawing.Font("Saira", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusinessName.ForeColor = System.Drawing.Color.White;
            this.lblBusinessName.Location = new System.Drawing.Point(9, 79);
            this.lblBusinessName.MinimumSize = new System.Drawing.Size(24, 32);
            this.lblBusinessName.Name = "lblBusinessName";
            this.lblBusinessName.Size = new System.Drawing.Size(148, 32);
            this.lblBusinessName.TabIndex = 24;
            this.lblBusinessName.Text = "Business Name";
            // 
            // txtClientType
            // 
            this.txtClientType.AutoSize = true;
            this.txtClientType.BackColor = System.Drawing.Color.Transparent;
            this.txtClientType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtClientType.Font = new System.Drawing.Font("Saira", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientType.ForeColor = System.Drawing.Color.White;
            this.txtClientType.Location = new System.Drawing.Point(9, 111);
            this.txtClientType.MinimumSize = new System.Drawing.Size(24, 32);
            this.txtClientType.Name = "txtClientType";
            this.txtClientType.Size = new System.Drawing.Size(111, 32);
            this.txtClientType.TabIndex = 24;
            this.txtClientType.Text = "Client Type";
            // 
            // lblContact1
            // 
            this.lblContact1.AutoSize = true;
            this.lblContact1.BackColor = System.Drawing.Color.Transparent;
            this.lblContact1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContact1.Font = new System.Drawing.Font("Saira", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact1.ForeColor = System.Drawing.Color.White;
            this.lblContact1.Location = new System.Drawing.Point(348, 80);
            this.lblContact1.MinimumSize = new System.Drawing.Size(24, 32);
            this.lblContact1.Name = "lblContact1";
            this.lblContact1.Size = new System.Drawing.Size(91, 32);
            this.lblContact1.TabIndex = 24;
            this.lblContact1.Text = "Contact 1";
            // 
            // lblContact2
            // 
            this.lblContact2.AutoSize = true;
            this.lblContact2.BackColor = System.Drawing.Color.Transparent;
            this.lblContact2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContact2.Font = new System.Drawing.Font("Saira", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact2.ForeColor = System.Drawing.Color.White;
            this.lblContact2.Location = new System.Drawing.Point(349, 112);
            this.lblContact2.MinimumSize = new System.Drawing.Size(24, 32);
            this.lblContact2.Name = "lblContact2";
            this.lblContact2.Size = new System.Drawing.Size(96, 32);
            this.lblContact2.TabIndex = 24;
            this.lblContact2.Text = "Contact 2";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAddress.Font = new System.Drawing.Font("Saira Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(11, 175);
            this.lblAddress.MinimumSize = new System.Drawing.Size(24, 32);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(548, 32);
            this.lblAddress.TabIndex = 24;
            this.lblAddress.Text = "Complete address, complete address complete address, complete address";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGender.Font = new System.Drawing.Font("Saira", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.White;
            this.lblGender.Location = new System.Drawing.Point(189, 142);
            this.lblGender.MinimumSize = new System.Drawing.Size(24, 32);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(77, 32);
            this.lblGender.TabIndex = 24;
            this.lblGender.Text = "Gender";
            // 
            // txtBirthday
            // 
            this.txtBirthday.AutoSize = true;
            this.txtBirthday.BackColor = System.Drawing.Color.Transparent;
            this.txtBirthday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtBirthday.Font = new System.Drawing.Font("Saira", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBirthday.ForeColor = System.Drawing.Color.White;
            this.txtBirthday.Location = new System.Drawing.Point(11, 143);
            this.txtBirthday.MinimumSize = new System.Drawing.Size(24, 32);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(89, 32);
            this.txtBirthday.TabIndex = 24;
            this.txtBirthday.Text = "Birthday";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmail.Font = new System.Drawing.Font("Saira", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(349, 144);
            this.lblEmail.MinimumSize = new System.Drawing.Size(24, 32);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(245, 32);
            this.lblEmail.TabIndex = 24;
            this.lblEmail.Text = "Email Address@email.com";
            // 
            // txtNotes
            // 
            this.txtNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNotes.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.ForeColor = System.Drawing.Color.White;
            this.txtNotes.Location = new System.Drawing.Point(14, 210);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(545, 58);
            this.txtNotes.TabIndex = 17;
            this.txtNotes.Text = "Click To Add Notes...";
            // 
            // btnSaveNote
            // 
            this.btnSaveNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveNote.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveNote.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSaveNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveNote.Font = new System.Drawing.Font("Saira Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNote.ForeColor = System.Drawing.Color.White;
            this.btnSaveNote.Location = new System.Drawing.Point(571, 207);
            this.btnSaveNote.Name = "btnSaveNote";
            this.btnSaveNote.Size = new System.Drawing.Size(91, 61);
            this.btnSaveNote.TabIndex = 18;
            this.btnSaveNote.Text = "Save Note";
            this.btnSaveNote.UseVisualStyleBackColor = false;
            // 
            // gbxMid
            // 
            this.gbxMid.BackColor = System.Drawing.Color.Transparent;
            this.gbxMid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gbxMid.Controls.Add(this.maskedTextBox1);
            this.gbxMid.Controls.Add(this.mtbPhone);
            this.gbxMid.Controls.Add(this.dtp);
            this.gbxMid.Controls.Add(this.comboBox1);
            this.gbxMid.Controls.Add(this.btnPicture);
            this.gbxMid.Controls.Add(this.cmb);
            this.gbxMid.Controls.Add(this.label11);
            this.gbxMid.Controls.Add(this.label9);
            this.gbxMid.Controls.Add(this.textBox4);
            this.gbxMid.Controls.Add(this.textBox2);
            this.gbxMid.Controls.Add(this.textBox5);
            this.gbxMid.Controls.Add(this.textBox1);
            this.gbxMid.Controls.Add(this.textBox3);
            this.gbxMid.Controls.Add(this.txtUsername);
            this.gbxMid.Controls.Add(this.label4);
            this.gbxMid.Controls.Add(this.label3);
            this.gbxMid.Controls.Add(this.label12);
            this.gbxMid.Controls.Add(this.label2);
            this.gbxMid.Controls.Add(this.label10);
            this.gbxMid.Controls.Add(this.label8);
            this.gbxMid.Controls.Add(this.label7);
            this.gbxMid.Controls.Add(this.label6);
            this.gbxMid.Controls.Add(this.label5);
            this.gbxMid.Controls.Add(this.label1);
            this.gbxMid.Controls.Add(this.lblIDNo);
            this.gbxMid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbxMid.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxMid.Font = new System.Drawing.Font("Saira Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxMid.ForeColor = System.Drawing.Color.White;
            this.gbxMid.Location = new System.Drawing.Point(0, 280);
            this.gbxMid.MinimumSize = new System.Drawing.Size(662, 250);
            this.gbxMid.Name = "gbxMid";
            this.gbxMid.Size = new System.Drawing.Size(668, 251);
            this.gbxMid.TabIndex = 37;
            this.gbxMid.TabStop = false;
            this.gbxMid.Text = "Edit Client";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.Gray;
            this.maskedTextBox1.BeepOnError = true;
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBox1.Font = new System.Drawing.Font("Saira Light", 12F);
            this.maskedTextBox1.ForeColor = System.Drawing.Color.White;
            this.maskedTextBox1.Location = new System.Drawing.Point(128, 205);
            this.maskedTextBox1.Mask = "99999999999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(103, 33);
            this.maskedTextBox1.TabIndex = 12;
            // 
            // mtbPhone
            // 
            this.mtbPhone.BackColor = System.Drawing.Color.Gray;
            this.mtbPhone.BeepOnError = true;
            this.mtbPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbPhone.Font = new System.Drawing.Font("Saira Light", 12F);
            this.mtbPhone.ForeColor = System.Drawing.Color.White;
            this.mtbPhone.Location = new System.Drawing.Point(16, 205);
            this.mtbPhone.Mask = "99999999999";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.Size = new System.Drawing.Size(101, 33);
            this.mtbPhone.TabIndex = 11;
            // 
            // dtp
            // 
            this.dtp.CalendarForeColor = System.Drawing.Color.White;
            this.dtp.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtp.CalendarTitleBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtp.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtp.Font = new System.Drawing.Font("Saira Light", 12F);
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp.Location = new System.Drawing.Point(372, 134);
            this.dtp.MaxDate = new System.DateTime(2003, 12, 31, 0, 0, 0, 0);
            this.dtp.MinDate = new System.DateTime(1880, 1, 1, 0, 0, 0, 0);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(125, 33);
            this.dtp.TabIndex = 9;
            this.dtp.Value = new System.DateTime(1970, 12, 31, 0, 0, 0, 0);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Saira Light", 12F);
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "F",
            "M"});
            this.comboBox1.Location = new System.Drawing.Point(323, 134);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(43, 33);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "F";
            // 
            // btnPicture
            // 
            this.btnPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPicture.BackColor = System.Drawing.Color.Transparent;
            this.btnPicture.Enabled = false;
            this.btnPicture.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPicture.Font = new System.Drawing.Font("Saira Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPicture.ForeColor = System.Drawing.Color.White;
            this.btnPicture.Location = new System.Drawing.Point(503, 173);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(153, 29);
            this.btnPicture.TabIndex = 16;
            this.btnPicture.Text = "Upload Picture";
            this.btnPicture.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPicture.UseVisualStyleBackColor = false;
            // 
            // cmb
            // 
            this.cmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb.Font = new System.Drawing.Font("Saira Light", 12F);
            this.cmb.ForeColor = System.Drawing.Color.White;
            this.cmb.FormattingEnabled = true;
            this.cmb.Items.AddRange(new object[] {
            "Contract",
            "Distributor",
            "Regular"});
            this.cmb.Location = new System.Drawing.Point(194, 134);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(123, 33);
            this.cmb.Sorted = true;
            this.cmb.TabIndex = 8;
            this.cmb.Text = "Select";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Saira", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(123, 170);
            this.label11.MinimumSize = new System.Drawing.Size(24, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 32);
            this.label11.TabIndex = 24;
            this.label11.Text = "Landln./Alt.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Saira", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(11, 170);
            this.label9.MinimumSize = new System.Drawing.Size(24, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 32);
            this.label9.TabIndex = 24;
            this.label9.Text = "Mobile No.";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("Saira Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(503, 134);
            this.textBox4.MaxLength = 30;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(153, 33);
            this.textBox4.TabIndex = 10;
            this.textBox4.Text = "Text";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Saira Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(372, 63);
            this.textBox2.MaxLength = 30;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 33);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Text";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Font = new System.Drawing.Font("Saira Light", 9F);
            this.textBox5.ForeColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(245, 205);
            this.textBox5.MaxLength = 30;
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(411, 33);
            this.textBox5.TabIndex = 13;
            this.textBox5.Text = "Text";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Saira Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(193, 63);
            this.textBox1.MaxLength = 30;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 33);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Text";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Saira Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(14, 134);
            this.textBox3.MaxLength = 30;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(173, 33);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "Text";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Saira Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(14, 63);
            this.txtUsername.MaxLength = 30;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(173, 33);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.Text = "Text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Saira", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(548, 28);
            this.label4.MinimumSize = new System.Drawing.Size(24, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 32);
            this.label4.TabIndex = 24;
            this.label4.Text = "ID No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Saira", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(367, 28);
            this.label3.MinimumSize = new System.Drawing.Size(24, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 32);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nick Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Saira", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(240, 170);
            this.label12.MinimumSize = new System.Drawing.Size(24, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 32);
            this.label12.TabIndex = 24;
            this.label12.Text = "Full Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Saira", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(189, 28);
            this.label2.MinimumSize = new System.Drawing.Size(24, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 32);
            this.label2.TabIndex = 24;
            this.label2.Text = "Last Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Saira", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(503, 99);
            this.label10.MinimumSize = new System.Drawing.Size(24, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 32);
            this.label10.TabIndex = 24;
            this.label10.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Saira", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(370, 99);
            this.label8.MinimumSize = new System.Drawing.Size(24, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 32);
            this.label8.TabIndex = 24;
            this.label8.Text = "Birthday";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Saira", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(318, 99);
            this.label7.MinimumSize = new System.Drawing.Size(24, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 32);
            this.label7.TabIndex = 24;
            this.label7.Text = "Sex";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Saira", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(189, 99);
            this.label6.MinimumSize = new System.Drawing.Size(24, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 32);
            this.label6.TabIndex = 24;
            this.label6.Text = "Client Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Saira", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 99);
            this.label5.MinimumSize = new System.Drawing.Size(24, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 32);
            this.label5.TabIndex = 24;
            this.label5.Text = "Business Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Saira", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 28);
            this.label1.MinimumSize = new System.Drawing.Size(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 32);
            this.label1.TabIndex = 24;
            this.label1.Text = "First Name";
            // 
            // lblIDNo
            // 
            this.lblIDNo.AutoSize = true;
            this.lblIDNo.BackColor = System.Drawing.Color.Transparent;
            this.lblIDNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIDNo.Font = new System.Drawing.Font("Saira Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDNo.ForeColor = System.Drawing.Color.White;
            this.lblIDNo.Location = new System.Drawing.Point(546, 60);
            this.lblIDNo.MinimumSize = new System.Drawing.Size(24, 32);
            this.lblIDNo.Name = "lblIDNo";
            this.lblIDNo.Size = new System.Drawing.Size(116, 38);
            this.lblIDNo.TabIndex = 23;
            this.lblIDNo.Text = "#00000";
            this.lblIDNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblId.Font = new System.Drawing.Font("Saira Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Image = global::Pleres.Properties.Resources.userlite;
            this.lblId.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblId.Location = new System.Drawing.Point(513, 27);
            this.lblId.MinimumSize = new System.Drawing.Size(120, 120);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(143, 120);
            this.lblId.TabIndex = 23;
            this.lblId.Text = "#00000";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // gbxBtm
            // 
            this.gbxBtm.BackColor = System.Drawing.Color.Transparent;
            this.gbxBtm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gbxBtm.Controls.Add(this.btnDelete);
            this.gbxBtm.Controls.Add(this.btnExport);
            this.gbxBtm.Controls.Add(this.btnEdit);
            this.gbxBtm.Controls.Add(this.btnSave);
            this.gbxBtm.Controls.Add(this.btnImport);
            this.gbxBtm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbxBtm.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxBtm.Font = new System.Drawing.Font("Saira Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxBtm.ForeColor = System.Drawing.Color.White;
            this.gbxBtm.Location = new System.Drawing.Point(0, 531);
            this.gbxBtm.MinimumSize = new System.Drawing.Size(662, 124);
            this.gbxBtm.Name = "gbxBtm";
            this.gbxBtm.Size = new System.Drawing.Size(668, 124);
            this.gbxBtm.TabIndex = 39;
            this.gbxBtm.TabStop = false;
            this.gbxBtm.Text = "Record Controls";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Saira Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(12, 79);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(208, 37);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.BackColor = System.Drawing.Color.Transparent;
            this.btnExport.Enabled = false;
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Saira Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(226, 79);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(219, 37);
            this.btnExport.TabIndex = 17;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Saira Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(12, 36);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(208, 37);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Saira Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(451, 36);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(211, 80);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.BackColor = System.Drawing.Color.Transparent;
            this.btnImport.Enabled = false;
            this.btnImport.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Saira Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.Location = new System.Drawing.Point(226, 36);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(219, 37);
            this.btnImport.TabIndex = 16;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnMinimizeGroup3);
            this.panel1.Controls.Add(this.btnMinimizeGroup2);
            this.panel1.Controls.Add(this.btnMinimizeGroup1);
            this.panel1.Controls.Add(this.btnAddUser);
            this.panel1.Controls.Add(this.lblInventory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1367, 100);
            this.panel1.TabIndex = 23;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Saira Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1142, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(217, 37);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "Search Clients";
            this.ttpHelper.SetToolTip(this.btnSearch, "Press to Search");
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Saira Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(689, 34);
            this.txtSearch.MaxLength = 30;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(447, 37);
            this.txtSearch.TabIndex = 22;
            this.txtSearch.Text = "Search...";
            this.ttpHelper.SetToolTip(this.txtSearch, "Search for Client/Customer");
            // 
            // btnMinimizeGroup3
            // 
            this.btnMinimizeGroup3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMinimizeGroup3.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizeGroup3.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnMinimizeGroup3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizeGroup3.Font = new System.Drawing.Font("Saira Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizeGroup3.ForeColor = System.Drawing.Color.White;
            this.btnMinimizeGroup3.Image = global::Pleres.Properties.Resources.diacenterdark;
            this.btnMinimizeGroup3.Location = new System.Drawing.Point(627, 34);
            this.btnMinimizeGroup3.Name = "btnMinimizeGroup3";
            this.btnMinimizeGroup3.Size = new System.Drawing.Size(32, 33);
            this.btnMinimizeGroup3.TabIndex = 24;
            this.ttpHelper.SetToolTip(this.btnMinimizeGroup3, "Hide/Show  Record Controls");
            this.btnMinimizeGroup3.UseVisualStyleBackColor = false;
            this.btnMinimizeGroup3.Click += new System.EventHandler(this.btnMinimizeGroup3_Click);
            // 
            // btnMinimizeGroup2
            // 
            this.btnMinimizeGroup2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMinimizeGroup2.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizeGroup2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnMinimizeGroup2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizeGroup2.Font = new System.Drawing.Font("Saira Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizeGroup2.ForeColor = System.Drawing.Color.White;
            this.btnMinimizeGroup2.Image = global::Pleres.Properties.Resources.diacenterdark;
            this.btnMinimizeGroup2.Location = new System.Drawing.Point(589, 34);
            this.btnMinimizeGroup2.Name = "btnMinimizeGroup2";
            this.btnMinimizeGroup2.Size = new System.Drawing.Size(32, 33);
            this.btnMinimizeGroup2.TabIndex = 25;
            this.ttpHelper.SetToolTip(this.btnMinimizeGroup2, "Hide/Show  Client Editing Region");
            this.btnMinimizeGroup2.UseVisualStyleBackColor = false;
            this.btnMinimizeGroup2.Click += new System.EventHandler(this.btnMinimizeGroup2_Click);
            // 
            // btnMinimizeGroup1
            // 
            this.btnMinimizeGroup1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMinimizeGroup1.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizeGroup1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnMinimizeGroup1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizeGroup1.Font = new System.Drawing.Font("Saira Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizeGroup1.ForeColor = System.Drawing.Color.White;
            this.btnMinimizeGroup1.Image = global::Pleres.Properties.Resources.diacenterdark;
            this.btnMinimizeGroup1.Location = new System.Drawing.Point(551, 34);
            this.btnMinimizeGroup1.Name = "btnMinimizeGroup1";
            this.btnMinimizeGroup1.Size = new System.Drawing.Size(32, 33);
            this.btnMinimizeGroup1.TabIndex = 26;
            this.ttpHelper.SetToolTip(this.btnMinimizeGroup1, "Hide/Show Client Data");
            this.btnMinimizeGroup1.UseVisualStyleBackColor = false;
            this.btnMinimizeGroup1.Click += new System.EventHandler(this.btnMinimizeGroup1_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddUser.BackColor = System.Drawing.Color.Transparent;
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUser.Image")));
            this.btnAddUser.Location = new System.Drawing.Point(323, 22);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddUser.Size = new System.Drawing.Size(57, 48);
            this.btnAddUser.TabIndex = 21;
            this.ttpHelper.SetToolTip(this.btnAddUser, "Add a New Client");
            this.btnAddUser.UseVisualStyleBackColor = false;
            // 
            // lblInventory
            // 
            this.lblInventory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInventory.AutoSize = true;
            this.lblInventory.BackColor = System.Drawing.Color.Transparent;
            this.lblInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInventory.Font = new System.Drawing.Font("Saira Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventory.ForeColor = System.Drawing.Color.White;
            this.lblInventory.Location = new System.Drawing.Point(20, 18);
            this.lblInventory.MinimumSize = new System.Drawing.Size(200, 64);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(314, 64);
            this.lblInventory.TabIndex = 27;
            this.lblInventory.Text = "Clients/Customers";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(670, 692);
            this.dataGridView1.TabIndex = 41;
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1384, 775);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tlpContent);
            this.MinimumSize = new System.Drawing.Size(1400, 800);
            this.Name = "Clients";
            this.Text = "Clients";
            this.tlpContent.ResumeLayout(false);
            this.tlpContent.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.pnlDataDisplay.ResumeLayout(false);
            this.gbxTop.ResumeLayout(false);
            this.gbxTop.PerformLayout();
            this.gbxMid.ResumeLayout(false);
            this.gbxMid.PerformLayout();
            this.gbxBtm.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpContent;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel pnlDataDisplay;
        private System.Windows.Forms.GroupBox gbxTop;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblContact2;
        private System.Windows.Forms.Label lblContact1;
        private System.Windows.Forms.Label txtClientType;
        private System.Windows.Forms.Label lblBusinessName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label txtBirthday;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnSaveNote;
        private System.Windows.Forms.GroupBox gbxMid;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnPicture;
        private System.Windows.Forms.ComboBox cmb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIDNo;
        private System.Windows.Forms.GroupBox gbxBtm;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnMinimizeGroup3;
        private System.Windows.Forms.Button btnMinimizeGroup2;
        private System.Windows.Forms.Button btnMinimizeGroup1;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolTip ttpHelper;
    }
}