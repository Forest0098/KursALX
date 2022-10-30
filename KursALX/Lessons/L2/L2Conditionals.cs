using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursALX.Lessons.L2
{
    public class L2Conditionals
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            var number = Int32.Parse(Console.ReadLine());
            Console.Write("Enter first limit: ");
            var limit1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter upper limit: ");
            var limit2 = Int32.Parse(Console.ReadLine());

            ChecNumberWithinLimits(number, limit1, limit2);
            //CheckIfNumberIsEven(number);
        }

        private static void CheckIfNumberIsEven(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"The number {number} is an even number.");
            }
            else
            {
                Console.WriteLine($"The number {number} is an odd number.");
            }
        }

        private static void ChecNumberWithinLimits(int number, int limit1, int limit2)
        {
            if (number < limit1)
            {
                Console.WriteLine($"{number} is smaller than {limit1}");
            }
            else if (number > limit2)
            {
                Console.WriteLine($"{number} is greater than {limit2}");
            }
            else
            {
                Console.WriteLine($"{number} is equal to {limit1} or equal to {limit2} \nor between {limit1} and {limit2}");
            }
        }
    }
}
