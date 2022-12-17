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
    public partial class DeleteManager : Form
    {
        public DeleteManager()
        {
            InitializeComponent();
        }
        HRManager hr = new HRManager();
        public void loadData()
        {
            DataTable dt = hr.Retrive();
            empDataview.DataSource = dt;
        }
        public void clear()
        {
            txtid.Text = "";
        }
        private void DeleteManager_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public bool validate()
        {
            bool isSucess = false;
            if (txtid.Text.Trim().Length < 4)
            {
                return true;
            }
            return isSucess;
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            Employee employee = new Employee();
            d = MessageBox.Show("Are You Sure You Want Delete Record ?", "..Decison Pending..", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (validate() != true)
            {
                if (d == DialogResult.Yes)
                {
                    HRManager HRManager = new HRManager();
                    HRManager.ID = Convert.ToInt32(txtid.Text);
                    bool success = HRManager.DeleteManager();
                    if (success == true)
                    {
                        MessageBox.Show("Staff Deleted !!!", "..Successful..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                        clear();

                    }
                    else if (d == DialogResult.No)
                    {
                        MessageBox.Show("Staff Delete Unsuccessfull !!!", "..Unsuccessful..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        loadData();
                        clear();
                    }
                }
                else if (d == DialogResult.No)
                {
                    clear();
                }
            }
            else
            {
                MessageBox.Show("Staff Delete Unsuccessfull !!! Select the RowHeader !!", "..Unsuccessful..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loadData();
                clear();
            }
          

        }

        private void empDataview_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txtid.Text = empDataview.Rows[RowIndex].Cells[0].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
