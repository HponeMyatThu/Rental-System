namespace Rental_System
{
    partial class Start_RentalSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start_RentalSystem));
            this.User = new System.Windows.Forms.PictureBox();
            this.Admin = new System.Windows.Forms.PictureBox();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Admin)).BeginInit();
            this.SuspendLayout();
            // 
            // User
            // 
            this.User.Image = ((System.Drawing.Image)(resources.GetObject("User.Image")));
            this.User.Location = new System.Drawing.Point(209, 165);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(225, 225);
            this.User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.User.TabIndex = 0;
            this.User.TabStop = false;
            this.User.Click += new System.EventHandler(this.User_Click);
            // 
            // Admin
            // 
            this.Admin.Image = ((System.Drawing.Image)(resources.GetObject("Admin.Image")));
            this.Admin.Location = new System.Drawing.Point(458, 165);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(225, 225);
            this.Admin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Admin.TabIndex = 1;
            this.Admin.TabStop = false;
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(209, 396);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(225, 42);
            this.btnUser.TabIndex = 2;
            this.btnUser.Text = "Login As User";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(458, 396);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(225, 42);
            this.btnAdmin.TabIndex = 3;
            this.btnAdmin.Text = "Login As Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // Start_RentalSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 615);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.User);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Start_RentalSystem";
            this.Text = "Start_RentalSystem";
            ((System.ComponentModel.ISupportInitialize)(this.User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Admin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox User;
        private System.Windows.Forms.PictureBox Admin;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnAdmin;
    }
}