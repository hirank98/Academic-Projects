﻿using System;
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
    public partial class ViewManager : Form
    {
        public ViewManager()
        {
            InitializeComponent();
        }
        HRManager HRManager = new HRManager();
        private void ViewManager_Load(object sender, EventArgs e)
        {
            DataTable dt = HRManager.Retrive();
            empDataview.DataSource = dt;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void empDataview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
