using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rental_System
{
    public partial class AdminHome : Form
    {
        RentalSystem_DataSetTableAdapters.UsersTableAdapter dsUser = new RentalSystem_DataSetTableAdapters.UsersTableAdapter();
        public AdminHome()
        {
            InitializeComponent();
            getinfo();
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

        private void applianceSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminSearch AS = new AdminSearch();
            AS.Show();
            this.Hide();
        }

        private void myCol()
        {
            dgvUsers.Columns.Add("UserID", "UserID");
            dgvUsers.Columns.Add("Name", "Name");

            dgvUsers.Columns.Add("UserName", "UserName");
            dgvUsers.Columns.Add("Email", "Email");

            dgvUsers.Columns.Add("Phone", "Phone");
            dgvUsers.Columns.Add("Gender", "Gender");
            dgvUsers.Columns.Add("Address", "Address");
        }

        private void getinfo()
        {
            DataTable dt = new DataTable();
            dt = dsUser.GetData();
            myCol();

            for (int i = 0; i < dt.Rows.Count;i++ )
            {
                DataGridViewRow row = new DataGridViewRow();

                row.CreateCells(dgvUsers);
                row.Cells[0].Value = dt.Rows[i]["UserID"].ToString();
                row.Cells[1].Value = dt.Rows[i]["Name"].ToString();
                row.Cells[2].Value = dt.Rows[i]["UserName"].ToString();
                row.Cells[3].Value = dt.Rows[i]["Email"].ToString();
                row.Cells[4].Value = dt.Rows[i]["Phone"].ToString();

                row.Cells[5].Value = dt.Rows[i]["Gender"].ToString();
                row.Cells[6].Value = dt.Rows[i]["Address"].ToString();

                dgvUsers.Rows.Add(row);
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            AdminLogin AL = new AdminLogin();
            AL.Show();
            this.Hide();
        }

        
    }
}
