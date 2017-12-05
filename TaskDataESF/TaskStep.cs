using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskDataESF
{
    public class TaskStep
    {
        private StepType type;
        private DateTime date;
        private Employee employee;
        private string description;
        private int id;

        public TaskStep()
        {

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

        public StepType Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public Employee Employee
        {
            get
            {
                return employee;
            }

            set
            {
                employee = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

    }
}
