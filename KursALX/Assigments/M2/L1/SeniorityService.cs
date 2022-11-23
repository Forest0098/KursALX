using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursALX.Assigments.M2.L1
{
    public class SeniorityService
    {
        public List<Employee> JuniorEmployees;
        public List<Employee> MidEmployees;
        public List<Employee> SeniorEmployees;

        public SeniorityService()
        {
            JuniorEmployees = new List<Employee>();
            MidEmployees = new List<Employee>();
            SeniorEmployees = new List<Employee>();
        }

        public void ClassifySeniorityBySalary(Employee employee)
        {
            if (employee.SallaryPerMonth < 4000)
            {
                JuniorEmployees.Add(employee);
            }
            else if (employee.SallaryPerMonth > 12000)
            {
                SeniorEmployees.Add(employee);
            }
            else
            {
                MidEmployees.Add(employee);
            }
        }

        public void ClassifySeniorityByExperience(Employee employee)
        {
            if (employee.InternshipInMonths < 12)
            {
                JuniorEmployees.Add(employee);
            }
            else if (employee.InternshipInMonths > 36)
            {
                SeniorEmployees.Add(employee);
            }
            else
            {
                MidEmployees.Add(employee);
            }
        }

        public void ClearLits()
        {
            JuniorEmployees.Clear();
            MidEmployees.Clear();
            SeniorEmployees.Clear();
        }
    }
}
