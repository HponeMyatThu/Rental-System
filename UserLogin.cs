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
    public partial class UserLogin : Form
    {
        public static string UserID, RealName;
        RentalSystem_DataSetTableAdapters.UsersTableAdapter objUser = new RentalSystem_DataSetTableAdapters.UsersTableAdapter();
        private int loginCount = 0;

        public UserLogin()
        {
            InitializeComponent();
           
            Empty.FalseVisible.UserLoginFV.falseVisible(lblUserUNameLoginErr, lblUserPasswordLoginErr);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Empty.UserLoginEmpty.requireTxt(txtUserNameLogin, lblUserUNameLoginErr, txtPasswordLogin, lblUserPasswordLoginErr);
            if (loginCount == 3)
            {
                MessageBox.Show("Login Fail for 3 times!...");
                //Call update User status
            }
            else
            {
                UserLoginModel ulm = new UserLoginModel();
                ulm.UserName = txtUserNameLogin.Text;
                ulm.Password = txtPasswordLogin.Text;

                DataTable dt = new DataTable();
                dt = objUser.UserLogin(ulm.UserName, ulm.Password);

                dgvUserLogin.Rows.Clear();
                dgvUserLogin.Columns.Clear();

                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Login Successful");
                    dgvUserLogin.DataSource = dt;
                    UserID = dgvUserLogin[0, 0].Value.ToString();
                    RealName = dgvUserLogin[2, 0].Value.ToString();

                    UserHome uh = new UserHome(UserID, RealName);
                    //MessageBox.Show(UserID);
                    //MessageBox.Show(RealName);

                    uh.Show();
                    this.Hide();
                }
                else
                {
                    loginCount++;
                    MessageBox.Show("Invalid Login");
                }
            }
        }

        private void lnkRegisterAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            User_Register UR = new User_Register();
            UR.Show();
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
