using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public abstract  class Employee
    {
        private static int nextId = 1;
        public int Id { get; private set; }
        public string Name { get; set; }
        public string ReportingManager { get; set; }

        public Employee(string name, string reportingManager)
        {
            Id = nextId++;
            Name = name;
            ReportingManager = reportingManager;
        }

        public abstract void DisplayDetails();
    }
}
