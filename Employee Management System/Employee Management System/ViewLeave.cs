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
    public partial class ViewLeave : Form
    {
        public ViewLeave()
        {
            InitializeComponent();
        }
        Database db = new Database();

        private void btnaccept_Click(object sender, EventArgs e)
        {
            Accept();
            Status();
            BackLeave();
            DelLeave();
            loadData();
            clear();
        }
        public DataTable Retrive()
        {
            MySqlConnection conn = db.GetConnection();
            DataTable dt = new DataTable();

            try
            {
                string query = "SELECT * FROM leaverequests";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public void loadData()
        {
            DataTable dt = Retrive();
            leaveview.DataSource = dt;
        }

        private void ViewLeave_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public bool Accept()

        {
            bool isSucess = false;
            MySqlConnection conn = db.GetConnection();
            try
            {
                //  UPDATE Orders SET Quantity = Quantity + 1 WHERE...
                string query = "UPDATE employee SET leaves = leaves - 1 WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", txtid.Text);

                int row = cmd.ExecuteNonQuery();



                if (row > 0)
                {
                    isSucess = true;
                }
                else
                {
                    isSucess = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSucess;
        }

        public bool Status()

        {
            bool isSucess = false;
            MySqlConnection conn = db.GetConnection();
            try
            {

                string query = "UPDATE leaverequests SET approvedstatus = 'Accepted' WHERE emid=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", txtid.Text);

                int row = cmd.ExecuteNonQuery();



                if (row > 0)
                {
                    isSucess = true;
                }
                else
                {
                    isSucess = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSucess;
        }
        public bool BackLeave()

        {
            bool isSucess = false;
            MySqlConnection conn = db.GetConnection();
            try
            {


                string query = "INSERT INTO prevleavereq SELECT * FROM leaverequests WHERE emid=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", txtid.Text);

                int row = cmd.ExecuteNonQuery();



                if (row > 0)
                {
                    isSucess = true;
                }
                else
                {
                    isSucess = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSucess;
        }
        public bool DelLeave()

        {
            bool isSucess = false;
            MySqlConnection conn = db.GetConnection();
            try
            {

                string query = "DELETE FROM leaverequests WHERE emid=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", txtid.Text);

                int row = cmd.ExecuteNonQuery();



                if (row > 0)
                {
                    isSucess = true;
                }
                else
                {
                    isSucess = false;
                }



                if (row > 0)
                {
                    isSucess = true;
                }
                else
                {
                    isSucess = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSucess;
        }

        public bool Decline()

        {
            bool isSucess = false;
            MySqlConnection conn = db.GetConnection();
            try
            {
                //  UPDATE Orders SET Quantity = Quantity + 1 WHERE...
                string query = "UPDATE employee SET leaves = leaves - 0 WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", txtid.Text);

                int row = cmd.ExecuteNonQuery();



                if (row > 0)
                {
                    isSucess = true;
                }
                else
                {
                    isSucess = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSucess;
        }

        public bool DecStatus()

        {
            bool isSucess = false;
            MySqlConnection conn = db.GetConnection();
            try
            {

                string query = "UPDATE leaverequests SET approvedstatus = 'Declined' WHERE emid=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", txtid.Text);

                int row = cmd.ExecuteNonQuery();



                if (row > 0)
                {
                    isSucess = true;
                }
                else
                {
                    isSucess = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSucess;
        }

        public void clear()
        {
            txtid.Text = "";
        }

        private void btndecline_Click(object sender, EventArgs e)
        {
            Decline();
            DecStatus();
            BackLeave();
            DelLeave();
            loadData();
            clear();

        }

        private void leaveview_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txtid.Text = leaveview.Rows[RowIndex].Cells[1].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
