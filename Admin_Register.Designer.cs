namespace Rental_System
{
    partial class Admin_Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdminID = new System.Windows.Forms.TextBox();
            this.txtAdminName = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvRegister = new System.Windows.Forms.DataGridView();
            this.lnkLoginAdmin = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAddressErr = new System.Windows.Forms.Label();
            this.lblGenderErr = new System.Windows.Forms.Label();
            this.lblPhoneNumberErr = new System.Windows.Forms.Label();
            this.lblPasswordErr = new System.Windows.Forms.Label();
            this.lblEmailErr = new System.Windows.Forms.Label();
            this.lblUserNameErr = new System.Windows.Forms.Label();
            this.lblAdminNameErr = new System.Windows.Forms.Label();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnToggle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Admin Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "User Name :";
            // 
            // txtAdminID
            // 
            this.txtAdminID.Location = new System.Drawing.Point(168, 44);
            this.txtAdminID.Name = "txtAdminID";
            this.txtAdminID.ReadOnly = true;
            this.txtAdminID.Size = new System.Drawing.Size(250, 30);
            this.txtAdminID.TabIndex = 4;
            // 
            // txtAdminName
            // 
            this.txtAdminName.Location = new System.Drawing.Point(168, 117);
            this.txtAdminName.Name = "txtAdminName";
            this.txtAdminName.Size = new System.Drawing.Size(250, 30);
            this.txtAdminName.TabIndex = 5;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(168, 193);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(250, 30);
            this.txtUserName.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnToggle);
            this.groupBox1.Controls.Add(this.dgvRegister);
            this.groupBox1.Controls.Add(this.lnkLoginAdmin);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblAddressErr);
            this.groupBox1.Controls.Add(this.lblGenderErr);
            this.groupBox1.Controls.Add(this.lblPhoneNumberErr);
            this.groupBox1.Controls.Add(this.lblPasswordErr);
            this.groupBox1.Controls.Add(this.lblEmailErr);
            this.groupBox1.Controls.Add(this.lblUserNameErr);
            this.groupBox1.Controls.Add(this.lblAdminNameErr);
            this.groupBox1.Controls.Add(this.rdoFemale);
            this.groupBox1.Controls.Add(this.rdoMale);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnRegister);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAdminName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAdminID);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(889, 436);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Admin Detail";
            // 
            // dgvRegister
            // 
            this.dgvRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegister.Location = new System.Drawing.Point(768, 384);
            this.dgvRegister.Name = "dgvRegister";
            this.dgvRegister.RowTemplate.Height = 28;
            this.dgvRegister.Size = new System.Drawing.Size(28, 31);
            this.dgvRegister.TabIndex = 31;
            this.dgvRegister.Visible = false;
            // 
            // lnkLoginAdmin
            // 
            this.lnkLoginAdmin.AutoSize = true;
            this.lnkLoginAdmin.Location = new System.Drawing.Point(707, 393);
            this.lnkLoginAdmin.Name = "lnkLoginAdmin";
            this.lnkLoginAdmin.Size = new System.Drawing.Size(55, 22);
            this.lnkLoginAdmin.TabIndex = 30;
            this.lnkLoginAdmin.TabStop = true;
            this.lnkLoginAdmin.Text = "Login";
            this.lnkLoginAdmin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLoginAdmin_LinkClicked);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(580, 393);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 22);
            this.label9.TabIndex = 29;
            this.label9.Text = "Have Account ?";
            // 
            // lblAddressErr
            // 
            this.lblAddressErr.AutoSize = true;
            this.lblAddressErr.ForeColor = System.Drawing.Color.Red;
            this.lblAddressErr.Location = new System.Drawing.Point(594, 288);
            this.lblAddressErr.Name = "lblAddressErr";
            this.lblAddressErr.Size = new System.Drawing.Size(187, 22);
            this.lblAddressErr.TabIndex = 28;
            this.lblAddressErr.Text = "(Address is required!)";
            // 
            // lblGenderErr
            // 
            this.lblGenderErr.AutoSize = true;
            this.lblGenderErr.ForeColor = System.Drawing.Color.Red;
            this.lblGenderErr.Location = new System.Drawing.Point(603, 146);
            this.lblGenderErr.Name = "lblGenderErr";
            this.lblGenderErr.Size = new System.Drawing.Size(116, 22);
            this.lblGenderErr.TabIndex = 27;
            this.lblGenderErr.Text = "(Select One!)";
            // 
            // lblPhoneNumberErr
            // 
            this.lblPhoneNumberErr.AutoSize = true;
            this.lblPhoneNumberErr.ForeColor = System.Drawing.Color.Red;
            this.lblPhoneNumberErr.Location = new System.Drawing.Point(175, 374);
            this.lblPhoneNumberErr.Name = "lblPhoneNumberErr";
            this.lblPhoneNumberErr.Size = new System.Drawing.Size(237, 22);
            this.lblPhoneNumberErr.TabIndex = 26;
            this.lblPhoneNumberErr.Text = "(Phone Number is required!)";
            // 
            // lblPasswordErr
            // 
            this.lblPasswordErr.AutoSize = true;
            this.lblPasswordErr.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordErr.Location = new System.Drawing.Point(582, 67);
            this.lblPasswordErr.Name = "lblPasswordErr";
            this.lblPasswordErr.Size = new System.Drawing.Size(199, 22);
            this.lblPasswordErr.TabIndex = 25;
            this.lblPasswordErr.Text = "(Password is required!)";
            // 
            // lblEmailErr
            // 
            this.lblEmailErr.AutoSize = true;
            this.lblEmailErr.ForeColor = System.Drawing.Color.Red;
            this.lblEmailErr.Location = new System.Drawing.Point(205, 298);
            this.lblEmailErr.Name = "lblEmailErr";
            this.lblEmailErr.Size = new System.Drawing.Size(168, 22);
            this.lblEmailErr.TabIndex = 24;
            this.lblEmailErr.Text = "(Email is required!)";
            // 
            // lblUserNameErr
            // 
            this.lblUserNameErr.AutoSize = true;
            this.lblUserNameErr.ForeColor = System.Drawing.Color.Red;
            this.lblUserNameErr.Location = new System.Drawing.Point(187, 225);
            this.lblUserNameErr.Name = "lblUserNameErr";
            this.lblUserNameErr.Size = new System.Drawing.Size(209, 22);
            this.lblUserNameErr.TabIndex = 23;
            this.lblUserNameErr.Text = "(User Name is required!)";
            // 
            // lblAdminNameErr
            // 
            this.lblAdminNameErr.AutoSize = true;
            this.lblAdminNameErr.BackColor = System.Drawing.SystemColors.Menu;
            this.lblAdminNameErr.ForeColor = System.Drawing.Color.Red;
            this.lblAdminNameErr.Location = new System.Drawing.Point(179, 149);
            this.lblAdminNameErr.Name = "lblAdminNameErr";
            this.lblAdminNameErr.Size = new System.Drawing.Size(225, 22);
            this.lblAdminNameErr.TabIndex = 22;
            this.lblAdminNameErr.Text = "(Admin Name is required!)";
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(655, 116);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(93, 26);
            this.rdoFemale.TabIndex = 20;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(566, 117);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(76, 26);
            this.rdoMale.TabIndex = 19;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(586, 331);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 41);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(711, 331);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(119, 41);
            this.btnRegister.TabIndex = 17;
            this.btnRegister.Text = "&Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(559, 177);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(249, 108);
            this.txtAddress.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(463, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Gender :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(463, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 22);
            this.label8.TabIndex = 14;
            this.label8.Text = "Address :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email :";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(166, 342);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(252, 30);
            this.txtPhone.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(451, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password :";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(556, 36);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(252, 30);
            this.txtPassword.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Phone :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(167, 266);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 30);
            this.txtEmail.TabIndex = 10;
            // 
            // btnToggle
            // 
            this.btnToggle.Location = new System.Drawing.Point(814, 37);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(69, 26);
            this.btnToggle.TabIndex = 33;
            this.btnToggle.Text = "show";
            this.btnToggle.UseVisualStyleBackColor = true;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // Admin_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 454);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Admin_Register";
            this.Text = "Admin Register";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegister)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdminID;
        private System.Windows.Forms.TextBox txtAdminName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblAddressErr;
        private System.Windows.Forms.Label lblGenderErr;
        private System.Windows.Forms.Label lblPhoneNumberErr;
        private System.Windows.Forms.Label lblPasswordErr;
        private System.Windows.Forms.Label lblEmailErr;
        private System.Windows.Forms.Label lblUserNameErr;
        private System.Windows.Forms.Label lblAdminNameErr;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.LinkLabel lnkLoginAdmin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvRegister;
        private System.Windows.Forms.Button btnToggle;

    }
}

