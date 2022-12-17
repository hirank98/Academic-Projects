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
    public partial class Staffadd : Form
    {
        public Staffadd()
        {
            InitializeComponent();
        }
        Employee employee = new Employee();

        private void btnadd_Click(object sender, EventArgs e)
        {

            employee.Name = txtname.Text;
            employee.DOB = txtdate.Text;
            employee.Gender = txtgender.Text;
            employee.Email = txtemail.Text;
            employee.NIC = txtnic.Text;
            employee.Address = txtadr.Text;
            employee.Telephone = txttelephone.Text;
            employee.Educationq = txted.Text;
            employee.Position = txtposition.Text;
            employee.Salary = txtsalary.Text;



            if (validate() != true)
            {
                bool sucess = employee.Add();

                if (sucess == true)
                {
                    MessageBox.Show("Done", "Goood", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
                else
                {
                    MessageBox.Show("Fail");
                }
            }
            else
            {
                MessageBox.Show("Please,Fill All Fields");
            }

        }
        public void clear()
        {
            txtname.Text = "";
            txtadr.Text = "";
            txtdate.Text = "";
            txtemail.Text = "";
            txtgender.Text = "";
            txtnic.Text = "";
            txtposition.Text = "";
            txtsalary.Text = "";
            txttelephone.Text = "";
            txted.Text = "";

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
                    MessageBox.Show("E-mail address format is not correct.", "MojoCRM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
            return isSucess;

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clear();
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

        private void txtname_Validating(object sender, CancelEventArgs e)
        {

        }

        private void Staffadd_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
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
