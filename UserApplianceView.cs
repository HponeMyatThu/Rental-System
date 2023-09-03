using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Rental_System
{
    public partial class UserApplianceView : Form
    {
        RentalSystem_DataSetTableAdapters.ApplianceTableAdapter dsAppliance = new RentalSystem_DataSetTableAdapters.ApplianceTableAdapter();
        RentalSystem_DataSetTableAdapters.ApplianceTypeTableAdapter dsAType = new RentalSystem_DataSetTableAdapters.ApplianceTypeTableAdapter();
        DataTable dt = new DataTable();
        DataTable dtAType = new DataTable();
        DataTable dtSType = new DataTable();
        DataTable dtP = new DataTable();
        DataTable dtA = new DataTable();

        public UserApplianceView()
        {
            InitializeComponent();
            FormHelper.UserApplianceView.SetFormSize(this);
            setApplianceTypeName();
            setPowerUsage();
            setApplianceName();
           
        }
        public void myDataGridCol()
        {
            dgvAppliances.Columns.Add("ApplianceName", "ApplianceName");
            dgvAppliances.Columns.Add("ApplianceTypeName", "ApplianceTypeName");
            dgvAppliances.Columns.Add("PowerUsage", "PowerUsage");
            dgvAppliances.Columns.Add("TypicalUsage", "TypicalUsage");
            dgvAppliances.Columns.Add("Brand", "Brand");
            dgvAppliances.Columns.Add("Model", "Model");
            dgvAppliances.Columns.Add("Color", "Color");
            dgvAppliances.Columns.Add("Status", "Status");

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imageColumn.HeaderText = "ApplianceImage";
            dgvAppliances.Columns.Add(imageColumn);

            dgvAppliances.Columns.Add("Detail", "Detail");
        }

        public void GetApplianceInformation()
        {
            List<Image> Images = new List<Image>();
            dgvAppliances.Rows.Clear();
            dgvAppliances.Columns.Clear();

            DataTable dt = dsAppliance.SearchAllAppliance();
            myDataGridCol();

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

                row.CreateCells(dgvAppliances);
                row.Cells[0].Value = dt.Rows[i]["ApplianceName"].ToString();
                row.Cells[1].Value = dt.Rows[i]["ApplianceTypeName"].ToString();
                row.Cells[2].Value = dt.Rows[i]["PowerUsage"].ToString();
                row.Cells[3].Value = dt.Rows[i]["TypicalUsage"].ToString();

                row.Cells[4].Value = dt.Rows[i]["Brand"].ToString();
                row.Cells[5].Value = dt.Rows[i]["Model"].ToString();
                row.Cells[6].Value = dt.Rows[i]["Color"].ToString();
                row.Cells[7].Value = dt.Rows[i]["Status"].ToString();

                row.Cells[8].Value = image;
                row.Cells[9].Value = dt.Rows[i]["ApplianceDetail"].ToString();

                dgvAppliances.Rows.Add(row);
            }
        }

        private void btnSearchAll_Click(object sender, EventArgs e)
        {
            GetApplianceInformation();
        }

        private void setApplianceTypeName()
        {
            dtAType = dsAType.GetDataWithStatusZERO();
            comboApplianceType.Items.Add("Choose Appliance Type Name");

            for (int x = 0; x < dtAType.Rows.Count;x++ )
            {
                comboApplianceType.Items.Add(dtAType.Rows[x]["ApplianceTypeName"].ToString());
            }
            comboApplianceType.SelectedIndex = 0;
        }

        private void setPowerUsage()
        {
            dtP = dsAppliance.GetDataWithStatusZERO();
            comboPowerUsage.Items.Add("Choose Power Usage");

            for (int x = 0; x < dtP.Rows.Count;x++ )
            {
                comboPowerUsage.Items.Add(dtP.Rows[x]["PowerUsage"].ToString());
            }
            comboPowerUsage.SelectedIndex = 0;
        }

        private void setApplianceName()
        {
            dtA = dsAppliance.GetDataWithStatusZERO();
            comboApplianceName.Items.Add("Choose Appliance Name");

            for (int x = 0; x < dtA.Rows.Count;x++ )
            {
                comboApplianceName.Items.Add(dtA.Rows[x]["ApplianceName"].ToString());
            }
            comboApplianceName.SelectedIndex = 0;
        
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(rdoApplianceName.Checked==false && rdoSearchApplianceType.Checked==false && rdoSearchPowerUsage.Checked==false)
            {
                MessageBox.Show("Please Check One radio button");
            }
            else if (rdoApplianceName.Checked==true && comboApplianceName.SelectedIndex==0)
            {
                MessageBox.Show("Please Choose one Appliance Name");
            }
            else if (rdoSearchApplianceType.Checked == true && comboApplianceType.SelectedIndex == 0)
            {
                MessageBox.Show("Please Choose one Appliance Type");

            }
            else if (rdoSearchPowerUsage.Checked == true && comboPowerUsage.SelectedIndex == 0)
            {
                MessageBox.Show("Please Choose one Power Usage");
            }
            IFrdoApplianceType();
            IFrdoPowerUsage();
            IFrdoApplianceName();
        }

        private void IFrdoPowerUsage()
        {
            if (rdoSearchPowerUsage.Checked)
            {
                string selectedPowerUsage = comboPowerUsage.SelectedItem.ToString();
                dtSType = dsAppliance.SearchPowerUsage(selectedPowerUsage);

                dgvAppliances.Rows.Clear();
                dgvAppliances.Columns.Clear();
                myDataGridCol(); // Add the columns to the DataGridView.

                for (int i = 0; i < dtSType.Rows.Count; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();

                    string imagePath = dtSType.Rows[i]["ApplianceImage"].ToString();
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

                    row.CreateCells(dgvAppliances);
                    row.Cells[0].Value = dtSType.Rows[i]["ApplianceName"].ToString();
                    row.Cells[1].Value = dtSType.Rows[i]["ApplianceTypeName"].ToString();
                    row.Cells[2].Value = dtSType.Rows[i]["PowerUsage"].ToString();
                    row.Cells[3].Value = dtSType.Rows[i]["TypicalUsage"].ToString();
                    row.Cells[4].Value = dtSType.Rows[i]["Brand"].ToString();
                    row.Cells[5].Value = dtSType.Rows[i]["Model"].ToString();
                    row.Cells[6].Value = dtSType.Rows[i]["Color"].ToString();
                    row.Cells[7].Value = dtSType.Rows[i]["Status"].ToString();
                    row.Cells[8].Value = image;
                    row.Cells[9].Value = dtSType.Rows[i]["ApplianceDetail"].ToString();

                    dgvAppliances.Rows.Add(row);
                }
            }

        }

        private void IFrdoApplianceType()
        {
            if (rdoSearchApplianceType.Checked)
            {
                string selectedApplianceType = comboApplianceType.SelectedItem.ToString();
                dtSType = dsAppliance.SearchByApplianceName(selectedApplianceType);

                dgvAppliances.Rows.Clear();
                dgvAppliances.Columns.Clear();
                myDataGridCol(); // Add the columns to the DataGridView.

                for (int i = 0; i < dtSType.Rows.Count; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();

                    string imagePath = dtSType.Rows[i]["ApplianceImage"].ToString();
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

                    row.CreateCells(dgvAppliances);
                    row.Cells[0].Value = dtSType.Rows[i]["ApplianceName"].ToString();
                    row.Cells[1].Value = dtSType.Rows[i]["ApplianceTypeName"].ToString();
                    row.Cells[2].Value = dtSType.Rows[i]["PowerUsage"].ToString();
                    row.Cells[3].Value = dtSType.Rows[i]["TypicalUsage"].ToString();
                    row.Cells[4].Value = dtSType.Rows[i]["Brand"].ToString();
                    row.Cells[5].Value = dtSType.Rows[i]["Model"].ToString();
                    row.Cells[6].Value = dtSType.Rows[i]["Color"].ToString();
                    row.Cells[7].Value = dtSType.Rows[i]["Status"].ToString();
                    row.Cells[8].Value = image;
                    row.Cells[9].Value = dtSType.Rows[i]["ApplianceDetail"].ToString();

                    dgvAppliances.Rows.Add(row);
                }
            }
        }

        private void IFrdoApplianceName()
        {
            if (rdoApplianceName.Checked)
            {
                string selectedApplianceName = comboApplianceName.SelectedItem.ToString();
                dtSType = dsAppliance.SearchApplianceName(selectedApplianceName);

                dgvAppliances.Rows.Clear();
                dgvAppliances.Columns.Clear();
                myDataGridCol(); // Add the columns to the DataGridView.

                for (int i = 0; i < dtSType.Rows.Count; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();

                    string imagePath = dtSType.Rows[i]["ApplianceImage"].ToString();
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

                    row.CreateCells(dgvAppliances);
                    row.Cells[0].Value = dtSType.Rows[i]["ApplianceName"].ToString();
                    row.Cells[1].Value = dtSType.Rows[i]["ApplianceTypeName"].ToString();
                    row.Cells[2].Value = dtSType.Rows[i]["PowerUsage"].ToString();
                    row.Cells[3].Value = dtSType.Rows[i]["TypicalUsage"].ToString();
                    row.Cells[4].Value = dtSType.Rows[i]["Brand"].ToString();
                    row.Cells[5].Value = dtSType.Rows[i]["Model"].ToString();
                    row.Cells[6].Value = dtSType.Rows[i]["Color"].ToString();
                    row.Cells[7].Value = dtSType.Rows[i]["Status"].ToString();
                    row.Cells[8].Value = image;
                    row.Cells[9].Value = dtSType.Rows[i]["ApplianceDetail"].ToString();

                    dgvAppliances.Rows.Add(row);
                }
            }
        }

        private void btnSortASCPowerUsage_Click(object sender, EventArgs e)
        {
            List<Image> Images = new List<Image>();
            dgvAppliances.Rows.Clear();
            dgvAppliances.Columns.Clear();

            DataTable dt = dsAppliance.SortByPowerUsage();
            myDataGridCol();

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

                row.CreateCells(dgvAppliances);
                row.Cells[0].Value = dt.Rows[i]["ApplianceName"].ToString();
                row.Cells[1].Value = dt.Rows[i]["ApplianceTypeName"].ToString();
                row.Cells[2].Value = dt.Rows[i]["PowerUsage"].ToString();
                row.Cells[3].Value = dt.Rows[i]["TypicalUsage"].ToString();

                row.Cells[4].Value = dt.Rows[i]["Brand"].ToString();
                row.Cells[5].Value = dt.Rows[i]["Model"].ToString();
                row.Cells[6].Value = dt.Rows[i]["Color"].ToString();
                row.Cells[7].Value = dt.Rows[i]["Status"].ToString();

                row.Cells[8].Value = image;
                row.Cells[9].Value = dt.Rows[i]["ApplianceDetail"].ToString();

                dgvAppliances.Rows.Add(row);
            }
        }

        private void btnDESCSortPowerUsage_Click(object sender, EventArgs e)
        {
            List<Image> Images = new List<Image>();
            dgvAppliances.Rows.Clear();
            dgvAppliances.Columns.Clear();

            DataTable dt = dsAppliance.SortByPowerUsageDESC();
            myDataGridCol();

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

                row.CreateCells(dgvAppliances);
                row.Cells[0].Value = dt.Rows[i]["ApplianceName"].ToString();
                row.Cells[1].Value = dt.Rows[i]["ApplianceTypeName"].ToString();
                row.Cells[2].Value = dt.Rows[i]["PowerUsage"].ToString();
                row.Cells[3].Value = dt.Rows[i]["TypicalUsage"].ToString();

                row.Cells[4].Value = dt.Rows[i]["Brand"].ToString();
                row.Cells[5].Value = dt.Rows[i]["Model"].ToString();
                row.Cells[6].Value = dt.Rows[i]["Color"].ToString();
                row.Cells[7].Value = dt.Rows[i]["Status"].ToString();

                row.Cells[8].Value = image;
                row.Cells[9].Value = dt.Rows[i]["ApplianceDetail"].ToString();

                dgvAppliances.Rows.Add(row);
            }
        }

        private void btnSortASCApplianceName_Click(object sender, EventArgs e)
        {
            List<Image> Images = new List<Image>();
            dgvAppliances.Rows.Clear();
            dgvAppliances.Columns.Clear();

            DataTable dt = dsAppliance.SortByApplianceNameASC();
            myDataGridCol();

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

                row.CreateCells(dgvAppliances);
                row.Cells[0].Value = dt.Rows[i]["ApplianceName"].ToString();
                row.Cells[1].Value = dt.Rows[i]["ApplianceTypeName"].ToString();
                row.Cells[2].Value = dt.Rows[i]["PowerUsage"].ToString();
                row.Cells[3].Value = dt.Rows[i]["TypicalUsage"].ToString();

                row.Cells[4].Value = dt.Rows[i]["Brand"].ToString();
                row.Cells[5].Value = dt.Rows[i]["Model"].ToString();
                row.Cells[6].Value = dt.Rows[i]["Color"].ToString();
                row.Cells[7].Value = dt.Rows[i]["Status"].ToString();

                row.Cells[8].Value = image;
                row.Cells[9].Value = dt.Rows[i]["ApplianceDetail"].ToString();

                dgvAppliances.Rows.Add(row);
            }

        }

        private void btnSortApplianceNameDESC_Click(object sender, EventArgs e)
        {
            List<Image> Images = new List<Image>();
            dgvAppliances.Rows.Clear();
            dgvAppliances.Columns.Clear();

            DataTable dt = dsAppliance.SortByApplianceNameDESC();
            myDataGridCol();

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

                row.CreateCells(dgvAppliances);
                row.Cells[0].Value = dt.Rows[i]["ApplianceName"].ToString();
                row.Cells[1].Value = dt.Rows[i]["ApplianceTypeName"].ToString();
                row.Cells[2].Value = dt.Rows[i]["PowerUsage"].ToString();
                row.Cells[3].Value = dt.Rows[i]["TypicalUsage"].ToString();

                row.Cells[4].Value = dt.Rows[i]["Brand"].ToString();
                row.Cells[5].Value = dt.Rows[i]["Model"].ToString();
                row.Cells[6].Value = dt.Rows[i]["Color"].ToString();
                row.Cells[7].Value = dt.Rows[i]["Status"].ToString();

                row.Cells[8].Value = image;
                row.Cells[9].Value = dt.Rows[i]["ApplianceDetail"].ToString();

                dgvAppliances.Rows.Add(row);
            }
        }

        private void btnSortApplianceTypeASC_Click(object sender, EventArgs e)
        {

            List<Image> Images = new List<Image>();
            dgvAppliances.Rows.Clear();
            dgvAppliances.Columns.Clear();

            DataTable dt = dsAppliance.SortByApplianceTypeNameASC();
            myDataGridCol();

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

                row.CreateCells(dgvAppliances);
                row.Cells[0].Value = dt.Rows[i]["ApplianceName"].ToString();
                row.Cells[1].Value = dt.Rows[i]["ApplianceTypeName"].ToString();
                row.Cells[2].Value = dt.Rows[i]["PowerUsage"].ToString();
                row.Cells[3].Value = dt.Rows[i]["TypicalUsage"].ToString();

                row.Cells[4].Value = dt.Rows[i]["Brand"].ToString();
                row.Cells[5].Value = dt.Rows[i]["Model"].ToString();
                row.Cells[6].Value = dt.Rows[i]["Color"].ToString();
                row.Cells[7].Value = dt.Rows[i]["Status"].ToString();

                row.Cells[8].Value = image;
                row.Cells[9].Value = dt.Rows[i]["ApplianceDetail"].ToString();

                dgvAppliances.Rows.Add(row);
            }
        }

        private void btnSortApplianceTypeDESC_Click(object sender, EventArgs e)
        {
            List<Image> Images = new List<Image>();
            dgvAppliances.Rows.Clear();
            dgvAppliances.Columns.Clear();

            DataTable dt = dsAppliance.SortByApplianceTypeNameDESC();
            myDataGridCol();

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

                row.CreateCells(dgvAppliances);
                row.Cells[0].Value = dt.Rows[i]["ApplianceName"].ToString();
                row.Cells[1].Value = dt.Rows[i]["ApplianceTypeName"].ToString();
                row.Cells[2].Value = dt.Rows[i]["PowerUsage"].ToString();
                row.Cells[3].Value = dt.Rows[i]["TypicalUsage"].ToString();

                row.Cells[4].Value = dt.Rows[i]["Brand"].ToString();
                row.Cells[5].Value = dt.Rows[i]["Model"].ToString();
                row.Cells[6].Value = dt.Rows[i]["Color"].ToString();
                row.Cells[7].Value = dt.Rows[i]["Status"].ToString();

                row.Cells[8].Value = image;
                row.Cells[9].Value = dt.Rows[i]["ApplianceDetail"].ToString();

                dgvAppliances.Rows.Add(row);
            }

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void applianceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserApplianceView UAV = new UserApplianceView();
            UAV.Show();
            this.Hide();
            UserHome UH = new UserHome("1","a");
            UH.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            UserLogin UL = new UserLogin();
            UL.Show();
            this.Hide();
        }

        
       
    }
}
