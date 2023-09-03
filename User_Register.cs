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
    public partial class User_Register : Form
    {
       
        public User_Register()
        {
            InitializeComponent();
            FormHelper.UserFormHelper.SetFormSize(this);
            Empty.FalseVisible.UserFV.falseVisible(lblUserNameErr, lblRealNameErr, lblPhoneNumberErr, lblPasswordErr,
                lblGenderErr, lblEmailErr, lblAddressErr);
            txtUserID.Text = IDHelper.UserLastID.GetAutoID();


        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Empty.UserEmpty.requireTxt(txtRealName, lblRealNameErr, rdoMale, rdoFemale, lblGenderErr, txtPhone, lblPhoneNumberErr, txtUserName, lblUserNameErr, txtPassword, lblPasswordErr, txtEmail, lblEmailErr, txtAddress, lblAddressErr);
            Empty.UserEmpty.formatValid(txtEmail, lblEmailErr, txtPhone, lblPhoneNumberErr, txtPassword, lblPasswordErr);

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
                RentalSystem_DataSetTableAdapters.UsersTableAdapter User = new RentalSystem_DataSetTableAdapters.UsersTableAdapter();
                DataTable DT = new DataTable();
                DataTable DTE = new DataTable();
                DataTable DTP = new DataTable();
               
                try
                {
                        if(txtUserName.Text!="")
                        {
                            DT = User.UniqueUserNameUser(txtUserName.Text);
                        }
                        if(txtEmail.Text!="")
                        {
                            DTE = User.UniqueEmailUser(txtEmail.Text);
                        }
                        if(txtPhone.Text!="")
                        {
                            DTP = User.UniquePhoneUser(txtPhone.Text);
                        }
                        
                    if(DT.Rows.Count == 0 && DTE.Rows.Count == 0 && DTP.Rows.Count == 0)
                    {
                        MessageBox.Show("Register Successfully.");
                        rdogender = rdoFemale;
                        Service.UserServiceImp.InsertData(txtUserID, txtRealName, txtUserName,
                             txtPhone, txtEmail, txtPassword, rdogender.Text, txtAddress);
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
            else if (rdoMale.Checked == true)
            {
                RentalSystem_DataSetTableAdapters.UsersTableAdapter User = new RentalSystem_DataSetTableAdapters.UsersTableAdapter();
                DataTable DTE = new DataTable();
                DataTable DTP = new DataTable();
                DataTable DT = new DataTable();

                try
                {
                    if (txtUserName.Text != "")
                    {
                        DT = User.UniqueUserNameUser(txtUserName.Text);
                    }
                    if (txtEmail.Text != "")
                    {
                        DTE = User.UniqueEmailUser(txtEmail.Text);
                    }
                    if (txtPhone.Text != "")
                    {
                        DTP = User.UniquePhoneUser(txtPhone.Text);
                    }

                    if (DT.Rows.Count == 0 && DTE.Rows.Count == 0 && DTP.Rows.Count == 0)
                    {
                       
                        rdogender = rdoMale;
                        Service.UserServiceImp.InsertData(txtUserID, txtRealName, txtUserName,
                             txtPhone, txtEmail, txtPassword, rdogender.Text, txtAddress);

                        //MessageBox.Show("Register Successfully.");
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes ={txtUserID,txtRealName,txtPassword,txtUserName,
                                        txtPhone,txtEmail,txtAddress};
            ClearBox.User.ClearTextBoxes(textBoxes);
            txtUserID.Text = IDHelper.UserLastID.GetAutoID();
        }

        private void lnkLoginUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserLogin UL = new UserLogin();
            UL.Show();
            this.Hide();
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
