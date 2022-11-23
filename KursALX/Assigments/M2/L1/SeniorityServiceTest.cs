using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursALX.Assigments.M2.L1
{
    public class SeniorityServiceTest
    {
        public static void Run()
        {
            var seniorityService = new SeniorityService();

            var employee001 = new Employee("Krzysztof", 1348.32, 1);
            var employee002 = new Employee("Maciek", 5643.43, 24);
            var employee003 = new Employee("Darek", 13897.90, 47);
            var employee004 = new Employee("Arek", 16876.99, 56);
            var employee005 = new Employee("Szkudlarek", 8776.5, 9);

            seniorityService.ClearLits();

            Console.WriteLine("*************************************");
            Console.WriteLine("***Sklasyfikowani po doswiadczeniu***");
            Console.WriteLine("*************************************");

            seniorityService.ClassifySeniorityByExperience(employee001);
            seniorityService.ClassifySeniorityByExperience(employee002);
            seniorityService.ClassifySeniorityByExperience(employee003);
            seniorityService.ClassifySeniorityByExperience(employee004);
            seniorityService.ClassifySeniorityByExperience(employee005);

            Console.WriteLine("*************************************");
            Console.WriteLine("Juniors: ");
            Console.WriteLine("*************************************");
            PresentEmployees(seniorityService.JuniorEmployees);
            Console.WriteLine("*************************************");
            Console.WriteLine("Mids: ");
            Console.WriteLine("*************************************");
            PresentEmployees(seniorityService.MidEmployees);
            Console.WriteLine("*************************************");
            Console.WriteLine("Seniors: ");
            Console.WriteLine("*************************************");
            PresentEmployees(seniorityService.SeniorEmployees);
            Console.WriteLine("*************************************");

            seniorityService.ClearLits();

            Console.WriteLine("*************************************");
            Console.WriteLine("*****Sklasyfikowani po zarobkach*****");
            Console.WriteLine("*************************************");

            seniorityService.ClassifySeniorityBySalary(employee001);
            seniorityService.ClassifySeniorityBySalary(employee002);
            seniorityService.ClassifySeniorityBySalary(employee003);
            seniorityService.ClassifySeniorityBySalary(employee004);
            seniorityService.ClassifySeniorityBySalary(employee005);

            Console.WriteLine("*************************************");
            Console.WriteLine("Juniors: ");
            Console.WriteLine("*************************************");
            PresentEmployees(seniorityService.JuniorEmployees);
            Console.WriteLine("*************************************");
            Console.WriteLine("Mids: ");
            Console.WriteLine("*************************************");
            PresentEmployees(seniorityService.MidEmployees);
            Console.WriteLine("*************************************");
            Console.WriteLine("Seniors: ");
            Console.WriteLine("*************************************");
            PresentEmployees(seniorityService.SeniorEmployees);
            Console.WriteLine("*************************************");
        }



        public static void PresentEmployees(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine($"Employee: {employee.Name}\nSallary per month: {employee.SallaryPerMonth}\nInternship in months: {employee.InternshipInMonths}");
                Console.WriteLine("-------------------------------------");
            }
        }
    }
}
