namespace Rental_System
{
    partial class AdminApplianceType
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApplianceTypeID = new System.Windows.Forms.TextBox();
            this.txtApplianceType = new System.Windows.Forms.TextBox();
            this.txtCategories = new System.Windows.Forms.TextBox();
            this.dgvAppliancetype = new System.Windows.Forms.DataGridView();
            this.lblAppliacnceTypeNameErr = new System.Windows.Forms.Label();
            this.lblcatErr = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.applianceSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppliancetype)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Appliance Type ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Appliance Type :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Categories :";
            // 
            // txtApplianceTypeID
            // 
            this.txtApplianceTypeID.Location = new System.Drawing.Point(182, 35);
            this.txtApplianceTypeID.Name = "txtApplianceTypeID";
            this.txtApplianceTypeID.ReadOnly = true;
            this.txtApplianceTypeID.Size = new System.Drawing.Size(193, 30);
            this.txtApplianceTypeID.TabIndex = 7;
            // 
            // txtApplianceType
            // 
            this.txtApplianceType.Location = new System.Drawing.Point(184, 99);
            this.txtApplianceType.Name = "txtApplianceType";
            this.txtApplianceType.Size = new System.Drawing.Size(191, 30);
            this.txtApplianceType.TabIndex = 8;
            // 
            // txtCategories
            // 
            this.txtCategories.Location = new System.Drawing.Point(184, 171);
            this.txtCategories.Name = "txtCategories";
            this.txtCategories.Size = new System.Drawing.Size(191, 30);
            this.txtCategories.TabIndex = 9;
            // 
            // dgvAppliancetype
            // 
            this.dgvAppliancetype.AllowUserToAddRows = false;
            this.dgvAppliancetype.AllowUserToDeleteRows = false;
            this.dgvAppliancetype.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppliancetype.Location = new System.Drawing.Point(12, 322);
            this.dgvAppliancetype.Name = "dgvAppliancetype";
            this.dgvAppliancetype.ReadOnly = true;
            this.dgvAppliancetype.RowTemplate.Height = 28;
            this.dgvAppliancetype.Size = new System.Drawing.Size(396, 179);
            this.dgvAppliancetype.TabIndex = 14;
            this.dgvAppliancetype.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAppliancetype_CellMouseClick);
            // 
            // lblAppliacnceTypeNameErr
            // 
            this.lblAppliacnceTypeNameErr.AutoSize = true;
            this.lblAppliacnceTypeNameErr.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppliacnceTypeNameErr.ForeColor = System.Drawing.Color.Red;
            this.lblAppliacnceTypeNameErr.Location = new System.Drawing.Point(100, 132);
            this.lblAppliacnceTypeNameErr.Name = "lblAppliacnceTypeNameErr";
            this.lblAppliacnceTypeNameErr.Size = new System.Drawing.Size(298, 22);
            this.lblAppliacnceTypeNameErr.TabIndex = 16;
            this.lblAppliacnceTypeNameErr.Text = "(Appliance Type Name is required!)";
            // 
            // lblcatErr
            // 
            this.lblcatErr.AutoSize = true;
            this.lblcatErr.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcatErr.ForeColor = System.Drawing.Color.Red;
            this.lblcatErr.Location = new System.Drawing.Point(159, 204);
            this.lblcatErr.Name = "lblcatErr";
            this.lblcatErr.Size = new System.Drawing.Size(206, 22);
            this.lblcatErr.TabIndex = 17;
            this.lblcatErr.Text = "(Categories is required!)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblcatErr);
            this.groupBox1.Controls.Add(this.txtApplianceTypeID);
            this.groupBox1.Controls.Add(this.lblAppliacnceTypeNameErr);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtApplianceType);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCategories);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 280);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appliance Type Detail :";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(301, 236);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(77, 32);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "&Detele";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(220, 236);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(77, 32);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(138, 236);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 32);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(57, 235);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(77, 32);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.applianceSearchToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(422, 33);
            this.menuStrip2.TabIndex = 19;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(73, 29);
            this.toolStripMenuItem1.Text = "Home";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(144, 29);
            this.toolStripMenuItem2.Text = "Appliance Type";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(102, 29);
            this.toolStripMenuItem3.Text = "Appliance";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // applianceSearchToolStripMenuItem
            // 
            this.applianceSearchToolStripMenuItem.Name = "applianceSearchToolStripMenuItem";
            this.applianceSearchToolStripMenuItem.Size = new System.Drawing.Size(76, 29);
            this.applianceSearchToolStripMenuItem.Text = "Search";
            this.applianceSearchToolStripMenuItem.Click += new System.EventHandler(this.applianceSearchToolStripMenuItem_Click);
            // 
            // AdminApplianceType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 512);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvAppliancetype);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AdminApplianceType";
            this.Text = "AdminApplianceType";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppliancetype)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApplianceTypeID;
        private System.Windows.Forms.TextBox txtApplianceType;
        private System.Windows.Forms.TextBox txtCategories;
        private System.Windows.Forms.DataGridView dgvAppliancetype;
        private System.Windows.Forms.Label lblAppliacnceTypeNameErr;
        private System.Windows.Forms.Label lblcatErr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem applianceSearchToolStripMenuItem;
    }
}