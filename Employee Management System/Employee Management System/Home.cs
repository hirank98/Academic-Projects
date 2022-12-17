using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Employee_Management_System
{
    public partial class Home : KryptonForm
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            AdminLogin al = new AdminLogin();
            al.Show();
        }

        private void btnmanager_Click(object sender, EventArgs e)
        {
            ManagerLogin ml = new ManagerLogin();
            ml.Show();
        }

        private void btnemp_Click(object sender, EventArgs e)
        {
            StaffLogin sl = new StaffLogin();
            sl.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void txtAdmin_Click(object sender, EventArgs e)
        {
            AdminLogin al = new AdminLogin();
            this.Hide();
            al.Show();

        }

        private void txtManager_Click(object sender, EventArgs e)
        {
            ManagerLogin ml = new ManagerLogin();
            this.Hide();
            ml.Show();
        }

        private void txtEmp_Click(object sender, EventArgs e)
        {
            StaffLogin sl = new StaffLogin();
            this.Hide();
            sl.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
