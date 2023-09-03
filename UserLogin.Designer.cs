namespace Rental_System
{
    partial class UserLogin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvUserLogin = new System.Windows.Forms.DataGridView();
            this.lblUserPasswordLoginErr = new System.Windows.Forms.Label();
            this.lblUserUNameLoginErr = new System.Windows.Forms.Label();
            this.lnkRegisterAdmin = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPasswordLogin = new System.Windows.Forms.TextBox();
            this.txtUserNameLogin = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnToggle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnToggle);
            this.groupBox1.Controls.Add(this.dgvUserLogin);
            this.groupBox1.Controls.Add(this.lblUserPasswordLoginErr);
            this.groupBox1.Controls.Add(this.lblUserUNameLoginErr);
            this.groupBox1.Controls.Add(this.lnkRegisterAdmin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPasswordLogin);
            this.groupBox1.Controls.Add(this.txtUserNameLogin);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(441, 289);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Login";
            // 
            // dgvUserLogin
            // 
            this.dgvUserLogin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserLogin.Location = new System.Drawing.Point(357, 241);
            this.dgvUserLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvUserLogin.Name = "dgvUserLogin";
            this.dgvUserLogin.RowTemplate.Height = 28;
            this.dgvUserLogin.Size = new System.Drawing.Size(46, 37);
            this.dgvUserLogin.TabIndex = 9;
            this.dgvUserLogin.Visible = false;
            // 
            // lblUserPasswordLoginErr
            // 
            this.lblUserPasswordLoginErr.AutoSize = true;
            this.lblUserPasswordLoginErr.ForeColor = System.Drawing.Color.Red;
            this.lblUserPasswordLoginErr.Location = new System.Drawing.Point(167, 153);
            this.lblUserPasswordLoginErr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserPasswordLoginErr.Name = "lblUserPasswordLoginErr";
            this.lblUserPasswordLoginErr.Size = new System.Drawing.Size(199, 22);
            this.lblUserPasswordLoginErr.TabIndex = 8;
            this.lblUserPasswordLoginErr.Text = "(Password is required!)";
            // 
            // lblUserUNameLoginErr
            // 
            this.lblUserUNameLoginErr.AutoSize = true;
            this.lblUserUNameLoginErr.ForeColor = System.Drawing.Color.Red;
            this.lblUserUNameLoginErr.Location = new System.Drawing.Point(167, 76);
            this.lblUserUNameLoginErr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserUNameLoginErr.Name = "lblUserUNameLoginErr";
            this.lblUserUNameLoginErr.Size = new System.Drawing.Size(204, 22);
            this.lblUserUNameLoginErr.TabIndex = 7;
            this.lblUserUNameLoginErr.Text = "(UserName is required!)";
            // 
            // lnkRegisterAdmin
            // 
            this.lnkRegisterAdmin.AutoSize = true;
            this.lnkRegisterAdmin.Location = new System.Drawing.Point(220, 254);
            this.lnkRegisterAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkRegisterAdmin.Name = "lnkRegisterAdmin";
            this.lnkRegisterAdmin.Size = new System.Drawing.Size(81, 22);
            this.lnkRegisterAdmin.TabIndex = 6;
            this.lnkRegisterAdmin.TabStop = true;
            this.lnkRegisterAdmin.Text = " Register";
            this.lnkRegisterAdmin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRegisterAdmin_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(44, 254);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Don\'t Have Account ?";
            // 
            // txtPasswordLogin
            // 
            this.txtPasswordLogin.Location = new System.Drawing.Point(166, 118);
            this.txtPasswordLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.PasswordChar = '*';
            this.txtPasswordLogin.Size = new System.Drawing.Size(205, 30);
            this.txtPasswordLogin.TabIndex = 4;
            // 
            // txtUserNameLogin
            // 
            this.txtUserNameLogin.Location = new System.Drawing.Point(166, 41);
            this.txtUserNameLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUserNameLogin.Name = "txtUserNameLogin";
            this.txtUserNameLogin.Size = new System.Drawing.Size(246, 30);
            this.txtUserNameLogin.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(49, 191);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(354, 42);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "&Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName:";
            // 
            // btnToggle
            // 
            this.btnToggle.Location = new System.Drawing.Point(372, 118);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(69, 26);
            this.btnToggle.TabIndex = 33;
            this.btnToggle.Text = "show";
            this.btnToggle.UseVisualStyleBackColor = true;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 317);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UserLogin";
            this.Text = "UserLogin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvUserLogin;
        private System.Windows.Forms.Label lblUserPasswordLoginErr;
        private System.Windows.Forms.Label lblUserUNameLoginErr;
        private System.Windows.Forms.LinkLabel lnkRegisterAdmin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPasswordLogin;
        private System.Windows.Forms.TextBox txtUserNameLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnToggle;
    }
}