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
    public partial class EditEmployee : Form
    {
        public EditEmployee()
        {
            InitializeComponent();
        }
        Employee em = new Employee();

        public void loadData()
        {
            DataTable dt = em.Retrive();
            empDataview.DataSource = dt;
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            em.ID = int.Parse(txtid.Text);
            em.Name = txtname.Text;
            em.DOB = txtdate.Text;
            em.Gender = txtgender.Text;
            em.Email = txtemail.Text;
            em.NIC = txtnic.Text;
            em.Address = txtadr.Text;
            em.Telephone = txttelephone.Text;
            em.Educationq = txted.Text;
            em.Position = txtposition.Text;
            em.Salary = txtsalary.Text;

            if (validate() != true)
            {

                bool sucess = em.Update(em);
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
            txted.Text = "";
            txtnic.Text = "";
            txtposition.Text = "";
            txtsalary.Text = "";
            txttelephone.Text = "";

        }
        public bool validate()
        {
            bool isSucess = false;
            if (txtname.Text.Trim().Length < 3 || txtdate.Text.Trim().Length == 0 || txtgender.Text.Trim().Length == 0 || txtemail.Text.Trim().Length == 0 || txtnic.Text.Trim().Length == 0 || txtadr.Text.Trim().Length == 0 || txted.Text.Trim().Length == 0 || txtposition.Text.Trim().Length == 0 || txtsalary.Text.Trim().Length == 0)
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
                    return true;
                }
            }
            return isSucess;

        }

        private void EditEmployee_Load(object sender, EventArgs e)
        {
            loadData();
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
            txted.Text = empDataview.Rows[RowIndex].Cells[8].Value.ToString();
            txtposition.Text = empDataview.Rows[RowIndex].Cells[9].Value.ToString();
            txtsalary.Text = empDataview.Rows[RowIndex].Cells[10].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtposition_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pos = txtposition.Text;
            if (pos == "Clerk")
            {
                int sal = 10000;
                txtsalary.Text = sal.ToString(); ;
            }
            else if (pos == "Accountant")
            {
                int sal = 15000;
                txtsalary.Text = sal.ToString(); ;
            }
            if (pos == "Staff Assistant")
            {
                int sal = 20000;
                txtsalary.Text = sal.ToString(); ;
            }
        }

        private void txttelephone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
    }

