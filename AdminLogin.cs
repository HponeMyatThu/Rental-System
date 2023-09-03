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
    public partial class AdminLogin : Form
    {
        public static string AdminID, AdminName;
        RentalSystem_DataSetTableAdapters.AdminsTableAdapter AT = new RentalSystem_DataSetTableAdapters.AdminsTableAdapter();
        private int loginCount;

        public AdminLogin()
        {
            InitializeComponent();
            FormHelper.AdminFormHelper.SetLoginFormSize(this);
            Empty.FalseVisible.AdminLoginFV.falseVisible(lblAdminUNameLoginErr,lblAdminPasswordLoginErr);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Empty.AdminLoginEmpty.requireTxt(txtUserNameLogin,lblAdminUNameLoginErr,
                txtPasswordLogin,lblAdminPasswordLoginErr);

            if (loginCount == 3)
            {
                MessageBox.Show("Login Fail for 3 times!...");

            }
            else
            {
                AdminLoginModel alm = new AdminLoginModel();
                alm.UserName = txtUserNameLogin.Text;
                alm.Password = txtPasswordLogin.Text;

                DataTable dt = new DataTable();
                try
                {
                    dt = AT.AdminLogin(alm.UserName, alm.Password);

                    if (dt.Rows.Count == 1)
                    {
                        int status = Convert.ToInt32(dt.Rows[0]["Aprove"]);

                         if (status == 0)
                         {
                             MessageBox.Show("Login Successful");
                             dgvAdminLogin.DataSource = dt;
                             AdminID = dgvAdminLogin[0, 0].Value.ToString();
                             AdminName = dgvAdminLogin[1, 0].Value.ToString();

                             AdminHome ah = new AdminHome();
                             ah.Show();
                             this.Hide();
                         }
                         else
                         {
                             MessageBox.Show("Your account is not approve from default Admin.");
                         }
                    }
                    else
                    {
                        loginCount++;
                        MessageBox.Show("Incorrect Password and UserName");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
            }

        }

        private void lnkRegisterAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin_Register AR = new Admin_Register();
            AR.Show();
            this.Hide();
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            // Toggle password visibility by changing the PasswordChar property
            if (txtPasswordLogin.PasswordChar == '\0') // PasswordChar is set to '\0' when the password is visible
            {
                txtPasswordLogin.PasswordChar = '*'; // Set the password character back to '*'
            }
            else
            {
                txtPasswordLogin.PasswordChar = '\0'; // Set PasswordChar to '\0' to show the password
            }
        }

        
    }
}
