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

namespace Employee_Management_System
{
    class ManagerAccount : Account
    {
        private String position;
        private String cpassword;



        public String Position
        {
            get { return position; }
            set { position = value; }
        }
        public String CPassword
        {
            get { return cpassword; }
            set { cpassword = value; }
        }




        Database db = new Database();

        public bool Idcheck()
        {
            bool isSucess = false;
            MySqlConnection conn = db.GetConnection();
            string query = "SELECT * FROM manager WHERE id=@id";
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
            return isSucess;
        }
        public bool signup()
        {
            bool isSucess = false;


            MySqlConnection conn = db.GetConnection();
            try
            {
                string query = "INSERT INTO manageraccount VALUES(@id,@password,@mail)";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@password", Password);
                cmd.Parameters.AddWithValue("@mail", Email);

                //conn.Open();
                int row = cmd.ExecuteNonQuery();

                if (row > 0)
                {
                    isSucess = true;
                    MessageBox.Show("Account Created Successfully");
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
            string query = "SELECT * FROM manageraccount WHERE id=@id";
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
