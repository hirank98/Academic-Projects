using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System
{
    class Account
    {
        private int id;
        private String name;
        private String password;
        private String email;


        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public String Password
        {
            get { return password; }
            set { password = value; }
        }
        public String Email
        {
            get { return email; }
            set { email = value; }
        }

    }
}
