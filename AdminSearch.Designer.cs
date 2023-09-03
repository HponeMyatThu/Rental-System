namespace Rental_System
{
    partial class AdminSearch
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
            this.Search = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtFromDate = new System.Windows.Forms.DateTimePicker();
            this.comboApplianceID = new System.Windows.Forms.ComboBox();
            this.comboRentID = new System.Windows.Forms.ComboBox();
            this.comboUserID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoDate = new System.Windows.Forms.RadioButton();
            this.rdoApplianceID = new System.Windows.Forms.RadioButton();
            this.rdoRentID = new System.Windows.Forms.RadioButton();
            this.rdoUserID = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSortByDateASC = new System.Windows.Forms.Button();
            this.btnSortASCUserID = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applianceTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applianceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applianceSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.Search.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Controls.Add(this.btnSearch);
            this.Search.Controls.Add(this.txtFromDate);
            this.Search.Controls.Add(this.comboApplianceID);
            this.Search.Controls.Add(this.comboRentID);
            this.Search.Controls.Add(this.comboUserID);
            this.Search.Controls.Add(this.label4);
            this.Search.Controls.Add(this.label3);
            this.Search.Controls.Add(this.label2);
            this.Search.Controls.Add(this.label1);
            this.Search.Controls.Add(this.rdoDate);
            this.Search.Controls.Add(this.rdoApplianceID);
            this.Search.Controls.Add(this.rdoRentID);
            this.Search.Controls.Add(this.rdoUserID);
            this.Search.Location = new System.Drawing.Point(12, 58);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(1220, 165);
            this.Search.TabIndex = 0;
            this.Search.TabStop = false;
            this.Search.Text = "Search ";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1084, 55);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 69);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(779, 79);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(299, 30);
            this.txtFromDate.TabIndex = 12;
            // 
            // comboApplianceID
            // 
            this.comboApplianceID.FormattingEnabled = true;
            this.comboApplianceID.Location = new System.Drawing.Point(529, 82);
            this.comboApplianceID.Name = "comboApplianceID";
            this.comboApplianceID.Size = new System.Drawing.Size(179, 30);
            this.comboApplianceID.TabIndex = 11;
            // 
            // comboRentID
            // 
            this.comboRentID.FormattingEnabled = true;
            this.comboRentID.Location = new System.Drawing.Point(285, 82);
            this.comboRentID.Name = "comboRentID";
            this.comboRentID.Size = new System.Drawing.Size(179, 30);
            this.comboRentID.TabIndex = 10;
            // 
            // comboUserID
            // 
            this.comboUserID.FormattingEnabled = true;
            this.comboUserID.Location = new System.Drawing.Point(40, 82);
            this.comboUserID.Name = "comboUserID";
            this.comboUserID.Size = new System.Drawing.Size(179, 30);
            this.comboUserID.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(775, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rent Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Appliance ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rent ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "User ID";
            // 
            // rdoDate
            // 
            this.rdoDate.AutoSize = true;
            this.rdoDate.Location = new System.Drawing.Point(779, 118);
            this.rdoDate.Name = "rdoDate";
            this.rdoDate.Size = new System.Drawing.Size(158, 26);
            this.rdoDate.TabIndex = 3;
            this.rdoDate.TabStop = true;
            this.rdoDate.Text = "Search By Date";
            this.rdoDate.UseVisualStyleBackColor = true;
            // 
            // rdoApplianceID
            // 
            this.rdoApplianceID.AutoSize = true;
            this.rdoApplianceID.Location = new System.Drawing.Point(529, 118);
            this.rdoApplianceID.Name = "rdoApplianceID";
            this.rdoApplianceID.Size = new System.Drawing.Size(227, 26);
            this.rdoApplianceID.TabIndex = 2;
            this.rdoApplianceID.TabStop = true;
            this.rdoApplianceID.Text = "Search By Appliance ID";
            this.rdoApplianceID.UseVisualStyleBackColor = true;
            // 
            // rdoRentID
            // 
            this.rdoRentID.AutoSize = true;
            this.rdoRentID.Location = new System.Drawing.Point(282, 118);
            this.rdoRentID.Name = "rdoRentID";
            this.rdoRentID.Size = new System.Drawing.Size(182, 26);
            this.rdoRentID.TabIndex = 1;
            this.rdoRentID.TabStop = true;
            this.rdoRentID.Text = "Search By Rent ID";
            this.rdoRentID.UseVisualStyleBackColor = true;
            // 
            // rdoUserID
            // 
            this.rdoUserID.AutoSize = true;
            this.rdoUserID.Location = new System.Drawing.Point(36, 118);
            this.rdoUserID.Name = "rdoUserID";
            this.rdoUserID.Size = new System.Drawing.Size(183, 26);
            this.rdoUserID.TabIndex = 0;
            this.rdoUserID.TabStop = true;
            this.rdoUserID.Text = "Search By User ID";
            this.rdoUserID.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSortByDateASC);
            this.groupBox2.Controls.Add(this.btnSortASCUserID);
            this.groupBox2.Controls.Add(this.btnShowAll);
            this.groupBox2.Controls.Add(this.dgvAdmin);
            this.groupBox2.Location = new System.Drawing.Point(12, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1220, 429);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "History";
            // 
            // btnSortByDateASC
            // 
            this.btnSortByDateASC.Location = new System.Drawing.Point(662, 19);
            this.btnSortByDateASC.Name = "btnSortByDateASC";
            this.btnSortByDateASC.Size = new System.Drawing.Size(236, 61);
            this.btnSortByDateASC.TabIndex = 4;
            this.btnSortByDateASC.Text = "Sort By Appliance ID ASC";
            this.btnSortByDateASC.UseVisualStyleBackColor = true;
            this.btnSortByDateASC.Click += new System.EventHandler(this.btnSortByDateASC_Click);
            // 
            // btnSortASCUserID
            // 
            this.btnSortASCUserID.Location = new System.Drawing.Point(904, 19);
            this.btnSortASCUserID.Name = "btnSortASCUserID";
            this.btnSortASCUserID.Size = new System.Drawing.Size(200, 61);
            this.btnSortASCUserID.TabIndex = 3;
            this.btnSortASCUserID.Text = "Sort By User ID ASC";
            this.btnSortASCUserID.UseVisualStyleBackColor = true;
            this.btnSortASCUserID.Click += new System.EventHandler(this.btnSortASCUserID_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(1110, 19);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(104, 61);
            this.btnShowAll.TabIndex = 1;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.AllowUserToAddRows = false;
            this.dgvAdmin.AllowUserToDeleteRows = false;
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmin.Location = new System.Drawing.Point(6, 86);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.ReadOnly = true;
            this.dgvAdmin.RowTemplate.Height = 28;
            this.dgvAdmin.Size = new System.Drawing.Size(1208, 337);
            this.dgvAdmin.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.applianceTypeToolStripMenuItem,
            this.applianceToolStripMenuItem,
            this.applianceSearchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1244, 33);
            this.menuStrip1.TabIndex = 2;
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
            this.applianceToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.applianceToolStripMenuItem.Text = "Appliance";
            this.applianceToolStripMenuItem.Click += new System.EventHandler(this.applianceToolStripMenuItem_Click);
            // 
            // applianceSearchToolStripMenuItem
            // 
            this.applianceSearchToolStripMenuItem.Name = "applianceSearchToolStripMenuItem";
            this.applianceSearchToolStripMenuItem.Size = new System.Drawing.Size(76, 29);
            this.applianceSearchToolStripMenuItem.Text = "Search";
            this.applianceSearchToolStripMenuItem.Click += new System.EventHandler(this.applianceSearchToolStripMenuItem_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(1142, 0);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(102, 33);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // AdminSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 666);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Search);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AdminSearch";
            this.Text = "AdminSearch";
            this.Search.ResumeLayout(false);
            this.Search.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Search;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker txtFromDate;
        private System.Windows.Forms.ComboBox comboApplianceID;
        private System.Windows.Forms.ComboBox comboRentID;
        private System.Windows.Forms.ComboBox comboUserID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoDate;
        private System.Windows.Forms.RadioButton rdoApplianceID;
        private System.Windows.Forms.RadioButton rdoRentID;
        private System.Windows.Forms.RadioButton rdoUserID;
        private System.Windows.Forms.Button btnSortASCUserID;
        private System.Windows.Forms.Button btnSortByDateASC;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applianceTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applianceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applianceSearchToolStripMenuItem;
        private System.Windows.Forms.Button btnLogOut;
    }
}