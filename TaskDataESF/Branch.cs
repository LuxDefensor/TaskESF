using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace TaskDataESF
{
    public class Branch
    {
        private int id;
        private string name;
        private List<Department> departments;

        public Branch(int id)
        {
            this.id = id;
            departments = LoadDepartments();
        }

        public List<Department> LoadDepartments()
        {
            List<Department> result = new List<Department>();
            string sql = "select id_department, departmentname from departments where id_branch=" + id;
            DataTable table = Model.Data.GetData(sql);
            foreach (DataRow row in table.Rows)
            {
                result.Add(new Department()
                {
                    ID = (int)row[0],
                    Name = row[1].ToString()
                });
            }
            return result;
        }
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

        internal List<Department> Departments
        {
            get
            {
                return new List<Department>(departments);
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

        public void Add(Department newDepartment)
        {
            departments.Add(newDepartment);
        }
    }
}
