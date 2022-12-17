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

namespace Employee_Management_System
{
    public partial class EmpLeave : Form
    {
        public EmpLeave()
        {
            InitializeComponent();
        }
        Database db = new Database();


        public bool apply()
        {
            bool isSucess = false;


            MySqlConnection conn = db.GetConnection();
            try
            {
                string query = "INSERT INTO leaverequests(emid,requesteddate,reason,approvedstatus) VALUES(@emid,@requesteddate,@reason,@approvedstatus)";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@emid", txtid.Text);
                cmd.Parameters.AddWithValue("@requesteddate", txtdate.Value.Date);
                cmd.Parameters.AddWithValue("@reason", txtreason.Text);
                cmd.Parameters.AddWithValue("@approvedstatus", txtstatus.Text);

                int row = cmd.ExecuteNonQuery();

                if (row > 0)
                {
                    isSucess = true;
                    MessageBox.Show("Request Sent !!!", "..Successful..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    isSucess = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conn.Close();

            }
            return isSucess;
        }
        public bool check()
        {
            bool isSucess = false;

            MySqlConnection conn = db.GetConnection();
            string query = "SELECT * FROM leaverequests WHERE emid='" + txtid.Text + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            MySqlDataReader reader;


            try
            {
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    MessageBox.Show("You have already placed a request, Please wait for the response.", "..Action Repeat..", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    apply();
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
            return isSucess;
        }
        private void btnleave_Click(object sender, EventArgs e)
        {
            check();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
