using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class PayrollEmployee : Employee
    {
        public DateTime JoiningDate { get; set; }
        public int Experience { get; set; }
        public double BasicSalary { get; set; }

        public double DA {  get; set; }
        public double HRA { get; private set; }
        public double PF { get; private set; }

        public PayrollEmployee(string name, string reportingManager, DateTime joiningDate, int experience, double basicSalary)
            : base(name, reportingManager)
        {
            JoiningDate = joiningDate;
            Experience = experience;
            BasicSalary = basicSalary;
            CalculateAllowances();
        }

        private void CalculateAllowances()
        {
            if (Experience > 10)
            {
                DA = BasicSalary * 10/100;
                HRA = BasicSalary * 8.5/100;
                PF = 6200;
            }
            else if (Experience > 7)
            {
                DA = BasicSalary * 70/100;
                HRA = BasicSalary * 6.5/100;
                PF = 4100;
            }
            else if (Experience > 5)
            {
                DA = BasicSalary * 4.1/100;
                HRA = BasicSalary * 3.8/100;
                PF = 1800;
            }
            else
            {
                DA = BasicSalary * 1.9/100;
                HRA = BasicSalary * 2.0/100;
                PF = 1200;
            }
        }

        public double CalculateNetSalary()
        {
            return BasicSalary + DA + HRA - PF;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Payroll Employee ID: {Id}, Name: {Name}, Reporting Manager: {ReportingManager}, Joining Date: {JoiningDate.ToShortDateString()}, Experience: {Experience} years, Basic Salary: {BasicSalary:C}, DA: {DA}, HRA: {HRA}, PF: {PF}, Net Salary: {CalculateNetSalary()}");
        }
    }
}
