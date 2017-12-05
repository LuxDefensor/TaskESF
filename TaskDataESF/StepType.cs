using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskDataESF
{
    public class StepType
    {
        private string name;
        private int id;
        private bool allowedToManager;
        private bool allowedToTechnician;
        private bool opensTask;
        private bool closesTask;

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

        public bool AllowedToManager
        {
            get
            {
                return allowedToManager;
            }

            set
            {
                allowedToManager = value;
            }
        }

        public bool AllowedToTechnician
        {
            get
            {
                return allowedToTechnician;
            }

            set
            {
                allowedToTechnician = value;
            }
        }

        public bool OpensTask
        {
            get
            {
                return opensTask;
            }

            set
            {
                opensTask = value;
            }
        }

        public bool ClosesTask
        {
            get
            {
                return closesTask;
            }

            set
            {
                closesTask = value;
            }
        }
    }
}
