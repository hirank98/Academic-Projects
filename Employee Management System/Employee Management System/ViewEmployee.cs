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
    public partial class ViewEmployee : Form
    {
        public ViewEmployee()
        {
            InitializeComponent();
        }
        Employee em = new Employee();
        private void empDataview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewEmployee_Load(object sender, EventArgs e)
        {
            DataTable dt = em.Retrive();
            empDataview.DataSource = dt;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
