using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System
{
    class StaffAccount : Account
    {
        Database db = new Database();

        public void Idcheck()
        {

            MySqlConnection conn = db.GetConnection();
            string query = "SELECT * FROM employee WHERE id=@id";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", ID);
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
                    MessageBox.Show("Inavild Employee ID");
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
        }

        public bool signup()
        {
            bool isSucess = false;


            MySqlConnection conn = db.GetConnection();
            try
            {
                string query = "INSERT INTO staffsignup VALUES(@id,@password,@position,@mail)";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@password", Password);
                cmd.Parameters.AddWithValue("@mail", Email);

                int row = cmd.ExecuteNonQuery();

                if (row > 0)
                {
                    isSucess = true;
                    MessageBox.Show("Account Created Successfully");
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

        public void Accountcheck()
        {

            MySqlConnection conn = db.GetConnection();
            string query = "SELECT * FROM staffsignup WHERE id=@id";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", ID);
            cmd.ExecuteNonQuery();
            MySqlDataReader reader;


            try
            {
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    MessageBox.Show("Account Already Exsists");
                }
                else
                {
                    signup();
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
        }
    }
}
