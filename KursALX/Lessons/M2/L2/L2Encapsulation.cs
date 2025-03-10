﻿using CommonFunctionalities.Services;

namespace KursALX.Lessons.M2.L2
{
    public class L2Encapsulation
    {
        public static void Run()
        {
            var taxService = new TaxService();
            var income = 5000;
            var tax = taxService.Calculate(income);
            Present(tax, income);
        }

        private static void Present(double tax, double income)
        {
            Console.WriteLine($"Income: {income}");
            Console.WriteLine($"Tax: {tax}");
            Console.WriteLine($"Netto: {income - tax}");
        }
    }
}