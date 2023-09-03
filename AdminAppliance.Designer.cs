namespace Rental_System
{
    partial class AdminAppliance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAppliance));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applianceTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applianceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applianceViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtApplianceID = new System.Windows.Forms.TextBox();
            this.txtApplianceName = new System.Windows.Forms.TextBox();
            this.txtPowerUsage = new System.Windows.Forms.TextBox();
            this.txtTypicalUsage = new System.Windows.Forms.TextBox();
            this.txtAvaliableQuantity = new System.Windows.Forms.TextBox();
            this.txtApplianceDetail = new System.Windows.Forms.TextBox();
            this.txtApplianceTypeID = new System.Windows.Forms.TextBox();
            this.comboApplianceTypeName = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.lblStatusErr = new System.Windows.Forms.Label();
            this.lblApplianceDetailErr = new System.Windows.Forms.Label();
            this.lblApplianceTNameErr = new System.Windows.Forms.Label();
            this.lblAvaliableQuantityErr = new System.Windows.Forms.Label();
            this.lblTypicalUsageErr = new System.Windows.Forms.Label();
            this.lblPowerUsageErr = new System.Windows.Forms.Label();
            this.lblApplianceNameErr = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvApplianceView = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lblPriceErr = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblModelErr = new System.Windows.Forms.Label();
            this.lblBrandErr = new System.Windows.Forms.Label();
            this.lblColorErr = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.comboColor = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplianceView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.applianceTypeToolStripMenuItem,
            this.applianceToolStripMenuItem,
            this.applianceViewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1043, 33);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // applianceTypeToolStripMenuItem
            // 
            this.applianceTypeToolStripMenuItem.Name = "applianceTypeToolStripMenuItem";
            this.applianceTypeToolStripMenuItem.Size = new System.Drawing.Size(144, 29);
            this.applianceTypeToolStripMenuItem.Text = "Appliance Type";
            this.applianceTypeToolStripMenuItem.Click += new System.EventHandler(this.applianceTypeToolStripMenuItem_Click);
            // 
            // applianceToolStripMenuItem
            // 
            this.applianceToolStripMenuItem.Name = "applianceToolStripMenuItem";
            this.applianceToolStripMenuItem.Size = new System.Drawing.Size(107, 29);
            this.applianceToolStripMenuItem.Text = "Appliance ";
            this.applianceToolStripMenuItem.Click += new System.EventHandler(this.applianceToolStripMenuItem_Click);
            // 
            // applianceViewToolStripMenuItem
            // 
            this.applianceViewToolStripMenuItem.Name = "applianceViewToolStripMenuItem";
            this.applianceViewToolStripMenuItem.Size = new System.Drawing.Size(76, 29);
            this.applianceViewToolStripMenuItem.Text = "Search";
            this.applianceViewToolStripMenuItem.Click += new System.EventHandler(this.applianceViewToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Appliance ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Appliance Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Power Usage :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Typical Usage :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(660, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Appliance Type ID :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(642, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Appliance Type Name :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(376, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Detail :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "Avaliable Quantity :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(83, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 19);
            this.label10.TabIndex = 14;
            this.label10.Text = "Status :";
            // 
            // txtApplianceID
            // 
            this.txtApplianceID.Location = new System.Drawing.Point(153, 24);
            this.txtApplianceID.Name = "txtApplianceID";
            this.txtApplianceID.ReadOnly = true;
            this.txtApplianceID.Size = new System.Drawing.Size(184, 26);
            this.txtApplianceID.TabIndex = 15;
            // 
            // txtApplianceName
            // 
            this.txtApplianceName.Location = new System.Drawing.Point(154, 66);
            this.txtApplianceName.Name = "txtApplianceName";
            this.txtApplianceName.Size = new System.Drawing.Size(184, 26);
            this.txtApplianceName.TabIndex = 16;
            // 
            // txtPowerUsage
            // 
            this.txtPowerUsage.Location = new System.Drawing.Point(154, 115);
            this.txtPowerUsage.Name = "txtPowerUsage";
            this.txtPowerUsage.Size = new System.Drawing.Size(184, 26);
            this.txtPowerUsage.TabIndex = 17;
            // 
            // txtTypicalUsage
            // 
            this.txtTypicalUsage.Location = new System.Drawing.Point(154, 166);
            this.txtTypicalUsage.Name = "txtTypicalUsage";
            this.txtTypicalUsage.Size = new System.Drawing.Size(184, 26);
            this.txtTypicalUsage.TabIndex = 18;
            // 
            // txtAvaliableQuantity
            // 
            this.txtAvaliableQuantity.Location = new System.Drawing.Point(155, 264);
            this.txtAvaliableQuantity.Name = "txtAvaliableQuantity";
            this.txtAvaliableQuantity.Size = new System.Drawing.Size(184, 26);
            this.txtAvaliableQuantity.TabIndex = 19;
            // 
            // txtApplianceDetail
            // 
            this.txtApplianceDetail.Location = new System.Drawing.Point(448, 236);
            this.txtApplianceDetail.Multiline = true;
            this.txtApplianceDetail.Name = "txtApplianceDetail";
            this.txtApplianceDetail.Size = new System.Drawing.Size(184, 54);
            this.txtApplianceDetail.TabIndex = 21;
            // 
            // txtApplianceTypeID
            // 
            this.txtApplianceTypeID.Location = new System.Drawing.Point(808, 75);
            this.txtApplianceTypeID.Name = "txtApplianceTypeID";
            this.txtApplianceTypeID.ReadOnly = true;
            this.txtApplianceTypeID.Size = new System.Drawing.Size(184, 26);
            this.txtApplianceTypeID.TabIndex = 22;
            // 
            // comboApplianceTypeName
            // 
            this.comboApplianceTypeName.FormattingEnabled = true;
            this.comboApplianceTypeName.Location = new System.Drawing.Point(811, 24);
            this.comboApplianceTypeName.Name = "comboApplianceTypeName";
            this.comboApplianceTypeName.Size = new System.Drawing.Size(184, 27);
            this.comboApplianceTypeName.TabIndex = 23;
            this.comboApplianceTypeName.SelectedIndexChanged += new System.EventHandler(this.comboApplianceTypeName_SelectedIndexChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(706, 240);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(67, 38);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(781, 240);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(67, 38);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comboStatus
            // 
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.comboStatus.Location = new System.Drawing.Point(155, 213);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(184, 27);
            this.comboStatus.TabIndex = 28;
            // 
            // lblStatusErr
            // 
            this.lblStatusErr.AutoSize = true;
            this.lblStatusErr.ForeColor = System.Drawing.Color.Red;
            this.lblStatusErr.Location = new System.Drawing.Point(179, 240);
            this.lblStatusErr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatusErr.Name = "lblStatusErr";
            this.lblStatusErr.Size = new System.Drawing.Size(128, 19);
            this.lblStatusErr.TabIndex = 37;
            this.lblStatusErr.Text = "(Status is required!)";
            // 
            // lblApplianceDetailErr
            // 
            this.lblApplianceDetailErr.AutoSize = true;
            this.lblApplianceDetailErr.ForeColor = System.Drawing.Color.Red;
            this.lblApplianceDetailErr.Location = new System.Drawing.Point(445, 290);
            this.lblApplianceDetailErr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApplianceDetailErr.Name = "lblApplianceDetailErr";
            this.lblApplianceDetailErr.Size = new System.Drawing.Size(191, 19);
            this.lblApplianceDetailErr.TabIndex = 36;
            this.lblApplianceDetailErr.Text = "(Appliance Detail is required!)";
            // 
            // lblApplianceTNameErr
            // 
            this.lblApplianceTNameErr.AutoSize = true;
            this.lblApplianceTNameErr.ForeColor = System.Drawing.Color.Red;
            this.lblApplianceTNameErr.Location = new System.Drawing.Point(825, 51);
            this.lblApplianceTNameErr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApplianceTNameErr.Name = "lblApplianceTNameErr";
            this.lblApplianceTNameErr.Size = new System.Drawing.Size(161, 19);
            this.lblApplianceTNameErr.TabIndex = 34;
            this.lblApplianceTNameErr.Text = "(You need to select one!)";
            // 
            // lblAvaliableQuantityErr
            // 
            this.lblAvaliableQuantityErr.AutoSize = true;
            this.lblAvaliableQuantityErr.ForeColor = System.Drawing.Color.Red;
            this.lblAvaliableQuantityErr.Location = new System.Drawing.Point(150, 289);
            this.lblAvaliableQuantityErr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvaliableQuantityErr.Name = "lblAvaliableQuantityErr";
            this.lblAvaliableQuantityErr.Size = new System.Drawing.Size(201, 19);
            this.lblAvaliableQuantityErr.TabIndex = 33;
            this.lblAvaliableQuantityErr.Text = "(Avaliable Quantity is required!)";
            // 
            // lblTypicalUsageErr
            // 
            this.lblTypicalUsageErr.AutoSize = true;
            this.lblTypicalUsageErr.ForeColor = System.Drawing.Color.Red;
            this.lblTypicalUsageErr.Location = new System.Drawing.Point(156, 192);
            this.lblTypicalUsageErr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTypicalUsageErr.Name = "lblTypicalUsageErr";
            this.lblTypicalUsageErr.Size = new System.Drawing.Size(176, 19);
            this.lblTypicalUsageErr.TabIndex = 32;
            this.lblTypicalUsageErr.Text = "(Typical Usage is required!)";
            // 
            // lblPowerUsageErr
            // 
            this.lblPowerUsageErr.AutoSize = true;
            this.lblPowerUsageErr.ForeColor = System.Drawing.Color.Red;
            this.lblPowerUsageErr.Location = new System.Drawing.Point(156, 141);
            this.lblPowerUsageErr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPowerUsageErr.Name = "lblPowerUsageErr";
            this.lblPowerUsageErr.Size = new System.Drawing.Size(173, 19);
            this.lblPowerUsageErr.TabIndex = 31;
            this.lblPowerUsageErr.Text = "(Power Usage is required!)";
            // 
            // lblApplianceNameErr
            // 
            this.lblApplianceNameErr.AutoSize = true;
            this.lblApplianceNameErr.ForeColor = System.Drawing.Color.Red;
            this.lblApplianceNameErr.Location = new System.Drawing.Point(144, 92);
            this.lblApplianceNameErr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApplianceNameErr.Name = "lblApplianceNameErr";
            this.lblApplianceNameErr.Size = new System.Drawing.Size(193, 19);
            this.lblApplianceNameErr.TabIndex = 30;
            this.lblApplianceNameErr.Text = "(Appliance Name is required!)";
            // 
            // picBox
            // 
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox.Image = ((System.Drawing.Image)(resources.GetObject("picBox.Image")));
            this.picBox.Location = new System.Drawing.Point(808, 115);
            this.picBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(183, 107);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 39;
            this.picBox.TabStop = false;
            this.picBox.Click += new System.EventHandler(this.picBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(673, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 38;
            this.label1.Text = "Appliance Image :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvApplianceView);
            this.groupBox1.Location = new System.Drawing.Point(11, 359);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1013, 276);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appliances";
            // 
            // dgvApplianceView
            // 
            this.dgvApplianceView.AllowUserToAddRows = false;
            this.dgvApplianceView.AllowUserToDeleteRows = false;
            this.dgvApplianceView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplianceView.Location = new System.Drawing.Point(11, 25);
            this.dgvApplianceView.Name = "dgvApplianceView";
            this.dgvApplianceView.ReadOnly = true;
            this.dgvApplianceView.RowTemplate.Height = 28;
            this.dgvApplianceView.Size = new System.Drawing.Size(996, 245);
            this.dgvApplianceView.TabIndex = 0;
            this.dgvApplianceView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvApplianceView_CellMouseClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(854, 240);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(67, 38);
            this.btnUpdate.TabIndex = 41;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(927, 241);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(67, 38);
            this.btnDelete.TabIndex = 42;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(380, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 19);
            this.label11.TabIndex = 1;
            this.label11.Text = "Price :";
            // 
            // lblPriceErr
            // 
            this.lblPriceErr.AutoSize = true;
            this.lblPriceErr.ForeColor = System.Drawing.Color.Red;
            this.lblPriceErr.Location = new System.Drawing.Point(479, 50);
            this.lblPriceErr.Name = "lblPriceErr";
            this.lblPriceErr.Size = new System.Drawing.Size(122, 19);
            this.lblPriceErr.TabIndex = 2;
            this.lblPriceErr.Text = "(Price is required!)";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(448, 24);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(183, 26);
            this.txtPrice.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(371, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 19);
            this.label12.TabIndex = 43;
            this.label12.Text = "Model :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(374, 131);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 19);
            this.label13.TabIndex = 44;
            this.label13.Text = "Brand :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(376, 175);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 19);
            this.label14.TabIndex = 45;
            this.label14.Text = "Color :";
            // 
            // lblModelErr
            // 
            this.lblModelErr.AutoSize = true;
            this.lblModelErr.ForeColor = System.Drawing.Color.Red;
            this.lblModelErr.Location = new System.Drawing.Point(470, 101);
            this.lblModelErr.Name = "lblModelErr";
            this.lblModelErr.Size = new System.Drawing.Size(131, 19);
            this.lblModelErr.TabIndex = 46;
            this.lblModelErr.Text = "(Model is required!)";
            // 
            // lblBrandErr
            // 
            this.lblBrandErr.AutoSize = true;
            this.lblBrandErr.ForeColor = System.Drawing.Color.Red;
            this.lblBrandErr.Location = new System.Drawing.Point(481, 149);
            this.lblBrandErr.Name = "lblBrandErr";
            this.lblBrandErr.Size = new System.Drawing.Size(128, 19);
            this.lblBrandErr.TabIndex = 47;
            this.lblBrandErr.Text = "(Brand is required!)";
            // 
            // lblColorErr
            // 
            this.lblColorErr.AutoSize = true;
            this.lblColorErr.ForeColor = System.Drawing.Color.Red;
            this.lblColorErr.Location = new System.Drawing.Point(479, 203);
            this.lblColorErr.Name = "lblColorErr";
            this.lblColorErr.Size = new System.Drawing.Size(126, 19);
            this.lblColorErr.TabIndex = 48;
            this.lblColorErr.Text = "(Color is required!)";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(448, 75);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(183, 26);
            this.txtModel.TabIndex = 49;
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(447, 124);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(184, 26);
            this.txtBrand.TabIndex = 50;
            // 
            // comboColor
            // 
            this.comboColor.FormattingEnabled = true;
            this.comboColor.Items.AddRange(new object[] {
            "Choose Color",
            "Yellow",
            "Red",
            "Blue",
            "White",
            "Black"});
            this.comboColor.Location = new System.Drawing.Point(448, 175);
            this.comboColor.Name = "comboColor";
            this.comboColor.Size = new System.Drawing.Size(183, 27);
            this.comboColor.TabIndex = 51;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.lblColorErr);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.comboColor);
            this.groupBox2.Controls.Add(this.comboStatus);
            this.groupBox2.Controls.Add(this.picBox);
            this.groupBox2.Controls.Add(this.txtBrand);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.lblApplianceDetailErr);
            this.groupBox2.Controls.Add(this.lblBrandErr);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtAvaliableQuantity);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.lblApplianceTNameErr);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.txtModel);
            this.groupBox2.Controls.Add(this.txtApplianceDetail);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblModelErr);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.lblAvaliableQuantityErr);
            this.groupBox2.Controls.Add(this.txtApplianceTypeID);
            this.groupBox2.Controls.Add(this.lblStatusErr);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.comboApplianceTypeName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblPriceErr);
            this.groupBox2.Controls.Add(this.lblApplianceNameErr);
            this.groupBox2.Controls.Add(this.lblPowerUsageErr);
            this.groupBox2.Controls.Add(this.lblTypicalUsageErr);
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Controls.Add(this.txtTypicalUsage);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtApplianceID);
            this.groupBox2.Controls.Add(this.txtPowerUsage);
            this.groupBox2.Controls.Add(this.txtApplianceName);
            this.groupBox2.Location = new System.Drawing.Point(11, 35);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(1013, 319);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Appliance Detail";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(941, 0);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(102, 33);
            this.btnLogOut.TabIndex = 52;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // AdminAppliance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 643);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AdminAppliance";
            this.Text = "AdminAppliance";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplianceView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applianceTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applianceToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtApplianceID;
        private System.Windows.Forms.TextBox txtApplianceName;
        private System.Windows.Forms.TextBox txtPowerUsage;
        private System.Windows.Forms.TextBox txtTypicalUsage;
        private System.Windows.Forms.TextBox txtAvaliableQuantity;
        private System.Windows.Forms.TextBox txtApplianceDetail;
        private System.Windows.Forms.TextBox txtApplianceTypeID;
        private System.Windows.Forms.ComboBox comboApplianceTypeName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.Label lblStatusErr;
        private System.Windows.Forms.Label lblApplianceDetailErr;
        private System.Windows.Forms.Label lblApplianceTNameErr;
        private System.Windows.Forms.Label lblAvaliableQuantityErr;
        private System.Windows.Forms.Label lblTypicalUsageErr;
        private System.Windows.Forms.Label lblPowerUsageErr;
        private System.Windows.Forms.Label lblApplianceNameErr;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem applianceViewToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvApplianceView;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblPriceErr;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblModelErr;
        private System.Windows.Forms.Label lblBrandErr;
        private System.Windows.Forms.Label lblColorErr;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.ComboBox comboColor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLogOut;
    }
}