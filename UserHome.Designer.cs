namespace Rental_System
{
    partial class UserHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserHome));
            this.Appliance = new System.Windows.Forms.GroupBox();
            this.comboBoxApplianceType = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApplianceID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PicBox = new System.Windows.Forms.PictureBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtPowerUsage = new System.Windows.Forms.TextBox();
            this.comboApplianceName = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnChancel = new System.Windows.Forms.Button();
            this.dgvRent = new System.Windows.Forms.DataGridView();
            this.btnRent = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.RentalDetail = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRentDate = new System.Windows.Forms.DateTimePicker();
            this.txtDueDate = new System.Windows.Forms.DateTimePicker();
            this.comboBorrowPeriod = new System.Windows.Forms.ComboBox();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.txtTotalAppliance = new System.Windows.Forms.TextBox();
            this.txtRentID = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applianceSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.Appliance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRent)).BeginInit();
            this.RentalDetail.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Appliance
            // 
            this.Appliance.Controls.Add(this.comboBoxApplianceType);
            this.Appliance.Controls.Add(this.label14);
            this.Appliance.Controls.Add(this.btnClear);
            this.Appliance.Controls.Add(this.label15);
            this.Appliance.Controls.Add(this.txtPrice);
            this.Appliance.Controls.Add(this.btnAdd);
            this.Appliance.Controls.Add(this.label7);
            this.Appliance.Controls.Add(this.label6);
            this.Appliance.Controls.Add(this.label5);
            this.Appliance.Controls.Add(this.label4);
            this.Appliance.Controls.Add(this.txtApplianceID);
            this.Appliance.Controls.Add(this.label3);
            this.Appliance.Controls.Add(this.PicBox);
            this.Appliance.Controls.Add(this.txtBrand);
            this.Appliance.Controls.Add(this.txtPowerUsage);
            this.Appliance.Controls.Add(this.comboApplianceName);
            this.Appliance.Location = new System.Drawing.Point(12, 36);
            this.Appliance.Name = "Appliance";
            this.Appliance.Size = new System.Drawing.Size(310, 391);
            this.Appliance.TabIndex = 0;
            this.Appliance.TabStop = false;
            this.Appliance.Text = "Appliance Detail";
            // 
            // comboBoxApplianceType
            // 
            this.comboBoxApplianceType.FormattingEnabled = true;
            this.comboBoxApplianceType.Location = new System.Drawing.Point(165, 28);
            this.comboBoxApplianceType.Name = "comboBoxApplianceType";
            this.comboBoxApplianceType.Size = new System.Drawing.Size(121, 27);
            this.comboBoxApplianceType.TabIndex = 15;
            this.comboBoxApplianceType.SelectedIndexChanged += new System.EventHandler(this.comboBoxApplianceType_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(152, 19);
            this.label14.TabIndex = 14;
            this.label14.Text = "Search Appliance Type:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(41, 340);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 39);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 265);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 19);
            this.label15.TabIndex = 11;
            this.label15.Text = "Appliance Image :";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(141, 217);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(145, 26);
            this.txtPrice.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(167, 340);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 39);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Price :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Brand :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Power Usage :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Appliance ID :";
            // 
            // txtApplianceID
            // 
            this.txtApplianceID.Location = new System.Drawing.Point(141, 105);
            this.txtApplianceID.Name = "txtApplianceID";
            this.txtApplianceID.ReadOnly = true;
            this.txtApplianceID.Size = new System.Drawing.Size(145, 26);
            this.txtApplianceID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Appliance Name :";
            // 
            // PicBox
            // 
            this.PicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicBox.Image = ((System.Drawing.Image)(resources.GetObject("PicBox.Image")));
            this.PicBox.Location = new System.Drawing.Point(141, 251);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(145, 79);
            this.PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBox.TabIndex = 4;
            this.PicBox.TabStop = false;
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(141, 182);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.ReadOnly = true;
            this.txtBrand.Size = new System.Drawing.Size(145, 26);
            this.txtBrand.TabIndex = 3;
            // 
            // txtPowerUsage
            // 
            this.txtPowerUsage.Location = new System.Drawing.Point(141, 144);
            this.txtPowerUsage.Name = "txtPowerUsage";
            this.txtPowerUsage.ReadOnly = true;
            this.txtPowerUsage.Size = new System.Drawing.Size(145, 26);
            this.txtPowerUsage.TabIndex = 2;
            // 
            // comboApplianceName
            // 
            this.comboApplianceName.FormattingEnabled = true;
            this.comboApplianceName.Location = new System.Drawing.Point(141, 64);
            this.comboApplianceName.Name = "comboApplianceName";
            this.comboApplianceName.Size = new System.Drawing.Size(145, 27);
            this.comboApplianceName.TabIndex = 0;
            this.comboApplianceName.SelectedIndexChanged += new System.EventHandler(this.comboApplianceName_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtUserName);
            this.groupBox2.Controls.Add(this.txtUserID);
            this.groupBox2.Location = new System.Drawing.Point(12, 445);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 105);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Profile (or) User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "User Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "User ID :";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(130, 62);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(145, 26);
            this.txtUserName.TabIndex = 1;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(130, 21);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(145, 26);
            this.txtUserID.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnChancel);
            this.groupBox3.Controls.Add(this.dgvRent);
            this.groupBox3.Controls.Add(this.btnRent);
            this.groupBox3.Location = new System.Drawing.Point(328, 271);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(623, 279);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cart Detail";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnChancel
            // 
            this.btnChancel.Location = new System.Drawing.Point(350, 226);
            this.btnChancel.Name = "btnChancel";
            this.btnChancel.Size = new System.Drawing.Size(119, 39);
            this.btnChancel.TabIndex = 16;
            this.btnChancel.Text = "&Chancel";
            this.btnChancel.UseVisualStyleBackColor = true;
            this.btnChancel.Click += new System.EventHandler(this.btnChancel_Click);
            // 
            // dgvRent
            // 
            this.dgvRent.AllowUserToAddRows = false;
            this.dgvRent.AllowUserToDeleteRows = false;
            this.dgvRent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRent.Location = new System.Drawing.Point(6, 25);
            this.dgvRent.Name = "dgvRent";
            this.dgvRent.ReadOnly = true;
            this.dgvRent.RowTemplate.Height = 28;
            this.dgvRent.Size = new System.Drawing.Size(610, 189);
            this.dgvRent.TabIndex = 0;
            this.dgvRent.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRent_CellMouseClick);
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(476, 226);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(119, 39);
            this.btnRent.TabIndex = 12;
            this.btnRent.Text = "&Rent";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(350, 169);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(119, 39);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // RentalDetail
            // 
            this.RentalDetail.Controls.Add(this.btnUpdate);
            this.RentalDetail.Controls.Add(this.btnRemove);
            this.RentalDetail.Controls.Add(this.label13);
            this.RentalDetail.Controls.Add(this.label12);
            this.RentalDetail.Controls.Add(this.label11);
            this.RentalDetail.Controls.Add(this.label10);
            this.RentalDetail.Controls.Add(this.label9);
            this.RentalDetail.Controls.Add(this.label8);
            this.RentalDetail.Controls.Add(this.txtRentDate);
            this.RentalDetail.Controls.Add(this.txtDueDate);
            this.RentalDetail.Controls.Add(this.comboBorrowPeriod);
            this.RentalDetail.Controls.Add(this.txtGrandTotal);
            this.RentalDetail.Controls.Add(this.txtTotalAppliance);
            this.RentalDetail.Controls.Add(this.txtRentID);
            this.RentalDetail.Location = new System.Drawing.Point(328, 37);
            this.RentalDetail.Name = "RentalDetail";
            this.RentalDetail.Size = new System.Drawing.Size(623, 225);
            this.RentalDetail.TabIndex = 3;
            this.RentalDetail.TabStop = false;
            this.RentalDetail.Text = "Rent Detail";
            this.RentalDetail.Enter += new System.EventHandler(this.RentalDetail_Enter);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(476, 169);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(119, 39);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(346, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 19);
            this.label13.TabIndex = 14;
            this.label13.Text = "Grand Total :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(324, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 19);
            this.label12.TabIndex = 13;
            this.label12.Text = "Total Appliance :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(327, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 19);
            this.label11.TabIndex = 12;
            this.label11.Text = "Rent Period :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 19);
            this.label10.TabIndex = 11;
            this.label10.Text = "Due Date :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 19);
            this.label9.TabIndex = 10;
            this.label9.Text = "Rent Date : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Rent ID :";
            // 
            // txtRentDate
            // 
            this.txtRentDate.Location = new System.Drawing.Point(128, 81);
            this.txtRentDate.Name = "txtRentDate";
            this.txtRentDate.Size = new System.Drawing.Size(145, 26);
            this.txtRentDate.TabIndex = 6;
            // 
            // txtDueDate
            // 
            this.txtDueDate.Location = new System.Drawing.Point(127, 129);
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.Size = new System.Drawing.Size(145, 26);
            this.txtDueDate.TabIndex = 5;
            // 
            // comboBorrowPeriod
            // 
            this.comboBorrowPeriod.FormattingEnabled = true;
            this.comboBorrowPeriod.Items.AddRange(new object[] {
            "Choose Rent Period",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBorrowPeriod.Location = new System.Drawing.Point(440, 29);
            this.comboBorrowPeriod.Name = "comboBorrowPeriod";
            this.comboBorrowPeriod.Size = new System.Drawing.Size(145, 27);
            this.comboBorrowPeriod.TabIndex = 4;
            this.comboBorrowPeriod.SelectedIndexChanged += new System.EventHandler(this.comboBorrowPeriod_SelectedIndexChanged);
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Location = new System.Drawing.Point(440, 130);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.ReadOnly = true;
            this.txtGrandTotal.Size = new System.Drawing.Size(145, 26);
            this.txtGrandTotal.TabIndex = 2;
            // 
            // txtTotalAppliance
            // 
            this.txtTotalAppliance.Location = new System.Drawing.Point(440, 81);
            this.txtTotalAppliance.Name = "txtTotalAppliance";
            this.txtTotalAppliance.ReadOnly = true;
            this.txtTotalAppliance.Size = new System.Drawing.Size(145, 26);
            this.txtTotalAppliance.TabIndex = 1;
            // 
            // txtRentID
            // 
            this.txtRentID.Location = new System.Drawing.Point(128, 32);
            this.txtRentID.Name = "txtRentID";
            this.txtRentID.ReadOnly = true;
            this.txtRentID.Size = new System.Drawing.Size(145, 26);
            this.txtRentID.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.applianceSearchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(963, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // applianceSearchToolStripMenuItem
            // 
            this.applianceSearchToolStripMenuItem.Name = "applianceSearchToolStripMenuItem";
            this.applianceSearchToolStripMenuItem.Size = new System.Drawing.Size(159, 29);
            this.applianceSearchToolStripMenuItem.Text = "Appliance Search";
            this.applianceSearchToolStripMenuItem.Click += new System.EventHandler(this.applianceSearchToolStripMenuItem_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(866, 0);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(97, 31);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // UserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 560);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.RentalDetail);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Appliance);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserHome";
            this.Text = "UserHome";
            this.Appliance.ResumeLayout(false);
            this.Appliance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRent)).EndInit();
            this.RentalDetail.ResumeLayout(false);
            this.RentalDetail.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Appliance;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox RentalDetail;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApplianceID;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox PicBox;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtPowerUsage;
        private System.Windows.Forms.ComboBox comboApplianceName;
        private System.Windows.Forms.DataGridView dgvRent;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker txtRentDate;
        private System.Windows.Forms.DateTimePicker txtDueDate;
        private System.Windows.Forms.ComboBox comboBorrowPeriod;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.TextBox txtTotalAppliance;
        private System.Windows.Forms.TextBox txtRentID;
        private System.Windows.Forms.Button btnChancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox comboBoxApplianceType;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applianceSearchToolStripMenuItem;
        private System.Windows.Forms.Button btnLogOut;

    }
}