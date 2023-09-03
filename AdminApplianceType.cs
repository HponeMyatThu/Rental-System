using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rental_System.Model;

namespace Rental_System
{
    public partial class AdminApplianceType : Form
    {
        RentalSystem_DataSetTableAdapters.ApplianceTypeTableAdapter objAtype = new RentalSystem_DataSetTableAdapters.ApplianceTypeTableAdapter();
        DataTable dtAtype = new System.Data.DataTable();

        public AdminApplianceType()
        {
            InitializeComponent();
            FormHelper.ApplianceType.SetFormSize(this);
            Empty.FalseVisible.ApplianceTypeFV.falseVisible(lblAppliacnceTypeNameErr,lblcatErr);

            dtAtype = objAtype.GetDataWithStatusZERO();
            dgvAppliancetype.DataSource = dtAtype;
            dgvAppliancetype.Refresh();

            txtApplianceTypeID.Text = IDHelper.ApplianceTypeLastID.GetAutoID();

            btnEnable();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminHome AH = new AdminHome();
            AH.Show();
            this.Hide();
        }

        private void applianceTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminApplianceType AAT = new AdminApplianceType();
            AAT.Show();
            this.Hide();
        }

        private void applianceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminAppliance AA = new AdminAppliance();
            AA.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Empty.ApplianceTypeEmpty.requireTxt(txtApplianceType, lblAppliacnceTypeNameErr, txtCategories, lblcatErr);
            Service.ApplianceTypeImp.InsertData(txtApplianceTypeID, txtApplianceType, txtCategories);

            dtAtype = objAtype.GetDataWithStatusZERO();
            dgvAppliancetype.DataSource = dtAtype;
            dgvAppliancetype.Refresh();
            btnEnable();
        }

        private void dgvAppliancetype_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = this.dgvAppliancetype.Rows[e.RowIndex];

            txtApplianceTypeID.Text = row.Cells[0].Value.ToString();
            txtApplianceType.Text = row.Cells[1].Value.ToString();
            txtCategories.Text = row.Cells[2].Value.ToString();

            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Empty.ApplianceTypeEmpty.requireTxt(txtApplianceType, lblAppliacnceTypeNameErr, txtCategories, lblcatErr);
            Service.ApplianceTypeImp.updateData(txtApplianceType, txtCategories, txtApplianceTypeID);
            refresh_UD();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { txtApplianceTypeID, txtApplianceType, txtCategories };
            ClearBox.Clear.ClearTextBoxes(textBoxes);
            txtApplianceTypeID.Text = IDHelper.ApplianceTypeLastID.GetAutoID();
            btnEnable();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Service.ApplianceTypeImp.deleteData(txtApplianceTypeID);

            TextBox[] textBoxes = { txtApplianceTypeID, txtApplianceType, txtCategories };
            ClearBox.Clear.ClearTextBoxes(textBoxes);
            txtApplianceTypeID.Text = IDHelper.ApplianceTypeLastID.GetAutoID();
            refresh_UD();
           
        }
        private void refresh_UD()
        {
            dtAtype = objAtype.GetDataWithStatusZERO();
            dgvAppliancetype.DataSource = dtAtype;
            dgvAppliancetype.Refresh();
            btnEnable();
        }
        private void btnEnable()
        {
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AdminHome AH = new AdminHome();
            AH.Show();
            this.Hide();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AdminApplianceType AAT = new AdminApplianceType();
            AAT.Show();
            this.Hide();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AdminAppliance AA = new AdminAppliance();
            AA.Show();
            this.Hide();
        }

        private void applianceSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminSearch AS = new AdminSearch();
            AS.Show();
            this.Hide();
        }
       

        
    }
}
