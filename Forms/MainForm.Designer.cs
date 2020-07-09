namespace Pleres
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddBatch = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.showProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrCurrent = new System.Windows.Forms.Timer(this.components);
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.indName = new System.Windows.Forms.Label();
            this.pnlNotifications = new System.Windows.Forms.Panel();
            this.indMessageCounter = new System.Windows.Forms.Label();
            this.indPackCount = new System.Windows.Forms.Label();
            this.btnMessages = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.pnlClock = new System.Windows.Forms.Panel();
            this.indTime = new System.Windows.Forms.Label();
            this.indDate = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.tblLayoutTop = new System.Windows.Forms.TableLayoutPanel();
            this.tblLayoutCenter = new System.Windows.Forms.TableLayoutPanel();
            this.pnlInventory = new System.Windows.Forms.Panel();
            this.pnExpander = new System.Windows.Forms.Panel();
            this.gbxInventory = new System.Windows.Forms.GroupBox();
            this.pnlContacts = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnHideAll = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.lbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlTerminal = new System.Windows.Forms.Panel();
            this.gbx3 = new System.Windows.Forms.GroupBox();
            this.txtTerminal = new System.Windows.Forms.TextBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.lblInventory = new System.Windows.Forms.Label();
            this.pnlOperations = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.lbxBatches = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlDocuments = new System.Windows.Forms.Panel();
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.btnConsole = new System.Windows.Forms.Button();
            this.pnlReports = new System.Windows.Forms.Panel();
            this.gbxRadio = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.tmiDashboard = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.pnlUser.SuspendLayout();
            this.pnlNotifications.SuspendLayout();
            this.pnlClock.SuspendLayout();
            this.tblLayoutTop.SuspendLayout();
            this.tblLayoutCenter.SuspendLayout();
            this.pnlInventory.SuspendLayout();
            this.pnExpander.SuspendLayout();
            this.pnlContacts.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel16.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.pnlTerminal.SuspendLayout();
            this.gbx3.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlOperations.SuspendLayout();
            this.pnlSideBar.SuspendLayout();
            this.pnlReports.SuspendLayout();
            this.gbxRadio.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.mnuMain.Font = new System.Drawing.Font("Saira Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.showProductsToolStripMenuItem,
            this.clientsCustomersToolStripMenuItem,
            this.suppliersToolStripMenuItem,
            this.companyManagementToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.mnuMain.Size = new System.Drawing.Size(1589, 40);
            this.mnuMain.TabIndex = 4;
            this.mnuMain.Text = "menuBar";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.DarkRed;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiDashboard,
            this.tmiLogout});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(75, 34);
            this.fileToolStripMenuItem.Text = "Menu";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.BackColor = System.Drawing.Color.Green;
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddProduct,
            this.mnuAddBatch,
            this.mnuEditProducts});
            this.productsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(102, 34);
            this.productsToolStripMenuItem.Text = "Products";
            // 
            // mnuAddProduct
            // 
            this.mnuAddProduct.BackColor = System.Drawing.Color.Green;
            this.mnuAddProduct.ForeColor = System.Drawing.Color.White;
            this.mnuAddProduct.Name = "mnuAddProduct";
            this.mnuAddProduct.Size = new System.Drawing.Size(237, 34);
            this.mnuAddProduct.Text = "Add New Product";
            this.mnuAddProduct.Click += new System.EventHandler(this.MnuAddProduct_Click);
            // 
            // mnuAddBatch
            // 
            this.mnuAddBatch.ForeColor = System.Drawing.Color.White;
            this.mnuAddBatch.Name = "mnuAddBatch";
            this.mnuAddBatch.Size = new System.Drawing.Size(237, 34);
            this.mnuAddBatch.Text = "Add New Batch";
            this.mnuAddBatch.Click += new System.EventHandler(this.MnuAddBatch_Click);
            // 
            // mnuEditProducts
            // 
            this.mnuEditProducts.BackColor = System.Drawing.Color.Green;
            this.mnuEditProducts.ForeColor = System.Drawing.Color.White;
            this.mnuEditProducts.Name = "mnuEditProducts";
            this.mnuEditProducts.Size = new System.Drawing.Size(237, 34);
            this.mnuEditProducts.Text = "Show Products";
            this.mnuEditProducts.Click += new System.EventHandler(this.MnuEditProducts_Click);
            // 
            // showProductsToolStripMenuItem
            // 
            this.showProductsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showProductsToolStripMenuItem.Name = "showProductsToolStripMenuItem";
            this.showProductsToolStripMenuItem.Size = new System.Drawing.Size(87, 34);
            this.showProductsToolStripMenuItem.Text = "Agents";
            // 
            // clientsCustomersToolStripMenuItem
            // 
            this.clientsCustomersToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.clientsCustomersToolStripMenuItem.Name = "clientsCustomersToolStripMenuItem";
            this.clientsCustomersToolStripMenuItem.Size = new System.Drawing.Size(184, 34);
            this.clientsCustomersToolStripMenuItem.Text = "Clients/Customers";
            // 
            // suppliersToolStripMenuItem
            // 
            this.suppliersToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            this.suppliersToolStripMenuItem.Size = new System.Drawing.Size(107, 34);
            this.suppliersToolStripMenuItem.Text = "Suppliers";
            // 
            // companyManagementToolStripMenuItem
            // 
            this.companyManagementToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.companyManagementToolStripMenuItem.Name = "companyManagementToolStripMenuItem";
            this.companyManagementToolStripMenuItem.Size = new System.Drawing.Size(230, 34);
            this.companyManagementToolStripMenuItem.Text = "Company Management";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(94, 34);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(98, 34);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(66, 34);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // tmrCurrent
            // 
            this.tmrCurrent.Enabled = true;
            this.tmrCurrent.Interval = 1000;
            this.tmrCurrent.Tick += new System.EventHandler(this.TmrCurrent_Tick);
            // 
            // pnlContent
            // 
            this.pnlContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlContent.Location = new System.Drawing.Point(3, 43);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1586, 836);
            this.pnlContent.TabIndex = 14;
            // 
            // pnlUser
            // 
            this.pnlUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUser.Controls.Add(this.indName);
            this.pnlUser.Controls.Add(this.label6);
            this.pnlUser.Location = new System.Drawing.Point(1271, 3);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(315, 134);
            this.pnlUser.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Wingdings", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(248, 12);
            this.label6.MinimumSize = new System.Drawing.Size(64, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 64);
            this.label6.TabIndex = 7;
            // 
            // indName
            // 
            this.indName.AutoSize = true;
            this.indName.BackColor = System.Drawing.Color.Transparent;
            this.indName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.indName.Font = new System.Drawing.Font("Saira Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indName.ForeColor = System.Drawing.Color.White;
            this.indName.Location = new System.Drawing.Point(72, 25);
            this.indName.MinimumSize = new System.Drawing.Size(24, 32);
            this.indName.Name = "indName";
            this.indName.Size = new System.Drawing.Size(167, 42);
            this.indName.TabIndex = 11;
            this.indName.Text = "Sherlyn Yap";
            // 
            // pnlNotifications
            // 
            this.pnlNotifications.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlNotifications.Controls.Add(this.button9);
            this.pnlNotifications.Controls.Add(this.btnMessages);
            this.pnlNotifications.Controls.Add(this.indPackCount);
            this.pnlNotifications.Controls.Add(this.indMessageCounter);
            this.pnlNotifications.Location = new System.Drawing.Point(1033, 3);
            this.pnlNotifications.Name = "pnlNotifications";
            this.pnlNotifications.Size = new System.Drawing.Size(232, 134);
            this.pnlNotifications.TabIndex = 14;
            // 
            // indMessageCounter
            // 
            this.indMessageCounter.AutoSize = true;
            this.indMessageCounter.BackColor = System.Drawing.Color.Transparent;
            this.indMessageCounter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.indMessageCounter.Font = new System.Drawing.Font("Saira", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indMessageCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.indMessageCounter.Location = new System.Drawing.Point(65, 40);
            this.indMessageCounter.MinimumSize = new System.Drawing.Size(24, 32);
            this.indMessageCounter.Name = "indMessageCounter";
            this.indMessageCounter.Size = new System.Drawing.Size(49, 46);
            this.indMessageCounter.TabIndex = 7;
            this.indMessageCounter.Text = "12";
            // 
            // indPackCount
            // 
            this.indPackCount.AutoSize = true;
            this.indPackCount.BackColor = System.Drawing.Color.Transparent;
            this.indPackCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.indPackCount.Font = new System.Drawing.Font("Saira", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indPackCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.indPackCount.Location = new System.Drawing.Point(161, 40);
            this.indPackCount.MinimumSize = new System.Drawing.Size(24, 32);
            this.indPackCount.Name = "indPackCount";
            this.indPackCount.Size = new System.Drawing.Size(49, 46);
            this.indPackCount.TabIndex = 7;
            this.indPackCount.Text = "12";
            // 
            // btnMessages
            // 
            this.btnMessages.BackColor = System.Drawing.Color.Transparent;
            this.btnMessages.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMessages.BackgroundImage")));
            this.btnMessages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMessages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMessages.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMessages.FlatAppearance.BorderSize = 0;
            this.btnMessages.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnMessages.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMessages.Font = new System.Drawing.Font("Saira Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessages.ForeColor = System.Drawing.Color.White;
            this.btnMessages.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMessages.Location = new System.Drawing.Point(15, 35);
            this.btnMessages.MaximumSize = new System.Drawing.Size(64, 68);
            this.btnMessages.MinimumSize = new System.Drawing.Size(32, 32);
            this.btnMessages.Name = "btnMessages";
            this.btnMessages.Size = new System.Drawing.Size(54, 51);
            this.btnMessages.TabIndex = 9;
            this.btnMessages.Text = " INVENTORY";
            this.btnMessages.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnMessages.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMessages.UseVisualStyleBackColor = false;
            this.btnMessages.Click += new System.EventHandler(this.BtnMessages_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9.BackgroundImage")));
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Saira Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(111, 38);
            this.button9.MaximumSize = new System.Drawing.Size(64, 68);
            this.button9.MinimumSize = new System.Drawing.Size(32, 32);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(54, 51);
            this.button9.TabIndex = 9;
            this.button9.Text = " INVENTORY";
            this.button9.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // pnlClock
            // 
            this.pnlClock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlClock.Controls.Add(this.indDate);
            this.pnlClock.Controls.Add(this.indTime);
            this.pnlClock.Location = new System.Drawing.Point(604, 3);
            this.pnlClock.Name = "pnlClock";
            this.pnlClock.Size = new System.Drawing.Size(423, 134);
            this.pnlClock.TabIndex = 14;
            // 
            // indTime
            // 
            this.indTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.indTime.AutoSize = true;
            this.indTime.BackColor = System.Drawing.Color.Transparent;
            this.indTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.indTime.Font = new System.Drawing.Font("Saira Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indTime.ForeColor = System.Drawing.Color.White;
            this.indTime.Location = new System.Drawing.Point(46, 0);
            this.indTime.MinimumSize = new System.Drawing.Size(24, 32);
            this.indTime.Name = "indTime";
            this.indTime.Size = new System.Drawing.Size(317, 101);
            this.indTime.TabIndex = 7;
            this.indTime.Text = "12:30 AM";
            this.indTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // indDate
            // 
            this.indDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.indDate.AutoSize = true;
            this.indDate.BackColor = System.Drawing.Color.Transparent;
            this.indDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.indDate.Font = new System.Drawing.Font("Saira Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indDate.ForeColor = System.Drawing.Color.White;
            this.indDate.Location = new System.Drawing.Point(101, 84);
            this.indDate.MinimumSize = new System.Drawing.Size(24, 32);
            this.indDate.Name = "indDate";
            this.indDate.Size = new System.Drawing.Size(233, 32);
            this.indDate.TabIndex = 7;
            this.indDate.Text = "Monday, March 23. 2020";
            this.indDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel11.Location = new System.Drawing.Point(3, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(312, 134);
            this.panel11.TabIndex = 15;
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.Location = new System.Drawing.Point(321, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(277, 134);
            this.panel10.TabIndex = 14;
            // 
            // tblLayoutTop
            // 
            this.tblLayoutTop.AutoSize = true;
            this.tblLayoutTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblLayoutTop.BackColor = System.Drawing.Color.Transparent;
            this.tblLayoutTop.ColumnCount = 5;
            this.tblLayoutTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLayoutTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.8481F));
            this.tblLayoutTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.02532F));
            this.tblLayoutTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblLayoutTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLayoutTop.Controls.Add(this.panel10, 1, 0);
            this.tblLayoutTop.Controls.Add(this.panel11, 0, 0);
            this.tblLayoutTop.Controls.Add(this.pnlClock, 2, 0);
            this.tblLayoutTop.Controls.Add(this.pnlNotifications, 3, 0);
            this.tblLayoutTop.Controls.Add(this.pnlUser, 4, 0);
            this.tblLayoutTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblLayoutTop.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tblLayoutTop.Location = new System.Drawing.Point(0, 40);
            this.tblLayoutTop.MaximumSize = new System.Drawing.Size(0, 140);
            this.tblLayoutTop.Name = "tblLayoutTop";
            this.tblLayoutTop.RowCount = 1;
            this.tblLayoutTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tblLayoutTop.Size = new System.Drawing.Size(1589, 140);
            this.tblLayoutTop.TabIndex = 13;
            // 
            // tblLayoutCenter
            // 
            this.tblLayoutCenter.AutoSize = true;
            this.tblLayoutCenter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblLayoutCenter.BackColor = System.Drawing.Color.Transparent;
            this.tblLayoutCenter.ColumnCount = 4;
            this.tblLayoutCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.891414F));
            this.tblLayoutCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.9495F));
            this.tblLayoutCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.98993F));
            this.tblLayoutCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.19383F));
            this.tblLayoutCenter.Controls.Add(this.pnlInventory, 3, 1);
            this.tblLayoutCenter.Controls.Add(this.pnlContacts, 3, 0);
            this.tblLayoutCenter.Controls.Add(this.panel16, 3, 2);
            this.tblLayoutCenter.Controls.Add(this.pnlCenter, 2, 1);
            this.tblLayoutCenter.Controls.Add(this.pnlTerminal, 2, 2);
            this.tblLayoutCenter.Controls.Add(this.pnlTop, 2, 0);
            this.tblLayoutCenter.Controls.Add(this.pnlOperations, 1, 0);
            this.tblLayoutCenter.Controls.Add(this.pnlDocuments, 1, 1);
            this.tblLayoutCenter.Controls.Add(this.pnlSideBar, 0, 0);
            this.tblLayoutCenter.Controls.Add(this.pnlReports, 1, 2);
            this.tblLayoutCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutCenter.Location = new System.Drawing.Point(0, 180);
            this.tblLayoutCenter.Name = "tblLayoutCenter";
            this.tblLayoutCenter.RowCount = 3;
            this.tblLayoutCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.31922F));
            this.tblLayoutCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.97586F));
            this.tblLayoutCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.73316F));
            this.tblLayoutCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayoutCenter.Size = new System.Drawing.Size(1589, 699);
            this.tblLayoutCenter.TabIndex = 19;
            // 
            // pnlInventory
            // 
            this.pnlInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlInventory.Controls.Add(this.pnExpander);
            this.pnlInventory.Location = new System.Drawing.Point(1142, 235);
            this.pnlInventory.Name = "pnlInventory";
            this.pnlInventory.Size = new System.Drawing.Size(444, 252);
            this.pnlInventory.TabIndex = 15;
            // 
            // pnExpander
            // 
            this.pnExpander.BackColor = System.Drawing.Color.Black;
            this.pnExpander.Controls.Add(this.gbxInventory);
            this.pnExpander.Location = new System.Drawing.Point(8, 15);
            this.pnExpander.MaximumSize = new System.Drawing.Size(515, 266);
            this.pnExpander.MinimumSize = new System.Drawing.Size(164, 52);
            this.pnExpander.Name = "pnExpander";
            this.pnExpander.Size = new System.Drawing.Size(164, 52);
            this.pnExpander.TabIndex = 0;
            // 
            // gbxInventory
            // 
            this.gbxInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxInventory.BackColor = System.Drawing.Color.Transparent;
            this.gbxInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gbxInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbxInventory.Font = new System.Drawing.Font("Saira Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxInventory.ForeColor = System.Drawing.Color.White;
            this.gbxInventory.Location = new System.Drawing.Point(3, 3);
            this.gbxInventory.MaximumSize = new System.Drawing.Size(350, 300);
            this.gbxInventory.MinimumSize = new System.Drawing.Size(142, 42);
            this.gbxInventory.Name = "gbxInventory";
            this.gbxInventory.Size = new System.Drawing.Size(142, 46);
            this.gbxInventory.TabIndex = 10;
            this.gbxInventory.TabStop = false;
            this.gbxInventory.Text = "INVENTORY";
            // 
            // pnlContacts
            // 
            this.pnlContacts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContacts.Controls.Add(this.groupBox1);
            this.pnlContacts.Location = new System.Drawing.Point(1142, 3);
            this.pnlContacts.Name = "pnlContacts";
            this.pnlContacts.Size = new System.Drawing.Size(444, 226);
            this.pnlContacts.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Saira Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(11, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 214);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CONTACTS";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Saira Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(9, 31);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(256, 54);
            this.button5.TabIndex = 9;
            this.button5.Text = " DOCTORS";
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Saira Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(9, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(256, 54);
            this.button2.TabIndex = 9;
            this.button2.Text = "  CLINICS";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel16
            // 
            this.panel16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel16.Controls.Add(this.label5);
            this.panel16.Controls.Add(this.label8);
            this.panel16.Controls.Add(this.btnHideAll);
            this.panel16.Controls.Add(this.button7);
            this.panel16.Location = new System.Drawing.Point(1142, 493);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(444, 203);
            this.panel16.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Saira Light Italic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 171);
            this.label5.MinimumSize = new System.Drawing.Size(24, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "Licensed to: TGIF Pharmacy";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Saira Light Italic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(324, 171);
            this.label8.MinimumSize = new System.Drawing.Size(24, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 32);
            this.label8.TabIndex = 11;
            this.label8.Text = "Ver. 0.9 Alpha";
            // 
            // btnHideAll
            // 
            this.btnHideAll.BackColor = System.Drawing.Color.Transparent;
            this.btnHideAll.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHideAll.FlatAppearance.BorderSize = 0;
            this.btnHideAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnHideAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnHideAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideAll.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHideAll.ForeColor = System.Drawing.Color.Transparent;
            this.btnHideAll.Image = ((System.Drawing.Image)(resources.GetObject("btnHideAll.Image")));
            this.btnHideAll.Location = new System.Drawing.Point(384, 108);
            this.btnHideAll.Name = "btnHideAll";
            this.btnHideAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnHideAll.Size = new System.Drawing.Size(51, 48);
            this.btnHideAll.TabIndex = 9;
            this.btnHideAll.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Maroon;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(298, 90);
            this.button7.Name = "button7";
            this.button7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button7.Size = new System.Drawing.Size(70, 66);
            this.button7.TabIndex = 9;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // pnlCenter
            // 
            this.pnlCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCenter.Controls.Add(this.lbl);
            this.pnlCenter.Controls.Add(this.label10);
            this.pnlCenter.Location = new System.Drawing.Point(444, 235);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(692, 252);
            this.pnlCenter.TabIndex = 15;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl.Font = new System.Drawing.Font("Saira SemiCondensed", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Image = ((System.Drawing.Image)(resources.GetObject("lbl.Image")));
            this.lbl.Location = new System.Drawing.Point(161, 27);
            this.lbl.MinimumSize = new System.Drawing.Size(400, 128);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(400, 151);
            this.lbl.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Wingdings", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.Location = new System.Drawing.Point(132, -13);
            this.label10.MinimumSize = new System.Drawing.Size(500, 281);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(500, 281);
            this.label10.TabIndex = 7;
            // 
            // pnlTerminal
            // 
            this.pnlTerminal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTerminal.Controls.Add(this.gbx3);
            this.pnlTerminal.Location = new System.Drawing.Point(444, 493);
            this.pnlTerminal.Name = "pnlTerminal";
            this.pnlTerminal.Size = new System.Drawing.Size(692, 203);
            this.pnlTerminal.TabIndex = 15;
            // 
            // gbx3
            // 
            this.gbx3.AutoSize = true;
            this.gbx3.BackColor = System.Drawing.Color.Transparent;
            this.gbx3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbx3.BackgroundImage")));
            this.gbx3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gbx3.Controls.Add(this.txtTerminal);
            this.gbx3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbx3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbx3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbx3.Font = new System.Drawing.Font("Saira Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx3.ForeColor = System.Drawing.Color.White;
            this.gbx3.Location = new System.Drawing.Point(0, 0);
            this.gbx3.Name = "gbx3";
            this.gbx3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbx3.Size = new System.Drawing.Size(692, 203);
            this.gbx3.TabIndex = 10;
            this.gbx3.TabStop = false;
            this.gbx3.Text = "PLERES TERMINAL";
            // 
            // txtTerminal
            // 
            this.txtTerminal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.txtTerminal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTerminal.Font = new System.Drawing.Font("Exo 2", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTerminal.ForeColor = System.Drawing.Color.White;
            this.txtTerminal.Location = new System.Drawing.Point(6, 34);
            this.txtTerminal.Multiline = true;
            this.txtTerminal.Name = "txtTerminal";
            this.txtTerminal.Size = new System.Drawing.Size(683, 150);
            this.txtTerminal.TabIndex = 0;
            this.txtTerminal.Text = "~PLERES> Logged in Successfully. Welcome Dr. Blaze013";
            // 
            // pnlTop
            // 
            this.pnlTop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTop.Controls.Add(this.label7);
            this.pnlTop.Controls.Add(this.button6);
            this.pnlTop.Controls.Add(this.lblInventory);
            this.pnlTop.Location = new System.Drawing.Point(444, 3);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(692, 226);
            this.pnlTop.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Saira Light Italic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(135, 161);
            this.label7.MinimumSize = new System.Drawing.Size(24, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(463, 33);
            this.label7.TabIndex = 11;
            this.label7.Text = "To Do Next... Build A CRUD System with SQLite";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button6.FlatAppearance.BorderSize = 2;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Saira Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(449, 67);
            this.button6.MaximumSize = new System.Drawing.Size(250, 54);
            this.button6.MinimumSize = new System.Drawing.Size(240, 54);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(240, 54);
            this.button6.TabIndex = 9;
            this.button6.Text = " INVENTORY";
            this.button6.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.BackColor = System.Drawing.Color.Transparent;
            this.lblInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInventory.Font = new System.Drawing.Font("Saira SemiCondensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventory.ForeColor = System.Drawing.Color.White;
            this.lblInventory.Location = new System.Drawing.Point(254, 62);
            this.lblInventory.MinimumSize = new System.Drawing.Size(200, 64);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(200, 64);
            this.lblInventory.TabIndex = 7;
            this.lblInventory.Text = "Products";
            // 
            // pnlOperations
            // 
            this.pnlOperations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOperations.Controls.Add(this.button4);
            this.pnlOperations.Controls.Add(this.button3);
            this.pnlOperations.Controls.Add(this.btnAddProduct);
            this.pnlOperations.Controls.Add(this.lbxBatches);
            this.pnlOperations.Controls.Add(this.button1);
            this.pnlOperations.Location = new System.Drawing.Point(128, 3);
            this.pnlOperations.Name = "pnlOperations";
            this.pnlOperations.Size = new System.Drawing.Size(310, 226);
            this.pnlOperations.TabIndex = 15;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Saira Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(30, 78);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(220, 48);
            this.button4.TabIndex = 9;
            this.button4.Text = "  BATCHES";
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Saira Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(30, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(220, 48);
            this.button3.TabIndex = 9;
            this.button3.Text = "  PRODUCTS";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.Image")));
            this.btnAddProduct.Location = new System.Drawing.Point(285, 23);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddProduct.Size = new System.Drawing.Size(28, 48);
            this.btnAddProduct.TabIndex = 9;
            this.btnAddProduct.UseVisualStyleBackColor = false;
            // 
            // lbxBatches
            // 
            this.lbxBatches.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.lbxBatches.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxBatches.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxBatches.ForeColor = System.Drawing.SystemColors.Window;
            this.lbxBatches.FormattingEnabled = true;
            this.lbxBatches.ItemHeight = 21;
            this.lbxBatches.Items.AddRange(new object[] {
            "Sheamiclor",
            "Appekidz",
            "Kids-Protect",
            "Ferromax"});
            this.lbxBatches.Location = new System.Drawing.Point(30, 132);
            this.lbxBatches.Name = "lbxBatches";
            this.lbxBatches.ScrollAlwaysVisible = true;
            this.lbxBatches.Size = new System.Drawing.Size(254, 105);
            this.lbxBatches.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(285, 78);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(29, 48);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pnlDocuments
            // 
            this.pnlDocuments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDocuments.Location = new System.Drawing.Point(128, 235);
            this.pnlDocuments.Name = "pnlDocuments";
            this.pnlDocuments.Size = new System.Drawing.Size(310, 252);
            this.pnlDocuments.TabIndex = 15;
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSideBar.AutoSize = true;
            this.pnlSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlSideBar.Controls.Add(this.btnConsole);
            this.pnlSideBar.Location = new System.Drawing.Point(3, 3);
            this.pnlSideBar.Name = "pnlSideBar";
            this.tblLayoutCenter.SetRowSpan(this.pnlSideBar, 3);
            this.pnlSideBar.Size = new System.Drawing.Size(119, 693);
            this.pnlSideBar.TabIndex = 15;
            // 
            // btnConsole
            // 
            this.btnConsole.BackColor = System.Drawing.Color.Transparent;
            this.btnConsole.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsole.BackgroundImage")));
            this.btnConsole.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConsole.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsole.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsole.FlatAppearance.BorderSize = 0;
            this.btnConsole.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConsole.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnConsole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsole.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsole.ForeColor = System.Drawing.Color.Maroon;
            this.btnConsole.Location = new System.Drawing.Point(0, 0);
            this.btnConsole.Name = "btnConsole";
            this.btnConsole.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnConsole.Size = new System.Drawing.Size(119, 54);
            this.btnConsole.TabIndex = 9;
            this.btnConsole.UseVisualStyleBackColor = false;
            // 
            // pnlReports
            // 
            this.pnlReports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlReports.Controls.Add(this.gbxRadio);
            this.pnlReports.Location = new System.Drawing.Point(128, 493);
            this.pnlReports.Name = "pnlReports";
            this.pnlReports.Size = new System.Drawing.Size(310, 203);
            this.pnlReports.TabIndex = 15;
            // 
            // gbxRadio
            // 
            this.gbxRadio.BackColor = System.Drawing.Color.Transparent;
            this.gbxRadio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbxRadio.BackgroundImage")));
            this.gbxRadio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gbxRadio.Controls.Add(this.radioButton3);
            this.gbxRadio.Controls.Add(this.checkBox3);
            this.gbxRadio.Controls.Add(this.checkBox2);
            this.gbxRadio.Controls.Add(this.checkBox1);
            this.gbxRadio.Controls.Add(this.radioButton2);
            this.gbxRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbxRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxRadio.Font = new System.Drawing.Font("Saira Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxRadio.ForeColor = System.Drawing.Color.White;
            this.gbxRadio.Location = new System.Drawing.Point(30, 33);
            this.gbxRadio.Name = "gbxRadio";
            this.gbxRadio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbxRadio.Size = new System.Drawing.Size(251, 151);
            this.gbxRadio.TabIndex = 10;
            this.gbxRadio.TabStop = false;
            this.gbxRadio.Text = "PLERES TERMINAL";
            // 
            // radioButton3
            // 
            this.radioButton3.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.Transparent;
            this.radioButton3.Checked = true;
            this.radioButton3.FlatAppearance.BorderSize = 0;
            this.radioButton3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.radioButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.radioButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.ForeColor = System.Drawing.Color.White;
            this.radioButton3.Image = ((System.Drawing.Image)(resources.GetObject("radioButton3.Image")));
            this.radioButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioButton3.Location = new System.Drawing.Point(6, 26);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButton3.Size = new System.Drawing.Size(111, 35);
            this.radioButton3.TabIndex = 12;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "option1";
            this.radioButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox3.AutoSize = true;
            this.checkBox3.FlatAppearance.BorderSize = 0;
            this.checkBox3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.checkBox3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.checkBox3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox3.ForeColor = System.Drawing.Color.White;
            this.checkBox3.Image = ((System.Drawing.Image)(resources.GetObject("checkBox3.Image")));
            this.checkBox3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox3.Location = new System.Drawing.Point(341, 98);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox3.Size = new System.Drawing.Size(138, 40);
            this.checkBox3.TabIndex = 13;
            this.checkBox3.Text = "checkBox1";
            this.checkBox3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox2.AutoSize = true;
            this.checkBox2.FlatAppearance.BorderSize = 0;
            this.checkBox2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.checkBox2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.checkBox2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.ForeColor = System.Drawing.Color.White;
            this.checkBox2.Image = ((System.Drawing.Image)(resources.GetObject("checkBox2.Image")));
            this.checkBox2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox2.Location = new System.Drawing.Point(18, 98);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox2.Size = new System.Drawing.Size(138, 40);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "checkBox1";
            this.checkBox2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatAppearance.BorderSize = 0;
            this.checkBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.checkBox1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.checkBox1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Image = ((System.Drawing.Image)(resources.GetObject("checkBox1.Image")));
            this.checkBox1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox1.Location = new System.Drawing.Point(21, 62);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox1.Size = new System.Drawing.Size(138, 40);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Checked = true;
            this.radioButton2.FlatAppearance.BorderSize = 0;
            this.radioButton2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.radioButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.radioButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Image = ((System.Drawing.Image)(resources.GetObject("radioButton2.Image")));
            this.radioButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioButton2.Location = new System.Drawing.Point(313, 64);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButton2.Size = new System.Drawing.Size(111, 35);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "option1";
            this.radioButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // tmiDashboard
            // 
            this.tmiDashboard.BackColor = System.Drawing.Color.DarkRed;
            this.tmiDashboard.ForeColor = System.Drawing.Color.White;
            this.tmiDashboard.Name = "tmiDashboard";
            this.tmiDashboard.Size = new System.Drawing.Size(181, 34);
            this.tmiDashboard.Text = "Dashboard";
            this.tmiDashboard.Click += new System.EventHandler(this.TmiDashboard_Click);
            // 
            // tmiLogout
            // 
            this.tmiLogout.BackColor = System.Drawing.Color.DarkRed;
            this.tmiLogout.ForeColor = System.Drawing.Color.White;
            this.tmiLogout.Name = "tmiLogout";
            this.tmiLogout.Size = new System.Drawing.Size(181, 34);
            this.tmiLogout.Text = "Log Out";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1589, 879);
            this.Controls.Add(this.tblLayoutCenter);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.tblLayoutTop);
            this.Controls.Add(this.mnuMain);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMain;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1980, 1080);
            this.MinimumSize = new System.Drawing.Size(1598, 898);
            this.Name = "MainForm";
            this.Opacity = 0.98D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Pleres 0.1";
            this.Load += new System.EventHandler(this.PleresMain_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            this.pnlNotifications.ResumeLayout(false);
            this.pnlNotifications.PerformLayout();
            this.pnlClock.ResumeLayout(false);
            this.pnlClock.PerformLayout();
            this.tblLayoutTop.ResumeLayout(false);
            this.tblLayoutCenter.ResumeLayout(false);
            this.tblLayoutCenter.PerformLayout();
            this.pnlInventory.ResumeLayout(false);
            this.pnExpander.ResumeLayout(false);
            this.pnlContacts.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.pnlCenter.ResumeLayout(false);
            this.pnlCenter.PerformLayout();
            this.pnlTerminal.ResumeLayout(false);
            this.pnlTerminal.PerformLayout();
            this.gbx3.ResumeLayout(false);
            this.gbx3.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlOperations.ResumeLayout(false);
            this.pnlSideBar.ResumeLayout(false);
            this.pnlReports.ResumeLayout(false);
            this.gbxRadio.ResumeLayout(false);
            this.gbxRadio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAddProduct;
        private System.Windows.Forms.ToolStripMenuItem mnuAddBatch;
        private System.Windows.Forms.ToolStripMenuItem showProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuEditProducts;
        private System.Windows.Forms.Timer tmrCurrent;
        private System.Windows.Forms.ToolStripMenuItem clientsCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Label indName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlNotifications;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnMessages;
        private System.Windows.Forms.Label indPackCount;
        private System.Windows.Forms.Label indMessageCounter;
        private System.Windows.Forms.Panel pnlClock;
        private System.Windows.Forms.Label indDate;
        private System.Windows.Forms.Label indTime;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TableLayoutPanel tblLayoutTop;
        private System.Windows.Forms.TableLayoutPanel tblLayoutCenter;
        private System.Windows.Forms.Panel pnlInventory;
        private System.Windows.Forms.Panel pnExpander;
        private System.Windows.Forms.GroupBox gbxInventory;
        private System.Windows.Forms.Panel pnlContacts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnHideAll;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnlTerminal;
        private System.Windows.Forms.GroupBox gbx3;
        private System.Windows.Forms.TextBox txtTerminal;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Panel pnlOperations;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.ListBox lbxBatches;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlDocuments;
        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Button btnConsole;
        private System.Windows.Forms.Panel pnlReports;
        private System.Windows.Forms.GroupBox gbxRadio;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ToolStripMenuItem tmiDashboard;
        private System.Windows.Forms.ToolStripMenuItem tmiLogout;
    }
}

