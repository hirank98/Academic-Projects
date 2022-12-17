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
    class HRManager :Staff 
    {
        Database db = new Database();

        private String qualify;
        private String yos;

        public String Qualify
        {
            get { return qualify; }
            set { qualify = value; }
        }
        public String Yos
        {
            get { return yos; }
            set { yos = value; }
        }


        public override bool Add()
        {

            bool isSucess = false;
            
            MySqlConnection conn = db.GetConnection();
            try
            {
                string query = "INSERT INTO manager (name,dob,gender,email,nic,address,telephone,qualifications,yos,position,salary) VALUES(@name,@dob,@gender,@email,@nic,@address,@telephone,@qualifications,@yos,@position,@salary) ";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@name", Name);
                cmd.Parameters.AddWithValue("@dob", DOB);
                cmd.Parameters.AddWithValue("@gender", Gender);
                cmd.Parameters.AddWithValue("@email", Email);
                cmd.Parameters.AddWithValue("@nic", NIC);
                cmd.Parameters.AddWithValue("@address", Address);
                cmd.Parameters.AddWithValue("@telephone", Telephone);
                cmd.Parameters.AddWithValue("@qualifications", Qualify);
                cmd.Parameters.AddWithValue("@yos", Yos);
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
        public DataTable Retrive()
        {
            Database db = new Database();
            MySqlConnection conn = db.GetConnection();
            DataTable dt = new DataTable();

            try
            {
                string query = "SELECT id,name,dob,gender,email,nic,address,telephone,qualifications,yos,position,salary FROM manager";
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
        public bool Update()

        {
            Database db = new Database();
            bool isSucess = false;
            MySqlConnection conn = db.GetConnection();
            try
            {
                string query = "UPDATE manager SET name=@name,dob=@dob,gender=@gender,email=@email,nic=@nic,address=@address,telephone=@telephone,qualifications=@qualifications,yos=@yos,position=@position,salary=@salary WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@name", Name);
                cmd.Parameters.AddWithValue("@dob", DOB);
                cmd.Parameters.AddWithValue("@gender", Gender);
                cmd.Parameters.AddWithValue("@email", Email);
                cmd.Parameters.AddWithValue("@nic", NIC);
                cmd.Parameters.AddWithValue("@address", Address);
                cmd.Parameters.AddWithValue("@telephone", Telephone);
                cmd.Parameters.AddWithValue("@qualifications", Qualify);
                cmd.Parameters.AddWithValue("@yos", Yos);
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

        public bool DeleteManager()
        {

            bool isSucess = false;
            Database db = new Database();
            MySqlConnection conn = db.GetConnection();
            try
            {
                string query = "DELETE FROM manager WHERE id=@id";
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

