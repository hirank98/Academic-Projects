using MySql.Data.MySqlClient;
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
using ComponentFactory.Krypton.Toolkit;

namespace Employee_Management_System
{
    public partial class ManagerSignup : KryptonForm
    {
        public ManagerSignup()
        {
            InitializeComponent();
        }
        Database db = new Database();


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
        public void Idcheck()
        {

            MySqlConnection conn = db.GetConnection();
            string query = "SELECT * FROM manager WHERE id='" + txtempid.Text + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            MySqlDataReader reader;


            try
            {
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    Accountcheck();

                }
                else
                {
                    MessageBox.Show("Inavlid Employee ID", "..Error..", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public bool signup()
        {
            bool isSucess = false;


            MySqlConnection conn = db.GetConnection();
            try
            {
                string query = "INSERT INTO manageraccount VALUES(@id,@password,@mail)";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", txtempid.Text);
                cmd.Parameters.AddWithValue("@password", hash);
                cmd.Parameters.AddWithValue("@mail", txtemail.Text);

                
                int row = cmd.ExecuteNonQuery();

                if (row > 0)
                {
                    isSucess = true;
                    MessageBox.Show("Account Created Successful !!!", "..Successful..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ManagerLogin ml = new ManagerLogin();
                    ml.Show();
                }
                else
                {
                    isSucess = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Connection !\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conn.Close();

            }
            return isSucess;
        }

        public void Accountcheck()
        {

            MySqlConnection conn = db.GetConnection();
            string query = "SELECT * FROM manageraccount WHERE id='" + txtempid.Text + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            MySqlDataReader reader;


            try
            {
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    MessageBox.Show("Account Already Exists !!!", "..Data Missing..", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (validate() != true && checkPass() != true)
                    {
                        signup();
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
        public bool validate()
        {
            bool isSucess = false;
            if (txtempid.Text.Trim().Length < 3 || txtemail.Text.Trim().Length == 0 || txtpass.Text.Trim().Length == 0 || txtpass2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please Fill All Details", "..Data Missing..", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public bool checkPass()
        {
            bool isSucess = false;
            string p1 = txtpass.Text;
            string p2 = txtpass2.Text;


            if (p1 != p2)
            {
                MessageBox.Show("Password Doesn't Match !!!", "..Unsuccessful..", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return true;
            }
            else
            {

            }
            return isSucess;
        }
        private void btnSign_Click(object sender, EventArgs e)
        {
            Encrypt();
            Idcheck();
        }


        private void password_CheckedChanged(object sender, EventArgs e)
        {

            if (password.Checked)
            {
                txtpass.PasswordChar = '\0';
                txtpass2.PasswordChar = '\0';

                var check_box = (CheckBox)sender;
                check_box.Text = "Hide";


            }
            else
            {
                txtpass.PasswordChar = '\0';
                txtpass2.PasswordChar = '\0';
                var check_box = (CheckBox)sender;
                check_box.Text = "Show";
            }
        }
      
        public void clear()
        {
            txtempid.Text = "";
            txtemail.Text = "";
            txtpass.Text = "";
            txtpass2.Text = "";
            

        }

        private void ManagerSignup_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ManagerLogin ml = new ManagerLogin();
            this.Hide();
            ml.Show();
        }
    }
}
