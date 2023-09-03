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
using Rental_System.Model;

namespace Rental_System
{
    public partial class AdminAppliance : Form
    {
        RentalSystem_DataSetTableAdapters.ApplianceTypeTableAdapter objAppType = new RentalSystem_DataSetTableAdapters.ApplianceTypeTableAdapter();
        RentalSystem_DataSetTableAdapters.ApplianceTableAdapter objApp = new RentalSystem_DataSetTableAdapters.ApplianceTableAdapter();
        DataTable dtApplianceType = new DataTable();
       

        public AdminAppliance()
        {
            InitializeComponent();
          FormHelper.Appliance.ApplianceFormHelper.SetFormSize(this);
            Empty.FalseVisible.ApplianceTypeFV.falseVisible(lblPriceErr,lblApplianceNameErr, lblAvaliableQuantityErr, lblApplianceTNameErr, 
                lblPowerUsageErr,lblApplianceDetailErr, lblStatusErr, lblTypicalUsageErr,lblModelErr,lblBrandErr,lblColorErr);
            txtApplianceID.Text = IDHelper.ApplianceLastID.GetAutoID();
            setApplianceTypeName();

            GetApplianceInformation();
            comboColor.SelectedIndex = 0;
            btnEnable();
            //dtApplianceType = objApp.GetDataWithStatusZERO();
            //dgvApplianceView.DataSource = dtApplianceType;
            //dgvApplianceView.Refresh();
        }

        private void btnEnable()
        {
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
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
            if(txtApplianceDetail.Text == "" || txtPowerUsage.Text =="" || txtTypicalUsage.Text =="" || txtAvaliableQuantity.Text ==""
                || comboApplianceTypeName.SelectedIndex == 0 || txtModel.Text == "" && txtBrand.Text =="" || txtPrice.Text == ""
                || txtApplianceName.Text == "" || comboStatus.SelectedIndex == -1 || txtApplianceTypeID.Text == "" || comboColor.SelectedIndex ==0 )
            {
                Empty.ApplianceEmpty.requireTxt(txtApplianceName, lblApplianceNameErr, txtPowerUsage, lblPowerUsageErr, txtTypicalUsage,
                lblTypicalUsageErr, txtAvaliableQuantity, lblAvaliableQuantityErr, comboApplianceTypeName, lblApplianceTNameErr,
                txtApplianceDetail, lblApplianceDetailErr, comboStatus, lblStatusErr,txtPrice, lblPriceErr,txtBrand,
                lblBrandErr,txtModel,lblModelErr,comboColor,lblColorErr
                );
            }
            if (txtApplianceDetail.Text != "" && txtPowerUsage.Text != "" && txtTypicalUsage.Text != "" && txtAvaliableQuantity.Text != ""
                && comboApplianceTypeName.SelectedIndex > 0 && txtModel.Text != "" && txtBrand.Text != "" && txtPrice.Text != ""
                && txtApplianceName.Text != "" && comboStatus.SelectedIndex > -1 && txtApplianceTypeID.Text != "" && comboColor.SelectedIndex > 0)
            {
                string location = "F:\\KMD\\C#\\Assignment\\Rental_System\\Rental_System\\UploadImages";
                string timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");
                string fileName = txtApplianceName.Text + "_" + timestamp + ".jpg";
                string path = Path.Combine(location, fileName);
                Image image = picBox.Image;
                image.Save(path);
                try
                {
                    int AQ;
                    int P;
                    AQ = Convert.ToInt32(txtAvaliableQuantity.Text);
                    P = Convert.ToInt32(txtPrice.Text);

                    ApplianceModel AM = new ApplianceModel();
                    AM.ApplianceID = txtApplianceID.Text;
                    AM.ApplianceName = txtApplianceName.Text;
                    AM.ApplianceTypeID = txtApplianceTypeID.Text;
                    AM.AvaliableQuantity = txtAvaliableQuantity.Text;
                    AM.ApplianceDetail = txtApplianceDetail.Text;
                    AM.PowerUsage = txtPowerUsage.Text;
                    AM.Model = txtModel.Text;
                    AM.TypicalUsage = txtTypicalUsage.Text;
                    AM.Price = txtPrice.Text;
                    AM.Brand = txtBrand.Text;

                    objApp.Insert(AM.ApplianceID, AM.ApplianceTypeID, AM.ApplianceName,
                        AM.PowerUsage, AM.TypicalUsage, AM.AvaliableQuantity,
                        AM.ApplianceDetail, path, AM.Price, AM.Model, AM.Brand, comboColor.SelectedItem.ToString(),
                        comboStatus.SelectedItem.ToString());

                    TextBox[] textBoxes ={txtApplianceID,txtPrice, txtApplianceTypeID, txtApplianceName, txtPowerUsage, txtTypicalUsage,
                    txtAvaliableQuantity, txtApplianceDetail,txtModel,txtBrand};
                    ClearBox.Clear.ClearTextBoxes(textBoxes);

                    txtApplianceID.Text = IDHelper.ApplianceLastID.GetAutoID();
                    comboApplianceTypeName.SelectedIndex = 0;
                    comboColor.SelectedIndex = 0;
                    comboStatus.SelectedIndex = -1;
                    path = "";
                    picBox.Image = null;
                    MessageBox.Show("Successfully save");
                    dgvApplianceView.Refresh();
                    GetApplianceInformation();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
            }
            

           
            

          
            
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes ={txtApplianceID,txtApplianceName, txtApplianceTypeID, txtPrice, txtPowerUsage, txtTypicalUsage,
                    txtAvaliableQuantity, txtApplianceDetail,txtModel,txtBrand};
            ClearBox.Clear.ClearTextBoxes(textBoxes);

            Empty.FalseVisible.ApplianceTypeFV.falseVisible(lblPriceErr, lblApplianceNameErr, lblAvaliableQuantityErr, lblApplianceTNameErr,
              lblPowerUsageErr, lblApplianceDetailErr, lblStatusErr, lblTypicalUsageErr, lblModelErr, lblBrandErr, lblColorErr);

            txtApplianceID.Text = IDHelper.ApplianceLastID.GetAutoID();
            comboApplianceTypeName.SelectedIndex = 0;
            comboColor.SelectedIndex = 0;
            comboStatus.SelectedIndex = -1;
            picBox.Image = null;
            btnEnable();
        }

        private void setApplianceTypeName()
        {
            dtApplianceType = objAppType.GetDataWithStatusZERO();
            comboApplianceTypeName.Items.Add("Choose Appliance Type Name");

            for (int x = 0; x < dtApplianceType.Rows.Count ; x++ )
            {
                comboApplianceTypeName.Items.Add(dtApplianceType.Rows[x][1].ToString());
            }
            comboApplianceTypeName.SelectedIndex = 0;
        }

        private void comboApplianceTypeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ApplianceName = comboApplianceTypeName.SelectedItem.ToString();
            
            DataTable dt = new System.Data.DataTable();
            dt = objAppType.GetApplianceIDbyName(ApplianceName);
            //comboApplianceTypeName.SelectedIndex.ToString()
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    txtApplianceTypeID.Text = dt.Rows[0][0].ToString();
                }
            }
            else
            {
                txtApplianceTypeID.ForeColor = Color.Red;
                txtApplianceTypeID.Text = "Error : No Appliance ID found.";
                 
            }
        }

        private void picBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            PictureBox p = sender as PictureBox;

            if (p != null)
            {
                open.Filter = "(*.jpg;*.jpeg;*.png) | *.jpg;*.jpeg;*.png";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    p.Image = Image.FromFile(open.FileName);
                }
            }
        }

        private void applianceViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminSearch AS = new AdminSearch();
            AS.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Empty.ApplianceEmpty.requireTxt(txtApplianceName, lblApplianceNameErr, txtPowerUsage, lblPowerUsageErr, txtTypicalUsage,
               lblTypicalUsageErr, txtAvaliableQuantity, lblAvaliableQuantityErr, comboApplianceTypeName, lblApplianceTNameErr,
               txtApplianceDetail, lblApplianceDetailErr, comboStatus, lblStatusErr, txtPrice, lblPriceErr, txtBrand,
               lblBrandErr, txtModel, lblModelErr, comboColor, lblColorErr
               );
            string location = "F:\\KMD\\C#\\Assignment\\Rental_System\\Rental_System\\UploadImages";
            string timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");
            string fileName = txtApplianceName.Text + "_" + timestamp + ".jpg";
            string path = Path.Combine(location, fileName);
            Image image = picBox.Image;
            image.Save(path);

            try
            {
                int AQ;
                int P;
                AQ = Convert.ToInt32(txtAvaliableQuantity.Text);
                P = Convert.ToInt32(txtPrice.Text);

                ApplianceModel AM = new ApplianceModel();
                AM.ApplianceID = txtApplianceID.Text;
                AM.ApplianceName = txtApplianceName.Text;
                AM.ApplianceTypeID = txtApplianceTypeID.Text;
                AM.AvaliableQuantity = txtAvaliableQuantity.Text;
                AM.ApplianceDetail = txtApplianceDetail.Text;
                AM.PowerUsage = txtPowerUsage.Text;
                AM.Model = txtModel.Text;
                AM.TypicalUsage = txtTypicalUsage.Text;
                AM.Price = txtPrice.Text;
                AM.Brand = txtBrand.Text;

                objApp.UpdateAppliance(AM.ApplianceTypeID, AM.ApplianceName, AM.PowerUsage, AM.TypicalUsage,
                    AM.AvaliableQuantity,
                    AM.ApplianceDetail, path, comboStatus.SelectedItem.ToString(), AM.Price, AM.Model, AM.Brand,
                    comboColor.SelectedItem.ToString(),
                    AM.ApplianceID);

                MessageBox.Show("Data updated successfully.", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Additional actions after successful update (e.g., refreshing the data grid view, clearing input fields)
                // Custom method to refresh the data grid view
                // Custom method to clear input fields
                TextBox[] textBoxes ={txtApplianceID, txtApplianceTypeID, txtApplianceName, txtPowerUsage, txtTypicalUsage,
                    txtAvaliableQuantity, txtApplianceDetail,txtModel,txtBrand,txtPrice};
                ClearBox.Clear.ClearTextBoxes(textBoxes);

                txtApplianceID.Text = IDHelper.ApplianceLastID.GetAutoID();
                comboApplianceTypeName.SelectedIndex = 0;
                comboStatus.SelectedIndex = -1;
                path = "";
                picBox.Image = null;
                comboColor.SelectedIndex = 0;
                MessageBox.Show("Successfully Update");
                dgvApplianceView.Refresh();
                GetApplianceInformation();
                btnEnable();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void dgvApplianceView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Empty.FalseVisible.ApplianceTypeFV.falseVisible(lblPriceErr, lblApplianceNameErr, lblAvaliableQuantityErr, lblApplianceTNameErr,
              lblPowerUsageErr, lblApplianceDetailErr, lblStatusErr, lblTypicalUsageErr, lblModelErr, lblBrandErr, lblColorErr);
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvApplianceView.Rows[e.RowIndex];
                DataTable dt = objApp.GetDataByID(row.Cells[0].Value.ToString());
               
                if (dt.Rows.Count > 0)
                {
                    // Assuming you have text boxes named txtApplianceID, txtApplianceTypeID, txtApplianceName, etc.
                    txtApplianceID.Text = dt.Rows[0]["ApplianceID"].ToString();
                    txtApplianceTypeID.Text = dt.Rows[0]["ApplianceTypeID"].ToString();
                    txtApplianceName.Text = dt.Rows[0]["ApplianceName"].ToString();
                    txtPowerUsage.Text = dt.Rows[0]["PowerUsage"].ToString();
                    txtPrice.Text = dt.Rows[0]["Price"].ToString();
                    txtTypicalUsage.Text = dt.Rows[0]["TypicalUsage"].ToString();
                    txtAvaliableQuantity.Text = dt.Rows[0]["AvaliableQuantity"].ToString();
                    txtApplianceDetail.Text = dt.Rows[0]["ApplianceDetail"].ToString();
                    txtBrand.Text = dt.Rows[0]["Brand"].ToString();
                    txtModel.Text = dt.Rows[0]["Model"].ToString();
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnSave.Enabled = false;

                    // Assuming you have a PictureBox named picBox
                    string imagePath = dt.Rows[0]["ApplianceImage"].ToString();
                    if (File.Exists(imagePath))
                    {
                        picBox.Image = new Bitmap(imagePath);
                    }
                    else
                    {
                        picBox.Image = null; // or display a default image/error message
                    }

                    string color = dt.Rows[0]["Color"].ToString();
                    if(comboColor.Items.Contains(color))
                    {
                        comboColor.SelectedItem = color;
                    }
                    else
                    {
                        comboColor.SelectedIndex = 0;
                    }
                    // Assuming you have a combo box named comboStatus
                    string status = dt.Rows[0]["Status"].ToString();
                    if (comboStatus.Items.Contains(status))
                    {
                        comboStatus.SelectedItem = status;
                    }
                    else
                    {
                        comboStatus.SelectedIndex = -1; // or handle invalid status case
                    }

                    DataTable DT = objAppType.GetDataByID(dt.Rows[0]["ApplianceTypeID"].ToString());
                    string applianceTypeName = DT.Rows[0]["ApplianceTypeName"].ToString();

                    if (comboApplianceTypeName.Items.Contains(applianceTypeName))
                    {
                        comboApplianceTypeName.SelectedItem = applianceTypeName;
                    }
                    else
                    {
                        comboApplianceTypeName.SelectedItem = -1;
                    }
                }
            }

           

            
        }

        public void myDataGridCol()
        {
            dgvApplianceView.Columns.Add("ApplianceID", "ApplianceID");
            dgvApplianceView.Columns.Add("ApplianceName","ApplianceName");

            dgvApplianceView.Columns.Add("PowerUsage","PowerUsage");
            dgvApplianceView.Columns.Add("TypicalUsage","TypicalUsage");

            dgvApplianceView.Columns.Add("AvaliableQuantity", "AvaliableQuantity");

            //dgvApplianceView.Columns.Add("Brand", "Brand");
            //dgvApplianceView.Columns.Add("Model", "Model");
            //dgvApplianceView.Columns.Add("Color", "Color");

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imageColumn.HeaderText = "ApplianceImage";
            dgvApplianceView.Columns.Add(imageColumn);

           
        }

        public void GetApplianceInformation()
        {
            List<Image> Images = new List<Image>();
            dgvApplianceView.Rows.Clear();
            dgvApplianceView.Columns.Clear();

            DataTable dt = objApp.GetDataWithStatusZERO();
            myDataGridCol();

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

                row.CreateCells(dgvApplianceView);
                row.Cells[0].Value = dt.Rows[i]["ApplianceID"].ToString();
                row.Cells[1].Value = dt.Rows[i]["ApplianceName"].ToString();
                row.Cells[2].Value = dt.Rows[i]["PowerUsage"].ToString();
                row.Cells[3].Value = dt.Rows[i]["TypicalUsage"].ToString();
                row.Cells[4].Value = dt.Rows[i]["AvaliableQuantity"].ToString();

                //row.Cells[5].Value = dt.Rows[i]["Brand"].ToString();
                //row.Cells[6].Value = dt.Rows[i]["Model"].ToString();
                //row.Cells[7].Value = dt.Rows[i]["Color"].ToString();

                row.Cells[5].Value = image;
                

                dgvApplianceView.Rows.Add(row);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                
                objApp.UpdateApplianceStatus(txtApplianceID.Text);

                TextBox[] textBoxes ={txtApplianceID, txtApplianceTypeID, txtApplianceName, txtPowerUsage, txtTypicalUsage,
                    txtAvaliableQuantity, txtApplianceDetail,txtModel,txtBrand,txtPrice};
                ClearBox.Clear.ClearTextBoxes(textBoxes);

                txtApplianceID.Text = IDHelper.ApplianceLastID.GetAutoID();
                comboApplianceTypeName.SelectedIndex = 0;
                comboStatus.SelectedIndex = -1;
               
                comboColor.SelectedIndex = 0;
                MessageBox.Show("Successfully Delete");
                dgvApplianceView.Refresh();
                GetApplianceInformation();
                btnEnable();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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
