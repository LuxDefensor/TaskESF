using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Energosphere;

namespace TaskDataESF
{
    public class Task
    {
        private Point point;
        private List<TaskStep> steps;
        private int id;

        public Task(int id)
        {
            this.id = id;
            steps = new List<TaskStep>();
        }

        public Point Point
        {
            get
            {
                return point;
            }

            set
            {
                point = value;
            }
        }

        public List<TaskStep> Steps
        {
            get
            {
                return new List<TaskStep>(steps);
            }
        }

        public int Id
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

        public void AddStep(TaskStep newStep)
        {
            steps.Add(newStep);
        }
    }
}
