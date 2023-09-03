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
    public partial class Start_RentalSystem : Form
    {
        public Start_RentalSystem()
        {
            InitializeComponent();
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            AdminLogin AL = new AdminLogin();
            AL.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminLogin AL = new AdminLogin();
            AL.Show();
            this.Hide();
        }

        private void User_Click(object sender, EventArgs e)
        {
            UserLogin UL = new UserLogin();
            UL.Show();
            this.Hide();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            UserLogin UL = new UserLogin();
            UL.Show();
            this.Hide();
        }

        
    }
}
