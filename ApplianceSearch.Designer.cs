namespace Rental_System
{
    partial class ApplianceSearch
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applianceTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applianceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applianceSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.applianceTypeToolStripMenuItem,
            this.applianceToolStripMenuItem,
            this.applianceSearchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(813, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // applianceTypeToolStripMenuItem
            // 
            this.applianceTypeToolStripMenuItem.Name = "applianceTypeToolStripMenuItem";
            this.applianceTypeToolStripMenuItem.Size = new System.Drawing.Size(144, 29);
            this.applianceTypeToolStripMenuItem.Text = "Appliance Type";
            // 
            // applianceToolStripMenuItem
            // 
            this.applianceToolStripMenuItem.Name = "applianceToolStripMenuItem";
            this.applianceToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.applianceToolStripMenuItem.Text = "Appliance";
            // 
            // applianceSearchToolStripMenuItem
            // 
            this.applianceSearchToolStripMenuItem.Name = "applianceSearchToolStripMenuItem";
            this.applianceSearchToolStripMenuItem.Size = new System.Drawing.Size(159, 29);
            this.applianceSearchToolStripMenuItem.Text = "Appliance Search";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(13, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 196);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // ApplianceSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 525);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ApplianceSearch";
            this.Text = "RentSearch";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applianceTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applianceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applianceSearchToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}