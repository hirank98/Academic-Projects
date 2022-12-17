using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Employee_Management_System
{
    class Employee : Staff
    {
        private String educationq;

        public String Educationq
        {
            get { return educationq; }
            set { educationq = value; }
        }

        //Inserting Data

        public override bool Add()
        {

            bool isSucess = false;
            Database db = new Database();
            MySqlConnection conn = db.GetConnection();
            try
            {
                string query = "INSERT INTO employee (name,dob,gender,email,nic,address,telephone,education,position,salary) VALUES(@name,@dob,@gender,@email,@nic,@address,@telephone,@education,@position,@salary) ";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@name", Name);
                cmd.Parameters.AddWithValue("@dob", DOB);
                cmd.Parameters.AddWithValue("@gender", Gender);
                cmd.Parameters.AddWithValue("@email", Email);
                cmd.Parameters.AddWithValue("@nic", NIC);
                cmd.Parameters.AddWithValue("@address", Address);
                cmd.Parameters.AddWithValue("@telephone", Telephone);
                cmd.Parameters.AddWithValue("@education", Educationq);
                cmd.Parameters.AddWithValue("@position", Position);
                cmd.Parameters.AddWithValue("@salary", Salary);

                //  conn.Open();
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
                return false;
            }
            finally
            {
                conn.Close();

            }
            return isSucess;
        }
   

        //Retrieving Data
        public DataTable Retrive()
        {
            Database db = new Database();
            MySqlConnection conn = db.GetConnection();
            DataTable dt = new DataTable();

            try
            {
                string query = "SELECT id,name,dob,gender,email,nic,address,telephone,education,position,salary FROM employee";
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
        //Updating Data
        public bool Update(Employee em)

        {
            Database db = new Database();
            bool isSucess = false;
            MySqlConnection conn = db.GetConnection();
            try
            {
                string query = "UPDATE employee SET name=@name,dob=@dob,gender=@gender,email=@email,nic=@nic,address=@address,telephone=@telephone,education=@education,position=@position,salary=@salary WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@name", Name);
                cmd.Parameters.AddWithValue("@dob", DOB);
                cmd.Parameters.AddWithValue("@gender", Gender);
                cmd.Parameters.AddWithValue("@email", Email);
                cmd.Parameters.AddWithValue("@nic", NIC);
                cmd.Parameters.AddWithValue("@address", Address);
                cmd.Parameters.AddWithValue("@telephone", Telephone);
                cmd.Parameters.AddWithValue("@education", Educationq);
                cmd.Parameters.AddWithValue("@position", Position);
                cmd.Parameters.AddWithValue("@salary", Salary);
                cmd.Parameters.AddWithValue("@id", ID);

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

       

        public bool Delete(Employee em)
        {

            bool isSucess = false;
            Database db = new Database();
            MySqlConnection conn = db.GetConnection();
            try
            {
                string query = "DELETE FROM employee WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", ID);

                //  conn.Open();
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
                return false;
            }
            finally
            {
                conn.Close();

            }
            return isSucess;
        }


    }
}

