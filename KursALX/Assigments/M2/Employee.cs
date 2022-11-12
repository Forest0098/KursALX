using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursALX.Assigments.M2
{
    public class Employee
    {
        public string Name;
        public double SallaryPerMonth;
        public int InternshipInMonths;

        public Employee(string name, double sallary, int internship)
        {
            Name = name;
            SallaryPerMonth = sallary;
            InternshipInMonths = internship;
        }           
    }
}
