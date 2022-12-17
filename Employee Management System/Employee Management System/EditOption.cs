using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class EditOption : Form
    {
        public EditOption()
        {
            InitializeComponent();
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            EditEmployee ee = new EditEmployee();
            ee.Show();
        }

        private void btnmanager_Click(object sender, EventArgs e)
        {
            EditManagers em = new EditManagers();
            em.Show();
        }
    }
}
