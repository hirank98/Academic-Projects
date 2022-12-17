using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System
{
    class Staff
    {
        private int id;
        private String name;
        private String dob;
        private String gender;
        private String email;
        private String nic;
        private String address;
        private String telephone;
        private String position;
        private String salary;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String DOB
        {
            get { return dob; }
            set { dob = value; }
        }

        public String Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public String Email
        {
            get { return email; }
            set { email = value; }
        }
        public String NIC
        {
            get { return nic; }
            set { nic = value; }
        }
        public String Address
        {
            get { return address; }
            set { address = value; }
        }
        public String Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }
        public String Position
        {
            get { return position; }
            set { position = value; }
        }
        public String Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public virtual bool Add()
        {
            return false;
        }
        public virtual bool Delete()
        {
            return false;
        }

    }
}
