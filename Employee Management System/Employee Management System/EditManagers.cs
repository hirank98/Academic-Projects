using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Employee_Management_System
{
    public partial class EditManagers : Form
    {
        public EditManagers()
        {
            InitializeComponent();
        }
        HRManager HRManager = new HRManager();
        public void loadData()
        {
            DataTable dt = HRManager.Retrive();
            empDataview.DataSource = dt;
        }
        private void EditManagers_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            HRManager.ID = int.Parse(txtid.Text);
            HRManager.Name = txtname.Text;
            HRManager.DOB = txtdate.Text;
            HRManager.Gender = txtgender.Text;
            HRManager.Email = txtemail.Text;
            HRManager.NIC = txtnic.Text;
            HRManager.Address = txtadr.Text;
            HRManager.Telephone = txttelephone.Text;
            HRManager.Qualify= txtqualify.Text;
            HRManager.Yos = txtyos.Text;
            HRManager.Position = txtyos.Text;
            HRManager.Salary = txtsalary.Text;

            if (validate() != true)
            {

                bool sucess = HRManager.Update();
                if (sucess == true)
                {
                    MessageBox.Show("Staff Updated !!!", "..Successful..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    loadData();
                }
                else
                {
                    MessageBox.Show("Staff Updating Failed !!!", "..Unsuccessful..", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("All Fields Required !!!", "..Data Missing..", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        public void clear()
        {
            txtid.Text = "";
            txtname.Text = "";
            txtadr.Text = "";
            txtdate.Text = "";
            txtemail.Text = "";
            txtgender.Text = "";
            txtnic.Text = "";
            txtyos.Text = "";
            txtsalary.Text = "";
            txttelephone.Text = "";
            txtqualify.Text = "";
            txtyos.Text = "";
            txtposition.Text = "";
             

        }
        public bool validate()
        {
            bool isSucess = false;
            if (txtname.Text.Trim().Length < 3 || txtdate.Text.Trim().Length == 0 || txtgender.Text.Trim().Length == 0 || txtemail.Text.Trim().Length == 0 || txtnic.Text.Trim().Length == 0 || txtadr.Text.Trim().Length == 0 || txtyos.Text.Trim().Length ==0 ||txtqualify.Text.Trim().Length == 0 || txtyos.Text.Trim().Length == 0 || txtsalary.Text.Trim().Length == 0)
            {
                return true;
            }
            Regex mRegxExpression;
            if (txtemail.Text.Trim() != string.Empty)
            {
                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                if (!mRegxExpression.IsMatch(txtemail.Text.Trim()))
                {
                    MessageBox.Show("E-mail address format is not correct.", "Wrong Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("E-mail address format is not correct.", "Wrong Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
            return isSucess;

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void empDataview_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txtid.Text = empDataview.Rows[RowIndex].Cells[0].Value.ToString();
            txtname.Text = empDataview.Rows[RowIndex].Cells[1].Value.ToString();
            txtdate.Text = empDataview.Rows[RowIndex].Cells[2].Value.ToString();
            txtgender.Text = empDataview.Rows[RowIndex].Cells[3].Value.ToString();
            txtemail.Text = empDataview.Rows[RowIndex].Cells[4].Value.ToString();
            txtnic.Text = empDataview.Rows[RowIndex].Cells[5].Value.ToString();
            txtadr.Text = empDataview.Rows[RowIndex].Cells[6].Value.ToString();
            txttelephone.Text = empDataview.Rows[RowIndex].Cells[7].Value.ToString();
            txtqualify.Text = empDataview.Rows[RowIndex].Cells[8].Value.ToString();
            txtyos.Text = empDataview.Rows[RowIndex].Cells[9].Value.ToString();
            txtposition.Text = empDataview.Rows[RowIndex].Cells[10].Value.ToString();
            txtsalary.Text = empDataview.Rows[RowIndex].Cells[11].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pos = txtyos.Text;
            if (pos == "HR Manager")
            {
                int sal = 30000;
                txtsalary.Text = sal.ToString(); ;
            }
            else if (pos == "Operation Manager")
            {
                int sal = 40000;
                txtsalary.Text = sal.ToString(); ;
            }
            if (pos == "Deputy General Manager")
            {
                int sal = 50000;
                txtsalary.Text = sal.ToString(); ;
            }
        }

        private void txttelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtqualify_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
