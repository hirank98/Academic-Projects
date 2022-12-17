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
using ComponentFactory.Krypton.Toolkit;

namespace Employee_Management_System
{
    public partial class AdminLogin : KryptonForm
    {
        public AdminLogin()
        {
            InitializeComponent();
        }
        String con = "datasource=127.0.0.1;port=3306;;userid=root;password=;database=ems;sslmode=none";
        public void login()
        {
            String query = "SELECT * FROM admin WHERE name = '" + txtid.Text + "' AND password = '" + txtpass.Text + "'";
            MySqlConnection dataConnection = new MySqlConnection(con);
            MySqlCommand commandb = new MySqlCommand(query, dataConnection);
            commandb.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                dataConnection.Open();
                reader = commandb.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        AdminHome ah = new AdminHome();
                        this.Hide();
                        ah.Show();

                    }

                }
                else
                {
                    string message = "Something went wrong!! Please try again";
                    string title = "Unsuccessfull Login";
                    MessageBoxButtons buttons = MessageBoxButtons.RetryCancel;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                    if (result == DialogResult.Cancel)
                    {
                        this.Close();
                    }
                    else if (result == DialogResult.Retry)
                    {

                        AdminLogin a = new AdminLogin();
                        this.Hide();
                        a.Show();
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Connection !\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dataConnection.Close();
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            login();
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

        private void AdminLogin_Load(object sender, EventArgs e)
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
