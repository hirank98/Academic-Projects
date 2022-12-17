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
    public partial class EmployeeHome : Form
    {
        public EmployeeHome()
        {
            InitializeComponent();
        }
        Database db = new Database();
        private void btnleave_Click(object sender, EventArgs e)
        {
            leavecount();
        }

        private void EmployeeHome_Load(object sender, EventArgs e)
        {
            txtid.Text = StaffLogin.SetValueForTextId;
            loadData();
            loadLeaves();
        }
        public DataTable Retrive()
        {
            MySqlConnection conn = db.GetConnection();
            DataTable dt = new DataTable();

            try
            {
                string query = "SELECT requestedate,reason,approvedstatus,createddate FROM prevleavereq WHERE empid ='" + txtid.Text + "'";
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
            leaveshistory.DataSource = dt;
        }
        public DataTable RetriveLeaves()
        {
            MySqlConnection conn = db.GetConnection();
            DataTable dt = new DataTable();

            try
            {
                string query = "SELECT leaves FROM employee WHERE id ='" + txtid.Text + "'";
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
        int leaves;
        public void leavecount()
        {
            string query = "SELECT leaves from employee where id='" + txtid.Text + "'";
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
                        leaves = Convert.ToInt32(reader[0].ToString());
                        if (leaves == 0)
                        {
                            MessageBox.Show("You can't get more leaves");
                        }
                        else
                        {
                            openChildForm(new EmpLeave());
                            
                        }
                    }

                }
            }
            // Close reader.
            catch (Exception ex)
            {
                MessageBox.Show("SQL Connection !\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public void loadLeaves()
        {
            DataTable dt = RetriveLeaves();
            avbleaves.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            leavecount();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void leaveshistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtid_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            StaffLogin sl = new StaffLogin();
            this.Hide();
            sl.Show();
        }
    }
}
