namespace Rental_System
{
    partial class UserApplianceView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserApplianceView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSortApplianceNameDESC = new System.Windows.Forms.Button();
            this.btnSortApplianceTypeDESC = new System.Windows.Forms.Button();
            this.btnSortApplianceTypeASC = new System.Windows.Forms.Button();
            this.btnSortASCApplianceName = new System.Windows.Forms.Button();
            this.btnDESCSortPowerUsage = new System.Windows.Forms.Button();
            this.btnSortASCPowerUsage = new System.Windows.Forms.Button();
            this.dgvAppliances = new System.Windows.Forms.DataGridView();
            this.btnSearchAll = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applianceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applianceTypeSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.comboApplianceType = new System.Windows.Forms.ComboBox();
            this.comboPowerUsage = new System.Windows.Forms.ComboBox();
            this.comboApplianceName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoSearchApplianceType = new System.Windows.Forms.RadioButton();
            this.rdoSearchPowerUsage = new System.Windows.Forms.RadioButton();
            this.rdoApplianceName = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppliances)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnSortApplianceNameDESC);
            this.groupBox1.Controls.Add(this.btnSortApplianceTypeDESC);
            this.groupBox1.Controls.Add(this.btnSortApplianceTypeASC);
            this.groupBox1.Controls.Add(this.btnSortASCApplianceName);
            this.groupBox1.Controls.Add(this.btnDESCSortPowerUsage);
            this.groupBox1.Controls.Add(this.btnSortASCPowerUsage);
            this.groupBox1.Controls.Add(this.dgvAppliances);
            this.groupBox1.Controls.Add(this.btnSearchAll);
            this.groupBox1.Location = new System.Drawing.Point(13, 203);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(1082, 422);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appliances :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnSortApplianceNameDESC
            // 
            this.btnSortApplianceNameDESC.Location = new System.Drawing.Point(240, 66);
            this.btnSortApplianceNameDESC.Name = "btnSortApplianceNameDESC";
            this.btnSortApplianceNameDESC.Size = new System.Drawing.Size(244, 41);
            this.btnSortApplianceNameDESC.TabIndex = 16;
            this.btnSortApplianceNameDESC.Text = "Sort Appliance Name DESC";
            this.btnSortApplianceNameDESC.UseVisualStyleBackColor = true;
            this.btnSortApplianceNameDESC.Click += new System.EventHandler(this.btnSortApplianceNameDESC_Click);
            // 
            // btnSortApplianceTypeDESC
            // 
            this.btnSortApplianceTypeDESC.Location = new System.Drawing.Point(717, 67);
            this.btnSortApplianceTypeDESC.Name = "btnSortApplianceTypeDESC";
            this.btnSortApplianceTypeDESC.Size = new System.Drawing.Size(248, 40);
            this.btnSortApplianceTypeDESC.TabIndex = 15;
            this.btnSortApplianceTypeDESC.Text = "Sort Appliance Type DESC";
            this.btnSortApplianceTypeDESC.UseVisualStyleBackColor = true;
            this.btnSortApplianceTypeDESC.Click += new System.EventHandler(this.btnSortApplianceTypeDESC_Click);
            // 
            // btnSortApplianceTypeASC
            // 
            this.btnSortApplianceTypeASC.Location = new System.Drawing.Point(717, 19);
            this.btnSortApplianceTypeASC.Name = "btnSortApplianceTypeASC";
            this.btnSortApplianceTypeASC.Size = new System.Drawing.Size(248, 41);
            this.btnSortApplianceTypeASC.TabIndex = 14;
            this.btnSortApplianceTypeASC.Text = "Sort Appliance Type ASC";
            this.btnSortApplianceTypeASC.UseVisualStyleBackColor = true;
            this.btnSortApplianceTypeASC.Click += new System.EventHandler(this.btnSortApplianceTypeASC_Click);
            // 
            // btnSortASCApplianceName
            // 
            this.btnSortASCApplianceName.Location = new System.Drawing.Point(240, 19);
            this.btnSortASCApplianceName.Name = "btnSortASCApplianceName";
            this.btnSortASCApplianceName.Size = new System.Drawing.Size(244, 41);
            this.btnSortASCApplianceName.TabIndex = 13;
            this.btnSortASCApplianceName.Text = "Sort Appliance Name ASC";
            this.btnSortASCApplianceName.UseVisualStyleBackColor = true;
            this.btnSortASCApplianceName.Click += new System.EventHandler(this.btnSortASCApplianceName_Click);
            // 
            // btnDESCSortPowerUsage
            // 
            this.btnDESCSortPowerUsage.Location = new System.Drawing.Point(493, 66);
            this.btnDESCSortPowerUsage.Name = "btnDESCSortPowerUsage";
            this.btnDESCSortPowerUsage.Size = new System.Drawing.Size(218, 41);
            this.btnDESCSortPowerUsage.TabIndex = 12;
            this.btnDESCSortPowerUsage.Text = "Sort Power Usage DESC";
            this.btnDESCSortPowerUsage.UseVisualStyleBackColor = true;
            this.btnDESCSortPowerUsage.Click += new System.EventHandler(this.btnDESCSortPowerUsage_Click);
            // 
            // btnSortASCPowerUsage
            // 
            this.btnSortASCPowerUsage.Location = new System.Drawing.Point(493, 19);
            this.btnSortASCPowerUsage.Name = "btnSortASCPowerUsage";
            this.btnSortASCPowerUsage.Size = new System.Drawing.Size(218, 41);
            this.btnSortASCPowerUsage.TabIndex = 11;
            this.btnSortASCPowerUsage.Text = "Sort Power Usage ASC";
            this.btnSortASCPowerUsage.UseVisualStyleBackColor = true;
            this.btnSortASCPowerUsage.Click += new System.EventHandler(this.btnSortASCPowerUsage_Click);
            // 
            // dgvAppliances
            // 
            this.dgvAppliances.AllowUserToAddRows = false;
            this.dgvAppliances.AllowUserToDeleteRows = false;
            this.dgvAppliances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppliances.Location = new System.Drawing.Point(8, 113);
            this.dgvAppliances.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvAppliances.Name = "dgvAppliances";
            this.dgvAppliances.ReadOnly = true;
            this.dgvAppliances.RowTemplate.Height = 28;
            this.dgvAppliances.Size = new System.Drawing.Size(1066, 301);
            this.dgvAppliances.TabIndex = 0;
            // 
            // btnSearchAll
            // 
            this.btnSearchAll.Location = new System.Drawing.Point(971, 19);
            this.btnSearchAll.Name = "btnSearchAll";
            this.btnSearchAll.Size = new System.Drawing.Size(103, 88);
            this.btnSearchAll.TabIndex = 10;
            this.btnSearchAll.Text = "Show All";
            this.btnSearchAll.UseVisualStyleBackColor = true;
            this.btnSearchAll.Click += new System.EventHandler(this.btnSearchAll_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.applianceToolStripMenuItem,
            this.applianceTypeSearchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1109, 33);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // applianceToolStripMenuItem
            // 
            this.applianceToolStripMenuItem.Name = "applianceToolStripMenuItem";
            this.applianceToolStripMenuItem.Size = new System.Drawing.Size(164, 29);
            this.applianceToolStripMenuItem.Text = "Appliance Search ";
            this.applianceToolStripMenuItem.Click += new System.EventHandler(this.applianceToolStripMenuItem_Click);
            // 
            // applianceTypeSearchToolStripMenuItem
            // 
            this.applianceTypeSearchToolStripMenuItem.Name = "applianceTypeSearchToolStripMenuItem";
            this.applianceTypeSearchToolStripMenuItem.Size = new System.Drawing.Size(12, 29);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.comboApplianceType);
            this.groupBox2.Controls.Add(this.comboPowerUsage);
            this.groupBox2.Controls.Add(this.comboApplianceName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.rdoSearchApplianceType);
            this.groupBox2.Controls.Add(this.rdoSearchPowerUsage);
            this.groupBox2.Controls.Add(this.rdoApplianceName);
            this.groupBox2.Location = new System.Drawing.Point(12, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1083, 161);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Appliance :";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(918, 66);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(126, 50);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // comboApplianceType
            // 
            this.comboApplianceType.FormattingEnabled = true;
            this.comboApplianceType.Location = new System.Drawing.Point(634, 77);
            this.comboApplianceType.Name = "comboApplianceType";
            this.comboApplianceType.Size = new System.Drawing.Size(228, 30);
            this.comboApplianceType.TabIndex = 8;
            // 
            // comboPowerUsage
            // 
            this.comboPowerUsage.FormattingEnabled = true;
            this.comboPowerUsage.Location = new System.Drawing.Point(338, 77);
            this.comboPowerUsage.Name = "comboPowerUsage";
            this.comboPowerUsage.Size = new System.Drawing.Size(228, 30);
            this.comboPowerUsage.TabIndex = 7;
            // 
            // comboApplianceName
            // 
            this.comboApplianceName.FormattingEnabled = true;
            this.comboApplianceName.Location = new System.Drawing.Point(19, 77);
            this.comboApplianceName.Name = "comboApplianceName";
            this.comboApplianceName.Size = new System.Drawing.Size(228, 30);
            this.comboApplianceName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(630, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Appliance Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "PowerUsage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Appliance Name";
            // 
            // rdoSearchApplianceType
            // 
            this.rdoSearchApplianceType.AutoSize = true;
            this.rdoSearchApplianceType.Location = new System.Drawing.Point(634, 113);
            this.rdoSearchApplianceType.Name = "rdoSearchApplianceType";
            this.rdoSearchApplianceType.Size = new System.Drawing.Size(246, 26);
            this.rdoSearchApplianceType.TabIndex = 2;
            this.rdoSearchApplianceType.TabStop = true;
            this.rdoSearchApplianceType.Text = "Search By Appliance Type";
            this.rdoSearchApplianceType.UseVisualStyleBackColor = true;
            // 
            // rdoSearchPowerUsage
            // 
            this.rdoSearchPowerUsage.AutoSize = true;
            this.rdoSearchPowerUsage.Location = new System.Drawing.Point(335, 113);
            this.rdoSearchPowerUsage.Name = "rdoSearchPowerUsage";
            this.rdoSearchPowerUsage.Size = new System.Drawing.Size(231, 26);
            this.rdoSearchPowerUsage.TabIndex = 1;
            this.rdoSearchPowerUsage.TabStop = true;
            this.rdoSearchPowerUsage.Text = "Search By Power Usage ";
            this.rdoSearchPowerUsage.UseVisualStyleBackColor = true;
            // 
            // rdoApplianceName
            // 
            this.rdoApplianceName.AutoSize = true;
            this.rdoApplianceName.Location = new System.Drawing.Point(17, 113);
            this.rdoApplianceName.Name = "rdoApplianceName";
            this.rdoApplianceName.Size = new System.Drawing.Size(258, 26);
            this.rdoApplianceName.TabIndex = 0;
            this.rdoApplianceName.TabStop = true;
            this.rdoApplianceName.Text = "Search By Appliance Name ";
            this.rdoApplianceName.UseVisualStyleBackColor = true;
            // 
            // UserApplianceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 657);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UserApplianceView";
            this.Text = "UserApplianceView";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppliances)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvAppliances;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applianceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applianceTypeSearchToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoSearchApplianceType;
        private System.Windows.Forms.RadioButton rdoSearchPowerUsage;
        private System.Windows.Forms.RadioButton rdoApplianceName;
        private System.Windows.Forms.Button btnSearchAll;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox comboApplianceType;
        private System.Windows.Forms.ComboBox comboPowerUsage;
        private System.Windows.Forms.ComboBox comboApplianceName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSortASCPowerUsage;
        private System.Windows.Forms.Button btnDESCSortPowerUsage;
        private System.Windows.Forms.Button btnSortASCApplianceName;
        private System.Windows.Forms.Button btnSortApplianceNameDESC;
        private System.Windows.Forms.Button btnSortApplianceTypeDESC;
        private System.Windows.Forms.Button btnSortApplianceTypeASC;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}