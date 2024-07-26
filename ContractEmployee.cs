using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class ContractEmployee : Employee
    {
       

        public DateTime ContractDate { get; set; }
        public int Duration { get; set; } 
        public double Charges { get; set; }
        public ContractEmployee(string name, string reportingManager, DateTime contractDate, int duration, double charges)
        : base(name, reportingManager)
        {
            ContractDate = contractDate;
            Duration = duration;
            Charges = charges;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Contract Employee ID: {Id}, Name: {Name}, Reporting Manager: {ReportingManager}, Contract Date: {ContractDate.ToShortDateString()}, Duration: {Duration} months, Charges: {Charges}");
        }
    }
}
