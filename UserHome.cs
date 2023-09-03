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
    public partial class UserHome : Form
    {
        private string UserID;
        private string RealName;

       //private bool isApplianceTypeSelected = false;

        DataTable dtAppliance = new DataTable();
        DataTable dtApplianceType = new DataTable();
        DataTable dtUser = new DataTable();
        DataTable dt = new DataTable();
        DataRow dr;

        RentalSystem_DataSetTableAdapters.ApplianceTypeTableAdapter dsApplianceType = new RentalSystem_DataSetTableAdapters.ApplianceTypeTableAdapter();
        RentalSystem_DataSetTableAdapters.RentTableAdapter dsRental = new RentalSystem_DataSetTableAdapters.RentTableAdapter();
        RentalSystem_DataSetTableAdapters.ApplianceTableAdapter dsAppliance = new RentalSystem_DataSetTableAdapters.ApplianceTableAdapter();
        RentalSystem_DataSetTableAdapters.RentDetailTableAdapter dsRentalDetail = new RentalSystem_DataSetTableAdapters.RentDetailTableAdapter();
        RentalSystem_DataSetTableAdapters.UsersTableAdapter dsUser = new RentalSystem_DataSetTableAdapters.UsersTableAdapter();

        public UserHome(string userID, string realName)
        {
            InitializeComponent();
            UserID = userID;
            RealName = realName;
            txtUserID.Text = UserID;
            txtUserName.Text = RealName;
            txtRentID.Text = IDHelper.RentLastID.GetAutoID();
            setApplianceName();
            setApplianceType();
            col();
           

            btnUpdate.Enabled = false;
            btnChancel.Enabled = false;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void RentalDetail_Enter(object sender, EventArgs e)
        {

        }

        private void setApplianceName()
        {
            DataTable dtA = new DataTable();

            dtA = dsAppliance.GetActiveAppliance();

            for (int i = 0; i < dtA.Rows.Count; i++)
            {
                comboApplianceName.Items.Add(dtA.Rows[i][1].ToString());
            }
        }

      

        private void setApplianceType()
        {
            dtApplianceType = dsApplianceType.GetDataWithStatusZERO();

            comboBoxApplianceType.Items.Add("Choose Appliance Type");
            for (int i = 0; i < dtApplianceType.Rows.Count;i++ )
            {
                comboBoxApplianceType.Items.Add(dtApplianceType.Rows[i]["ApplianceTypeName"].ToString());
            }
            comboBoxApplianceType.SelectedIndex = 0;
        }

        private void comboApplianceName_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = dsAppliance.GetDataBy_ApplianceName(comboApplianceName.SelectedItem.ToString());

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                txtApplianceID.Text = dt.Rows[0]["ApplianceID"].ToString();
                txtPowerUsage.Text = dt.Rows[0]["PowerUsage"].ToString();
                txtBrand.Text = dt.Rows[0]["Brand"].ToString();
                txtPrice.Text = dt.Rows[0]["Price"].ToString();

                PicBox.Image = Image.FromFile(dt.Rows[0]["ApplianceImage"].ToString());
            }
        }

        private void comboBorrowPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime RentDate = txtRentDate.Value;
            int RentPeriod = Convert.ToInt32(comboBorrowPeriod.SelectedItem.ToString());
            DateTime newDate = RentDate.AddMonths(RentPeriod);
            txtDueDate.Value = newDate;
        }

        private void col()
        {
            dt.Columns.Add("ApplianceID", typeof(string));
            dt.Columns.Add("ApplianceName", typeof(string));
            dt.Columns.Add("BrandName", typeof(string));
            dt.Columns.Add("RentPrice(Per-Month)", typeof(decimal));
            dt.Columns.Add("RentPeriod", typeof(string));
            dt.Columns.Add("SubTotal", typeof(decimal));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboApplianceName.SelectedIndex == 0)
                {
                    MessageBox.Show("Please Choose A Appliance Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if(comboBorrowPeriod.SelectedIndex == 0)
                    {
                        MessageBox.Show("Please Choose A Borrow Period", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string searchValue = txtApplianceID.Text;
                        bool isRowExist = false;

                        foreach(DataGridViewRow row in dgvRent.Rows)
                        {
                            if(row.Cells[0].Value !=null && row.Cells[0].Value.ToString().Equals(searchValue))
                            {
                                isRowExist = true;
                                break;
                            }
                        }

                        if (isRowExist) //ture condition
                        {
                            MessageBox.Show("Appliance is already exist in your cart.");
                        }
                        else
                        {
                            dr = dt.NewRow();
                            dr["ApplianceID"] = txtApplianceID.Text;
                            dr["ApplianceName"] = comboApplianceName.SelectedItem.ToString();
                            dr["BrandName"] = txtBrand.Text;

                            dr["RentPrice(Per-Month)"] = txtPrice.Text;
                            dr["RentPeriod"] = comboBorrowPeriod.SelectedItem.ToString();
                            dr["SubTotal"] = Convert.ToInt32(txtPrice.Text) * Convert.ToInt32(comboBorrowPeriod.SelectedItem.ToString());

                            dt.Rows.Add(dr);
                            dgvRent.DataSource = dt;

                            decimal GrandTotal = 0;
                            foreach(DataGridViewRow row in dgvRent.Rows)
                            {
                                if(row.Cells["SubTotal"].Value !=null && !string.IsNullOrEmpty(row.Cells["SubTotal"].Value.ToString()))
                                {
                                    decimal amount;
                                    if (decimal.TryParse(row.Cells["SubTotal"].Value.ToString(), out amount))
                                    {
                                        GrandTotal += amount;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Grand Total Error");
                                    }

                                }
                            }
                            txtGrandTotal.Text = GrandTotal.ToString();
                            int rowCount = dgvRent.Rows.Count;
                            txtTotalAppliance.Text = rowCount.ToString();
                        }
                       

                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(dgvRent.SelectedRows.Count>0)
            {
                comboApplianceName.SelectedIndex = 0;
                txtPowerUsage.Clear();
                txtApplianceID.Clear();
                txtBrand.Clear();
                txtPrice.Clear();
                PicBox.Image = null;

                int rowIndex = dgvRent.SelectedRows[0].Index;
                dgvRent.Rows.RemoveAt(rowIndex);
                int rowCount = dgvRent.Rows.Count;
                txtTotalAppliance.Text = rowCount.ToString();
                decimal GrandTotal = 0;
                foreach (DataGridViewRow row in dgvRent.Rows)
                {
                    if (row.Cells["SubTotal"].Value != null && !string.IsNullOrEmpty(row.Cells["SubTotal"].Value.ToString()))
                    {
                        decimal amount;
                        if (decimal.TryParse(row.Cells["SubTotal"].Value.ToString(), out amount))
                        {
                            GrandTotal += amount;
                        }
                        else
                        {
                            MessageBox.Show("Grand Total Error");
                        }
                    }
                }
                txtGrandTotal.Text = GrandTotal.ToString();
                btnUpdate.Enabled = false;
                btnRemove.Enabled = false;

            }
            else
            {
                MessageBox.Show("Please Select one row in data grid view, You did not select any rows.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                comboApplianceName.SelectedIndex = 0;
                txtPowerUsage.Clear();
                txtApplianceID.Clear();
                txtBrand.Clear();
                txtPrice.Clear();
                PicBox.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error after click CLear button : " + ex.Message);
            }
            //ClearAll();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            try
            {
                string RentID = txtRentID.Text;
                string RentDate = txtRentDate.Text;
                string DueDate = txtDueDate.Text;
                string UserID = txtUserID.Text;
                string TotalAppliance = txtTotalAppliance.Text;
                string RentStatus = "Borrowed";
                string Status = "Inactive";

                dsRental.Insert(RentID, RentDate, DueDate, UserID, TotalAppliance, txtGrandTotal.Text, RentStatus);

                for (int i = dgvRent.Rows.Count - 1; i >= 0; i--)
                {
                    if (dgvRent.Rows[i].Cells[0].Value != null)
                    {
                        string ApplianceID = dgvRent.Rows[i].Cells[0].Value.ToString();
                        string RDStatus = "Borrowed";
                        MessageBox.Show(ApplianceID);
                        //int availableQuantity = Convert.ToInt32(dsAppliance.GetAvaliableQuantity(ApplianceID));

                        DataTable dt = dsAppliance.GetDataByID(ApplianceID);

                        string avaliableQuantity = dt.Rows[0]["AvaliableQuantity"].ToString();

                        int avaliableQuantityINT = Convert.ToInt32(avaliableQuantity);

                        

                        if (avaliableQuantityINT > 0)
                        {
                            int newAvailableQuantity = avaliableQuantityINT - 1;
                            dsAppliance.UpdateAvaliableQuantity(newAvailableQuantity.ToString(), ApplianceID);
                            dsRentalDetail.Insert(RentID, ApplianceID, RDStatus);
                            dgvRent.Rows.RemoveAt(i);

                            //MessageBox.Show("Update");

                            if (newAvailableQuantity < 1)
                            {
                                try
                                {
                                    // Assuming dsAppliance is a valid DataSet with a method UpdateStatusInactive that takes an ApplianceID parameter.
                                    dsAppliance.UpdateStatusInactive(Status, ApplianceID);
                                    MessageBox.Show("Status updated to inactive for ApplianceID: " + ApplianceID);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error updating status to inactive: " + ex.Message);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Appliance with ID " + ApplianceID + " is not available for rent. Skipping...");
                            dgvRent.Rows.RemoveAt(i);
                        }
                    }
                }

               

                MessageBox.Show("Successfully save.");
                ClearAll();
                comboBoxApplianceType.SelectedIndex = 0;
                txtRentID.Text = IDHelper.RentLastID.GetAutoID();
            }
            catch(Exception ex)
            {
                MessageBox.Show("After rent:"+ex.Message+"  "+ex.StackTrace);
            }
        }

        private void ClearAll()
        {
            comboApplianceName.SelectedIndex = 0;
            txtPowerUsage.Clear();
            txtApplianceID.Clear();
            txtBrand.Clear();
            txtPrice.Clear();
            comboBorrowPeriod.SelectedIndex = 1;
            PicBox.Image = null;
            dgvRent.Refresh();
            txtGrandTotal.Text = null;
            txtTotalAppliance.Text = null; 
        }

        private void dgvRent_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgvRent.Rows[e.RowIndex];
                txtApplianceID.Text = row.Cells["ApplianceID"].Value.ToString();
                comboApplianceName.SelectedItem = row.Cells["ApplianceName"].Value.ToString();
                txtBrand.Text = row.Cells["BrandName"].Value.ToString();
                txtPrice.Text = row.Cells["RentPrice(Per-Month)"].Value.ToString();
                comboBorrowPeriod.SelectedItem = row.Cells["RentPeriod"].Value.ToString();
            }
            btnChancel.Enabled = true;
            btnUpdate.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a row is selected in the DataGridView.
                if (dgvRent.SelectedRows.Count > 0)
                {
                    // Get the selected row.
                    DataGridViewRow selectedRow = dgvRent.SelectedRows[0];

                    // Update the data of the selected row with the new values.
                    selectedRow.Cells["ApplianceName"].Value = comboApplianceName.SelectedItem.ToString();
                    selectedRow.Cells["BrandName"].Value = txtBrand.Text;
                    selectedRow.Cells["RentPrice(Per-Month)"].Value = txtPrice.Text;
                    selectedRow.Cells["RentPeriod"].Value = comboBorrowPeriod.SelectedItem.ToString();
                    selectedRow.Cells["SubTotal"].Value = Convert.ToInt32(txtPrice.Text) * Convert.ToInt32(comboBorrowPeriod.SelectedItem.ToString());

                    // Recalculate the GrandTotal after the update.
                    decimal GrandTotal = 0;
                    foreach (DataGridViewRow row in dgvRent.Rows)
                    {
                        if (row.Cells["SubTotal"].Value != null && !string.IsNullOrEmpty(row.Cells["SubTotal"].Value.ToString()))
                        {
                            decimal amount;
                            if (decimal.TryParse(row.Cells["SubTotal"].Value.ToString(), out amount))
                            {
                                GrandTotal += amount;
                            }
                            else
                            {
                                MessageBox.Show("Grand Total Error");
                            }
                        }
                    }
                    txtGrandTotal.Text = GrandTotal.ToString();
                    comboApplianceName.SelectedIndex = 0;
                    txtPowerUsage.Clear();
                    txtApplianceID.Clear();
                    txtBrand.Clear();
                    txtPrice.Clear();
                    comboBorrowPeriod.SelectedIndex = 1;
                    PicBox.Image = null;
                    dgvRent.Refresh();

                    btnChancel.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnAdd.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Please select a row in the DataGridView to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnChancel_Click(object sender, EventArgs e)
        {
            try
            {
                comboApplianceName.SelectedIndex = 0;
                txtPowerUsage.Clear();
                txtApplianceID.Clear();
                txtBrand.Clear();
                txtPrice.Clear();
                PicBox.Image = null;
                comboBorrowPeriod.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error after click chancel button : " + ex.Message);
            }
        }

        private void applianceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserApplianceView UAV = new UserApplianceView();
            UAV.Show();
            this.Hide();
        }

        private void comboBoxApplianceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // isApplianceTypeSelected = true;
            //isApplianceTypeSelected = true;

            //if (isApplianceTypeSelected == true)
            //{
            //    string selectedAType = comboBoxApplianceType.SelectedItem.ToString();
            //    DataTable dtAppliance = dsAppliance.SearchByApplianceName(selectedAType);

            //    // Clear the existing items in the combobox before adding new ones
            //    comboApplianceName.Items.Clear();

            //    // Add a default item to indicate choosing the appliance name
            //    comboApplianceName.Items.Add("Choose Appliance Name");

            //    for (int i = 0; i < dtAppliance.Rows.Count; i++)
            //    {
            //        comboApplianceName.Items.Add(dtAppliance.Rows[i]["ApplianceName"].ToString());
            //    }

            //    comboApplianceName.SelectedIndex = 0; // Select the default item
            //}
            string selectedAType = comboBoxApplianceType.SelectedItem.ToString();

            if (selectedAType == "Choose Appliance Type")
            {
                // If the user selects "Choose Appliance Type," show all appliance names
                SetAllApplianceNames();
            }
            else
            {
                // Otherwise, fetch and show the appliance names related to the selected type
                ShowRelatedApplianceNames(selectedAType);
            }


        }

        private void SetAllApplianceNames()
        {
            DataTable dtAllAppliances = dsAppliance.GetActiveAppliance();

            // Clear the existing items in the combobox before adding new ones
            comboApplianceName.Items.Clear();

            // Add a default item to indicate choosing the appliance name
            comboApplianceName.Items.Add("Choose Appliance Name");

            for (int i = 0; i < dtAllAppliances.Rows.Count; i++)
            {
                comboApplianceName.Items.Add(dtAllAppliances.Rows[i]["ApplianceName"].ToString());
            }

            comboApplianceName.SelectedIndex = 0; // Select the default item
        }

        private void ShowRelatedApplianceNames(string selectedAType)
        {
            DataTable dtAppliance = dsAppliance.ChooseApplianceNameWithStatusZeroAvaGreaterThanZero(selectedAType);

            // Clear the existing items in the combobox before adding new ones
            comboApplianceName.Items.Clear();

            // Add a default item to indicate choosing the appliance name
            comboApplianceName.Items.Add("Choose Appliance Name");

            for (int i = 0; i < dtAppliance.Rows.Count; i++)
            {
                comboApplianceName.Items.Add(dtAppliance.Rows[i]["ApplianceName"].ToString());
            }

            comboApplianceName.SelectedIndex = 0; // Select the default item
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserHome uh = new UserHome(UserID, RealName);
            uh.Show();
            this.Hide();
        }

        private void applianceSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserApplianceView UAV = new UserApplianceView();
            UAV.Show();
           
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            UserLogin UL = new UserLogin();
            UL.Show();
            this.Hide();
        }
    }
}
