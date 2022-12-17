using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System
{
    class Database
    {
        public static String con = "datasource=localhost;port=3306;;userid=root;password=;database=ems;sslmode=none";
        public MySqlConnection GetConnection()
        {

            MySqlConnection dataConnection = new MySqlConnection(con);


            try
            {
                dataConnection.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dataConnection;
        }
    }
}
