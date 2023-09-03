using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Rental_System
{
    public partial class Admin_Register : Form
    {
        public Admin_Register()
        {
            InitializeComponent();
            FormHelper.AdminFormHelper.SetFormSize(this);
            FalseVisible.AdminFV.falseVisible(lblAdminNameErr, lblEmailErr, lblGenderErr,lblPasswordErr,
                lblPhoneNumberErr, lblUserNameErr, lblAddressErr);
            txtAdminID.Text = IDHelper.AdminLastID.GetAutoID();
             
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Empty.AdminEmpty.requireTxt(txtAdminName, lblAdminNameErr, rdoMale,rdoFemale, lblGenderErr,txtPhone,lblPhoneNumberErr,txtUserName,lblUserNameErr,
                txtPassword,lblPasswordErr,txtEmail,lblEmailErr,txtAddress,lblAddressErr);
            Empty.AdminEmpty.formatValid(txtEmail, lblEmailErr,txtPhone,lblPhoneNumberErr,txtPassword,lblPasswordErr);


            string expression = default(string);
            expression = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";


            
           if (!Regex.IsMatch(txtPhone.Text, @"^\d+$"))
            {
                MessageBox.Show("Phone number can have only numbers.");
                txtPhone.Focus();
               txtPhone.SelectAll();
            }

            if (!Regex.IsMatch(txtEmail.Text, expression))
            {
               // MessageBox.Show("Not a Valid Email address");
                txtEmail.Focus();
                txtEmail.SelectAll();
            }
            

            

            RadioButton rdogender = null;
            if(rdoFemale.Checked==true)
            {
                RentalSystem_DataSetTableAdapters.AdminsTableAdapter Admin=new RentalSystem_DataSetTableAdapters.AdminsTableAdapter();
                DataTable DT = new DataTable();
                DataTable DTE = new DataTable();
                DataTable DTP = new DataTable();


                try
                {
                        if(txtUserName.Text!="")
                        {
                            DT = Admin.UniqueUserNameAdmin(txtUserName.Text);
                        }
                        if(txtEmail.Text!="")
                        {
                            DTE = Admin.UniqueEmailAdmin(txtEmail.Text);
                        }
                        if(txtPhone.Text!="")
                        {
                            DTP = Admin.UniquePhoneAdmin(txtPhone.Text);
                        }


                        if (DT.Rows.Count == 0 && DTE.Rows.Count == 0 && DTP.Rows.Count == 0 && Regex.IsMatch(txtEmail.Text, expression) )
                    {
                       
                        rdogender = rdoFemale;
                        Service.AdminServiceImp.InsertData(txtAdminID, txtAdminName, txtUserName,
                            txtEmail, txtPhone, txtPassword, rdogender.Text, txtAddress);
                       // MessageBox.Show("Successfully Register");
                    }
                    else if(DT.Rows.Count > 0)
                    {  
                        MessageBox.Show("UserName :" + txtUserName.Text + " is already exist in database.");
                        txtUserName.Focus();
                        txtUserName.SelectAll();
                    }
                    else if (DTE.Rows.Count > 0)
                    {
                        MessageBox.Show("Email :" + txtEmail.Text + " is already exist in database.");
                        txtEmail.Focus();
                        txtEmail.SelectAll();
                    }
                    else if (DTP.Rows.Count > 0)
                    {
                        MessageBox.Show("Phone :" + txtPhone.Text + " is already exist in database.");
                        txtPhone.Focus();
                        txtPhone.SelectAll();
                    }
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Database Error : " + ex.Message);
                }   
            }
            else if(rdoMale.Checked==true)
            {
                RentalSystem_DataSetTableAdapters.AdminsTableAdapter Admin = new RentalSystem_DataSetTableAdapters.AdminsTableAdapter();
                DataTable DTE = new DataTable();
                DataTable DTP = new DataTable();
                DataTable DT = new DataTable();


                try
                {
                    if (txtUserName.Text != "")
                    {
                        DT = Admin.UniqueUserNameAdmin(txtUserName.Text);
                    }
                    if (txtEmail.Text != "")
                    {
                        DTE = Admin.UniqueEmailAdmin(txtEmail.Text);
                    }
                    if (txtPhone.Text != "")
                    {
                        DTP = Admin.UniquePhoneAdmin(txtPhone.Text);
                    }
                    


                    if (DT.Rows.Count == 0 && DTE.Rows.Count == 0 && DTP.Rows.Count == 0 && Regex.IsMatch(txtEmail.Text, expression))
                    {
                       
                        rdogender = rdoMale;
                        Service.AdminServiceImp.InsertData(txtAdminID, txtAdminName, txtUserName,
                            txtEmail, txtPhone, txtPassword, rdogender.Text, txtAddress);
                       // MessageBox.Show("Successfully Register");
                    }
                    else if (DT.Rows.Count > 0)
                    {

                        MessageBox.Show("UserName :" + txtUserName.Text + " is already exist in database.");
                    }
                    else if (DTE.Rows.Count > 0)
                    {
                        MessageBox.Show("Email :" + txtEmail.Text + " is already exist in database.");
                        txtEmail.Focus();
                        txtEmail.SelectAll();
                    }
                    else if (DTP.Rows.Count > 0)
                    {
                        MessageBox.Show("Phone :" + txtPhone.Text + " is already exist in database.");
                        txtPhone.Focus();
                        txtPhone.SelectAll();
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error : " + ex.Message
                        );
                }
            }
            
        }

        private void lnkLoginAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminLogin AL = new AdminLogin();
            AL.Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { txtAdminID, txtAdminName, txtPassword, txtUserName,
                         txtPhone, txtEmail, txtAddress };
            ClearBox.Clear.ClearTextBoxes(textBoxes);
            txtAdminID.Text = IDHelper.AdminLastID.GetAutoID();
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            // Toggle password visibility by changing the PasswordChar property
            if (txtPassword.PasswordChar == '\0') // PasswordChar is set to '\0' when the password is visible
            {
                txtPassword.PasswordChar = '*'; // Set the password character back to '*'
            }
            else
            {
                txtPassword.PasswordChar = '\0'; // Set PasswordChar to '\0' to show the password
            }
        }
    }
}
