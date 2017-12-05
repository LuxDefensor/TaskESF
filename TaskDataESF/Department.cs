using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskDataESF
{
    public class Department
    {
        private int id;
        private string name;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
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
    }
}
