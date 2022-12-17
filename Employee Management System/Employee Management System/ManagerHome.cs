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
    public partial class ManagerHome : Form
    {
        public ManagerHome()
        {
            InitializeComponent();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            Staffadd sa = new Staffadd();
            sa.Show();
        }

        private void btnleave_Click(object sender, EventArgs e)
        {
            ViewLeave vl = new ViewLeave();
            vl.Show();
        }

        private void ManagerHome_Load(object sender, EventArgs e)
        {
            txtid.Text = ManagerLogin.SetValueForTextId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new Staffadd());
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new ViewLeave());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManagerLogin ml = new ManagerLogin();
            this.Hide();
            ml.Show();
        }
    }
}
