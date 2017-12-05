using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskDataESF
{
    public class Employee 
    {
        private int id;
        private Department department;
        private string name;
        private string user;
        private bool administrator;
        private bool manager;
        private string phone1;
        private string phone2;
        private string cellPhone;
        private string email;

        #region Properties

        public Department Department
        {
            get
            {
                return department;
            }

            set
            {
                department = value;
            }
        }

        public bool Administrator
        {
            get
            {
                return administrator;
            }

            set
            {
                administrator = value;
            }
        }

        public bool Manager
        {
            get
            {
                return manager;
            }

            set
            {
                manager = value;
            }
        }

        public string Phone1
        {
            get
            {
                return phone1;
            }

            set
            {
                phone1 = value;
            }
        }

        public string Phone2
        {
            get
            {
                return phone2;
            }

            set
            {
                phone2 = value;
            }
        }

        public string CellPhone
        {
            get
            {
                return cellPhone;
            }

            set
            {
                cellPhone = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public int ID
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string User
        {
            get
            {
                return user;
            }

            set
            {
                user = value;
            }
        }

        #endregion
    }
}
