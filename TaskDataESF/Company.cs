using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace TaskDataESF
{
    public class Company
    {
        private string name;
        private int id;
        private List<Branch> branches;

        public Company(int id)
        {
            this.id = id;
            branches = LoadBranches();
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

        internal List<Branch> Branches
        {
            get
            {
                return new List<Branch>(branches);
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

        public void Add(Branch newBranch)
        {
            branches.Add(newBranch);
        }

        public List<Branch> LoadBranches()
        {
            List<Branch> result = new List<Branch>();
            string sql = "select id_branch, branchname from t_branches where id_company=" + id;
            DataTable table = Model.Data.GetData(sql);
            foreach (DataRow row in table.Rows)
            {
                result.Add(new Branch((int)row[0]) { Name = row[1].ToString() });
            }
            return result;            
        }
    }
}
