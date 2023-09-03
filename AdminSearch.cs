using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;

namespace Rental_System
{
    public partial class AdminSearch : Form
    {
        RentalSystem_DataSetTableAdapters.RentTableAdapter dsRent = new RentalSystem_DataSetTableAdapters.RentTableAdapter();
        RentalSystem_DataSetTableAdapters.ApplianceTableAdapter dsAppliance = new RentalSystem_DataSetTableAdapters.ApplianceTableAdapter();
        public AdminSearch()
        {
            InitializeComponent();
            setUserID();
            setRentID();
            setApplianceID();
        }
        

        private void myCol()
        {
            dgvAdmin.Columns.Add("RentID", "RentID");
            dgvAdmin.Columns.Add("UserID","UserID");
            dgvAdmin.Columns.Add("UserName","UserName");
            dgvAdmin.Columns.Add("RentDate","RentDate");
            dgvAdmin.Columns.Add("DueDate","DueDate");
            dgvAdmin.Columns.Add("TotalPrice","TotalPrice");

            dgvAdmin.Columns.Add("ApplianceID","ApplianceID");
            dgvAdmin.Columns.Add("ApplianceName","ApplianceName");
            dgvAdmin.Columns.Add("ApplianceTypeName","ApplianceTypeName");

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imageColumn.HeaderText = "ApplianceImage";
            dgvAdmin.Columns.Add(imageColumn);

            dgvAdmin.Columns.Add("Detail", "Detail");
        }

        private void getInformation()
        {
            CustomRentalTable rental = new CustomRentalTable();


            try
            {
                List<Image> Images = new List<Image>();
            dgvAdmin.Rows.Clear();
            dgvAdmin.Columns.Clear();

            myCol();
            DataTable dt = new DataTable();
            RentalSystem_DataSet.RentDataTable rentDataTable = new RentalSystem_DataSet.RentDataTable();

            dt = rental.SelectAdmin();

           // RentalSystem_DataSet.RentDataTable rentDataTable = rentalDataHandler.SelectAdmin();

           // dt = dsRent.SelectAdmin();
            

            for (int i = 0; i < dt.Rows.Count;i++ )
            {
                DataGridViewRow row = new DataGridViewRow();

                string imagePath = dt.Rows[i]["ApplianceImage"].ToString();
                Bitmap image;

                if (File.Exists(imagePath))
                {
                    image = new Bitmap(imagePath);
                }
                else
                {
                    // Set a default image or handle the case when the image file doesn't exist
                    image = null; // Assuming "DefaultImage" is a resource in your project
                }

                Images.Add(image);

                row.CreateCells(dgvAdmin);

                row.Cells[0].Value = dt.Rows[i]["RentID"].ToString();
                row.Cells[1].Value = dt.Rows[i]["UserID"].ToString();
                row.Cells[2].Value = dt.Rows[i]["UserName"].ToString();
                row.Cells[3].Value = dt.Rows[i]["RentDate"].ToString();
            
                row.Cells[4].Value = dt.Rows[i]["DueDate"].ToString();
                row.Cells[5].Value = dt.Rows[i]["TotalPrice"].ToString();
                row.Cells[6].Value = dt.Rows[i]["ApplianceID"].ToString();

                row.Cells[7].Value = dt.Rows[i]["ApplianceName"].ToString();
                row.Cells[8].Value = dt.Rows[i]["ApplianceTypeName"].ToString();

                row.Cells[9].Value = image;

                row.Cells[10].Value = dt.Rows[i]["Detail"].ToString();
                dgvAdmin.Rows.Add(row);
            }
        
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message+"  "+ex.StackTrace);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            getInformation();
        }

        private void btnSortASCUserID_Click(object sender, EventArgs e)
        {
            CustomRentalTable rental = new CustomRentalTable();


            try
            {
                List<Image> Images = new List<Image>();
                dgvAdmin.Rows.Clear();
                dgvAdmin.Columns.Clear();

                myCol();
                DataTable dt = new DataTable();
                RentalSystem_DataSet.RentDataTable rentDataTable = new RentalSystem_DataSet.RentDataTable();

                dt = rental.SortUserIDASC();

                // RentalSystem_DataSet.RentDataTable rentDataTable = rentalDataHandler.SelectAdmin();

                // dt = dsRent.SelectAdmin();


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();

                    string imagePath = dt.Rows[i]["ApplianceImage"].ToString();
                    Bitmap image;

                    if (File.Exists(imagePath))
                    {
                        image = new Bitmap(imagePath);
                    }
                    else
                    {
                        // Set a default image or handle the case when the image file doesn't exist
                        image = null; // Assuming "DefaultImage" is a resource in your project
                    }

                    Images.Add(image);

                    row.CreateCells(dgvAdmin);

                    row.Cells[0].Value = dt.Rows[i]["RentID"].ToString();
                    row.Cells[1].Value = dt.Rows[i]["UserID"].ToString();
                    row.Cells[2].Value = dt.Rows[i]["UserName"].ToString();
                    row.Cells[3].Value = dt.Rows[i]["RentDate"].ToString();

                    row.Cells[4].Value = dt.Rows[i]["DueDate"].ToString();
                    row.Cells[5].Value = dt.Rows[i]["TotalPrice"].ToString();
                    row.Cells[6].Value = dt.Rows[i]["ApplianceID"].ToString();

                    row.Cells[7].Value = dt.Rows[i]["ApplianceName"].ToString();
                    row.Cells[8].Value = dt.Rows[i]["ApplianceTypeName"].ToString();

                    row.Cells[9].Value = image;

                    row.Cells[10].Value = dt.Rows[i]["Detail"].ToString();
                    dgvAdmin.Rows.Add(row);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "  " + ex.StackTrace);
            }
        }

        private void btnSortByDateASC_Click(object sender, EventArgs e)
        {
            CustomRentalTable rental = new CustomRentalTable();


            try
            {
                List<Image> Images = new List<Image>();
                dgvAdmin.Rows.Clear();
                dgvAdmin.Columns.Clear();

                myCol();
                DataTable dt = new DataTable();
                RentalSystem_DataSet.RentDataTable rentDataTable = new RentalSystem_DataSet.RentDataTable();

                dt = rental.SortRentDateASC();

                // RentalSystem_DataSet.RentDataTable rentDataTable = rentalDataHandler.SelectAdmin();

                // dt = dsRent.SelectAdmin();


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();

                    string imagePath = dt.Rows[i]["ApplianceImage"].ToString();
                    Bitmap image;

                    if (File.Exists(imagePath))
                    {
                        image = new Bitmap(imagePath);
                    }
                    else
                    {
                        // Set a default image or handle the case when the image file doesn't exist
                        image = null; // Assuming "DefaultImage" is a resource in your project
                    }

                    Images.Add(image);

                    row.CreateCells(dgvAdmin);

                    row.Cells[0].Value = dt.Rows[i]["RentID"].ToString();
                    row.Cells[1].Value = dt.Rows[i]["UserID"].ToString();
                    row.Cells[2].Value = dt.Rows[i]["UserName"].ToString();
                    row.Cells[3].Value = dt.Rows[i]["RentDate"].ToString();

                    row.Cells[4].Value = dt.Rows[i]["DueDate"].ToString();
                    row.Cells[5].Value = dt.Rows[i]["TotalPrice"].ToString();
                    row.Cells[6].Value = dt.Rows[i]["ApplianceID"].ToString();

                    row.Cells[7].Value = dt.Rows[i]["ApplianceName"].ToString();
                    row.Cells[8].Value = dt.Rows[i]["ApplianceTypeName"].ToString();

                    row.Cells[9].Value = image;

                    row.Cells[10].Value = dt.Rows[i]["Detail"].ToString();
                    dgvAdmin.Rows.Add(row);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "  " + ex.StackTrace);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (rdoDate.Checked != true && rdoRentID.Checked != true && rdoUserID.Checked != true && rdoApplianceID.Checked != true)
            {
                MessageBox.Show("Please Check one radio button");
            }
            else if(rdoDate.Checked==true && txtFromDate.Text==""  )
            {
                MessageBox.Show("Please select a date.", "Date Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (
                (rdoDate.Checked == true && comboApplianceID.SelectedIndex > 0)
                || (rdoDate.Checked == true && comboRentID.SelectedIndex > 0)
                || (rdoDate.Checked == true && comboUserID.SelectedIndex > 0 )
                )
            {
                MessageBox.Show("Please select a correct box, you select wrong box.", "Wrong Select Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if((rdoRentID.Checked==true && comboRentID.SelectedIndex==0) || (rdoRentID.Checked==true && comboRentID.SelectedIndex==-1))
            {
                MessageBox.Show("Please select a Rent ID.", "Rent ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (
                (rdoRentID.Checked == true && comboUserID.SelectedIndex > 0)
                || (rdoRentID.Checked == true && comboApplianceID.SelectedIndex > 0)
                )
            {
                  MessageBox.Show("Please select a correct box, you select wrong box.", "Wrong Select Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(
                (rdoUserID.Checked == true && comboUserID.SelectedIndex == 0) || (rdoUserID.Checked == true && comboUserID.SelectedIndex == -1)
                )
            {
                MessageBox.Show("Please select a User ID.", "User ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if( (rdoUserID.Checked == true && comboRentID.SelectedIndex > 0)
                || (rdoUserID.Checked == true && comboApplianceID.SelectedIndex > 0)
                )
            {
                 MessageBox.Show("Please select a correct box, you select wrong box.", "Wrong Select Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if((rdoApplianceID.Checked==true&& comboApplianceID.SelectedIndex==0) || (rdoApplianceID.Checked==true && comboApplianceID.SelectedIndex==-1))
            {
                 MessageBox.Show("Please select a Appliance ID.", "Appliance ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(
                (rdoApplianceID.Checked == true && comboRentID.SelectedIndex> 0)
                || (rdoApplianceID.Checked == true && comboUserID.SelectedIndex > 0)
                )
            {
                MessageBox.Show("Please select a correct box, you select wrong box.", "Wrong Select Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

            IFrdoUserID();
            IFrdoRentID();
            IFrdoApplianceID();
            IFrdoDate();
        }

        private void IFrdoDate()
        {
            if (rdoDate.Checked)
            {
                CustomRentalTable rental = new CustomRentalTable();

                DataTable dt = new DataTable();
                // dt = dsRent.SearchByUserID(selectedUserID);

                RentalSystem_DataSet.RentDataTable rentDataTable = new RentalSystem_DataSet.RentDataTable();

                dt = rental.SearchByRentDate(txtFromDate.Text);

                dgvAdmin.Rows.Clear();
                dgvAdmin.Columns.Clear();
                myCol();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();

                    string imagePath = dt.Rows[i]["ApplianceImage"].ToString();
                    Bitmap image;

                    if (File.Exists(imagePath))
                    {
                        image = new Bitmap(imagePath);
                    }
                    else
                    {
                        image = null;
                    }

                    row.CreateCells(dgvAdmin);
                    row.Cells[0].Value = dt.Rows[i]["RentID"].ToString();
                    row.Cells[1].Value = dt.Rows[i]["UserID"].ToString();
                    row.Cells[2].Value = dt.Rows[i]["UserName"].ToString();
                    row.Cells[3].Value = dt.Rows[i]["RentDate"].ToString();
                    row.Cells[4].Value = dt.Rows[i]["DueDate"].ToString();
                    row.Cells[5].Value = dt.Rows[i]["TotalPrice"].ToString();
                    row.Cells[6].Value = dt.Rows[i]["ApplianceID"].ToString();
                    row.Cells[7].Value = dt.Rows[i]["ApplianceName"].ToString();
                    row.Cells[8].Value = dt.Rows[i]["ApplianceTypeName"].ToString();
                    row.Cells[9].Value = image;
                    row.Cells[10].Value = dt.Rows[i]["Detail"].ToString();

                    dgvAdmin.Rows.Add(row);
                }
            }
        }

        private void IFrdoRentID()
        {
            if (rdoRentID.Checked)
            {
                CustomRentalTable rental = new CustomRentalTable();

                DataTable dt = new DataTable();
                string selectRentID = comboRentID.SelectedItem.ToString();
                // dt = dsRent.SearchByUserID(selectedUserID);

                RentalSystem_DataSet.RentDataTable rentDataTable = new RentalSystem_DataSet.RentDataTable();

                dt = rental.SearchByRentID(selectRentID);

                dgvAdmin.Rows.Clear();
                dgvAdmin.Columns.Clear();
                myCol();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();

                    string imagePath = dt.Rows[i]["ApplianceImage"].ToString();
                    Bitmap image;

                    if (File.Exists(imagePath))
                    {
                        image = new Bitmap(imagePath);
                    }
                    else
                    {
                        image = null;
                    }

                    row.CreateCells(dgvAdmin);
                    row.Cells[0].Value = dt.Rows[i]["RentID"].ToString();
                    row.Cells[1].Value = dt.Rows[i]["UserID"].ToString();
                    row.Cells[2].Value = dt.Rows[i]["UserName"].ToString();
                    row.Cells[3].Value = dt.Rows[i]["RentDate"].ToString();
                    row.Cells[4].Value = dt.Rows[i]["DueDate"].ToString();
                    row.Cells[5].Value = dt.Rows[i]["TotalPrice"].ToString();
                    row.Cells[6].Value = dt.Rows[i]["ApplianceID"].ToString();
                    row.Cells[7].Value = dt.Rows[i]["ApplianceName"].ToString();
                    row.Cells[8].Value = dt.Rows[i]["ApplianceTypeName"].ToString();
                    row.Cells[9].Value = image;
                    row.Cells[10].Value = dt.Rows[i]["Detail"].ToString();

                    dgvAdmin.Rows.Add(row);
                }
            }
        }

        private void IFrdoApplianceID()
        {
            if (rdoApplianceID .Checked)
            {
                CustomRentalTable rental = new CustomRentalTable();

                DataTable dt = new DataTable();
                string selectApplianceID = comboApplianceID.SelectedItem.ToString();
                // dt = dsRent.SearchByUserID(selectedUserID);

                RentalSystem_DataSet.RentDataTable rentDataTable = new RentalSystem_DataSet.RentDataTable();

                dt = rental.SearchByApplianceID(selectApplianceID);

                dgvAdmin.Rows.Clear();
                dgvAdmin.Columns.Clear();
                myCol();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();

                    string imagePath = dt.Rows[i]["ApplianceImage"].ToString();
                    Bitmap image;

                    if (File.Exists(imagePath))
                    {
                        image = new Bitmap(imagePath);
                    }
                    else
                    {
                        image = null;
                    }

                    row.CreateCells(dgvAdmin);
                    row.Cells[0].Value = dt.Rows[i]["RentID"].ToString();
                    row.Cells[1].Value = dt.Rows[i]["UserID"].ToString();
                    row.Cells[2].Value = dt.Rows[i]["UserName"].ToString();
                    row.Cells[3].Value = dt.Rows[i]["RentDate"].ToString();
                    row.Cells[4].Value = dt.Rows[i]["DueDate"].ToString();
                    row.Cells[5].Value = dt.Rows[i]["TotalPrice"].ToString();
                    row.Cells[6].Value = dt.Rows[i]["ApplianceID"].ToString();
                    row.Cells[7].Value = dt.Rows[i]["ApplianceName"].ToString();
                    row.Cells[8].Value = dt.Rows[i]["ApplianceTypeName"].ToString();
                    row.Cells[9].Value = image;
                    row.Cells[10].Value = dt.Rows[i]["Detail"].ToString();

                    dgvAdmin.Rows.Add(row);
                }
            }
        }

        private void IFrdoUserID()
        {
            if (rdoUserID.Checked)
            {
                CustomRentalTable rental = new CustomRentalTable();

                DataTable dt = new DataTable();
                string selectedUserID = comboUserID.SelectedItem.ToString();
                // dt = dsRent.SearchByUserID(selectedUserID);

                RentalSystem_DataSet.RentDataTable rentDataTable = new RentalSystem_DataSet.RentDataTable();

                dt = rental.SearchByUserID(selectedUserID);

                dgvAdmin.Rows.Clear();
                dgvAdmin.Columns.Clear();
                myCol();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();

                    string imagePath = dt.Rows[i]["ApplianceImage"].ToString();
                    Bitmap image;

                    if (File.Exists(imagePath))
                    {
                        image = new Bitmap(imagePath);
                    }
                    else
                    {
                        image = null;
                    }

                    row.CreateCells(dgvAdmin);
                    row.Cells[0].Value = dt.Rows[i]["RentID"].ToString();
                    row.Cells[1].Value = dt.Rows[i]["UserID"].ToString();
                    row.Cells[2].Value = dt.Rows[i]["UserName"].ToString();
                    row.Cells[3].Value = dt.Rows[i]["RentDate"].ToString();
                    row.Cells[4].Value = dt.Rows[i]["DueDate"].ToString();
                    row.Cells[5].Value = dt.Rows[i]["TotalPrice"].ToString();
                    row.Cells[6].Value = dt.Rows[i]["ApplianceID"].ToString();
                    row.Cells[7].Value = dt.Rows[i]["ApplianceName"].ToString();
                    row.Cells[8].Value = dt.Rows[i]["ApplianceTypeName"].ToString();
                    row.Cells[9].Value = image;
                    row.Cells[10].Value = dt.Rows[i]["Detail"].ToString();

                    dgvAdmin.Rows.Add(row);
                }
            }
        }

        private void setUserID()
        {
            DataTable dt = new DataTable(); // Replace this with a method to fetch the user data from your data source.
            dt = dsRent.GetData();
            comboUserID.Items.Clear(); // Clear the existing items before adding new ones.
            comboUserID.Items.Add("Choose User ID");

            HashSet<string> distinctUserIDs = new HashSet<string>();

            for (int x = 0; x < dt.Rows.Count; x++)
            {
                string userID = dt.Rows[x]["UserID"].ToString();
                if (!distinctUserIDs.Contains(userID))
                {
                    distinctUserIDs.Add(userID);
                    comboUserID.Items.Add(userID);
                }
                comboUserID.SelectedIndex = 0;
            }
        }

        private void setRentID()
        {
            DataTable dt = new DataTable(); // Replace this with a method to fetch the user data from your data source.
            dt = dsRent.GetData();
            comboRentID.Items.Clear(); // Clear the existing items before adding new ones.
            comboRentID.Items.Add("Choose Rent ID");

            HashSet<string> distinctRentIDs = new HashSet<string>();

            for (int x = 0; x < dt.Rows.Count; x++)
            {
                string rentID = dt.Rows[x]["RentID"].ToString();
                if (!distinctRentIDs.Contains(rentID))
                {
                    distinctRentIDs.Add(rentID);
                    comboRentID.Items.Add(rentID);
                }
                comboRentID.SelectedIndex = 0;
            }
        }

        private void setApplianceID()
        {
            DataTable dt = new DataTable(); // Replace this with a method to fetch the user data from your data source.
            dt = dsAppliance.GetDataWithStatusZERO();
            comboApplianceID.Items.Clear(); // Clear the existing items before adding new ones.
            comboApplianceID.Items.Add("Choose Appliance ID");

            HashSet<string> distinctApplianceIDs = new HashSet<string>();

            for (int x = 0; x < dt.Rows.Count; x++)
            {
                string applianceID = dt.Rows[x]["ApplianceID"].ToString();
                if (!distinctApplianceIDs.Contains(applianceID))
                {
                    distinctApplianceIDs.Add(applianceID);
                    comboApplianceID.Items.Add(applianceID);
                }
                comboApplianceID.SelectedIndex = 0;
            }
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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            AdminLogin AL = new AdminLogin();
            AL.Show();
            this.Hide();
        }

    }
}
