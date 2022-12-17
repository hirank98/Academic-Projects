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
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
            customizeDesign();

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            AddOption ao = new AddOption();
            ao.Show();
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {

        }

        private void btnview_Click(object sender, EventArgs e)
        {
            ViewOption vo = new ViewOption();
            vo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditOption eo = new EditOption();
            eo.Show();
        }

        #region Menu Panel
        private void customizeDesign()
        {
            panelAddStaff.Visible = false;
            panelViewStaff.Visible = false;
            panelEditStaff.Visible = false;
            panelDeleteStaff.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelAddStaff.Visible == true)
                panelAddStaff.Visible = false;
            if (panelViewStaff.Visible == true)
                panelViewStaff.Visible = false;
            if (panelEditStaff.Visible == true)
                panelEditStaff.Visible = false;
            if (panelDeleteStaff.Visible == true)
                panelDeleteStaff.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }


        #endregion

        #region Add Staff
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAddStaff);
        }

        

        private void btnAddManager_Click(object sender, EventArgs e)
        {
            openChildForm(new AddManager());
            hideSubMenu();
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            openChildForm(new Staffadd());
            hideSubMenu();
        }

        #endregion
        #region View Staff
        private void btnViewStaff_Click(object sender, EventArgs e)
        {
            showSubMenu(panelViewStaff);
        }

        private void btnViewManager_Click(object sender, EventArgs e)
        {
            openChildForm(new ViewManager());
            hideSubMenu();
        }

        private void btnViewEmp_Click(object sender, EventArgs e)
        {
            openChildForm(new ViewEmployee());
            hideSubMenu();
        }
        #endregion
        #region Edit Staff
        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            showSubMenu(panelEditStaff);
        }

        private void btnEditManager_Click(object sender, EventArgs e)
        {
            openChildForm(new EditManagers());
            hideSubMenu();
        }

        private void btnEditEmp_Click(object sender, EventArgs e)
        {
            openChildForm(new EditEmployee());
            hideSubMenu();
        }
        #endregion
        #region Delete Staff
        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDeleteStaff);
        }

        private void btnDeleteManager_Click(object sender, EventArgs e)
        {
            openChildForm(new DeleteManager());
            hideSubMenu();
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            openChildForm(new DeleteEmployee());
            hideSubMenu();
        }
        #endregion

# region Logout
        private void btnAbout_Click(object sender, EventArgs e)
        {
            AdminLogin al = new AdminLogin();
            this.Hide();
            al.Show();
            hideSubMenu();
        }
        #endregion

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

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
