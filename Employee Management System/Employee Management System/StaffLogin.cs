using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using ComponentFactory.Krypton.Toolkit;

namespace Employee_Management_System
{
    public partial class StaffLogin : KryptonForm
    {
        public StaffLogin()
        {
            InitializeComponent();
        }

        Database db = new Database();

        public static string SetValueForTextId = "";
        string hash;
        public void Encrypt()
        {
            string password = txtpass.Text;

            using (var md5Hash = MD5.Create())
            {

                var sourceBytes = Encoding.UTF8.GetBytes(password);
                var hashBytes = md5Hash.ComputeHash(sourceBytes);
                hash = BitConverter.ToString(hashBytes).Replace("-", string.Empty);
            }
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            Encrypt();
            login();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            StaffSignup ss = new StaffSignup();
            this.Hide();
            ss.ShowDialog();
        }
        public void login()
        {
            String query = "SELECT * FROM staffsignup WHERE id = '" + txtempid.Text + "' AND password = '" + hash + "'";

            MySqlConnection conn = db.GetConnection();
            MySqlCommand commandb = new MySqlCommand(query, conn);
            MySqlDataReader reader;

            try
            {

                reader = commandb.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        SetValueForTextId = txtempid.Text;
                        EmployeeHome eh = new EmployeeHome();
                        this.Hide();
                        eh.Show();

                    }

                }
                else
                {
                   
                    DialogResult result = MessageBox.Show("Something went wrong!! Please try again", "Unsuccessfull Login", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    

                    if (result == DialogResult.Cancel)
                    {
                        this.Close();
                    }
                    else if (result == DialogResult.Retry)
                    {

                        StaffLogin sl = new StaffLogin();
                        sl.ShowDialog();

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Connection !\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void password_CheckedChanged(object sender, EventArgs e)
        {
            if (password.Checked)
            {
                txtpass.PasswordChar = '\0';

                var check_box = (CheckBox)sender;
                check_box.Text = "Hide";


            }
            else
            {
                txtpass.PasswordChar = '*';
                var check_box = (CheckBox)sender;
                check_box.Text = "Show";
            }
        }

        private void StaffLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.Show();
        }
    }
}
