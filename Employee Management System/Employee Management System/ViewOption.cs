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
    public partial class ViewOption : Form
    {
        public ViewOption()
        {
            InitializeComponent();
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            ViewEmployee ve = new ViewEmployee();
            ve.Show();
        }

        private void btnmanager_Click(object sender, EventArgs e)
        {
            ViewManager vm = new ViewManager();
            vm.Show();
        }
    }
}
