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
    public partial class AddManager : Form
    {
        public AddManager()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            HRManager HRManager = new HRManager();
            HRManager.Name = txtname.Text;
            HRManager.DOB = txtdate.Text;
            HRManager.Gender = txtgender.Text;
            HRManager.Email = txtemail.Text;
            HRManager.NIC = txtnic.Text;
            HRManager.Address = txtadr.Text;
            HRManager.Telephone = txttelephone.Text;
            HRManager.Qualify = txtqualify.Text;
            HRManager.Yos = txtyos.Text;
            HRManager.Position = txtposition.Text;
            HRManager.Salary = txtsalary.Text;

         
            if (validate() != true)
            {
                bool sucess = HRManager.Add();

                if (sucess == true)
                {
                    MessageBox.Show("Staff Added !!!", "..Successful..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
                else
                {
                    MessageBox.Show("Staff Adding Failed !!!", "..Unsuccessful..", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("All Fields Required !!!","..Data Missing..",MessageBoxButtons.OK,MessageBoxIcon.Warning);
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
            txtqualify.Text = "";
            txtyos.Text = "";

        }
        public bool validate()
        {
            bool isSucess = false;
            if (txtname.Text.Trim().Length < 3 || txtdate.Text.Trim().Length == 0 || txtgender.Text.Trim().Length == 0 || txtemail.Text.Trim().Length == 0 || txtnic.Text.Trim().Length == 0 || txtadr.Text.Trim().Length == 0 || txtqualify.Text.Trim().Length == 0 || txtposition.Text.Trim().Length == 0 || txtsalary.Text.Trim().Length == 0)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtqualify_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtsalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtyos_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtposition_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pos = txtposition.Text;
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

        private void txttelephone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
    }

