using System;

namespace KalkulatorALX
{
    public class Calculator 
    {
        public void Run()
        {
            Console.WriteLine("Running calculator...\n");
            Console.WriteLine("Choose operation: ");
            Console.WriteLine("+\taddition");
            Console.WriteLine("-\tsubstraction");
            Console.WriteLine("*\tmultiplication");
            Console.WriteLine("/\tdivision");
            Console.WriteLine();
            Console.Write("Choose operation:  ");
            var operationCharacterInfo = Console.ReadKey();
            Console.WriteLine();
            Console.Write("X number: ");
            var x = Double.Parse(Console.ReadLine());
            Console.Write("Y number: ");
            var y = Double.Parse(Console.ReadLine());

            PerformOperation(operationCharacterInfo.KeyChar, x, y);

            //Console.WriteLine($"{x} + {y} = {Add(x,y)}");
            //Console.WriteLine($"{x} - {y} = {Substract(x,y)}");
            //Console.WriteLine($"{x} * {y} = {Multiply(x,y)}");
            //Console.WriteLine($"{x} / {y} = {Divide(x,y)}");
        }

        private void PerformOperation(char operationChar, double x, double y)
        {
            switch (operationChar)
            {
                case '+':
                    Console.WriteLine($"{x} + {y} = {Add(x,y)}");
                    break;
                case '-':
                    Console.WriteLine($"{x} - {y} = {Substract(x, y)}");
                    break;
                case '*':
                    Console.WriteLine($"{x} * {y} = {Substract(x, y)}");
                    break;
                case '/':
                    Console.WriteLine($"{x} / {y} = {Substract(x, y)}");
                    break;
                default:
                    Console.WriteLine("Invalid operation...");
                    break;
            }
        }

        private double Add(double x, double y)
        {
            return x + y;
        }

        public double Substract(double x, double y)
        {
            return x - y;
        }

        public double Multiply(double x, double y)
        {
            return x * y;
        }

        public double Divide(double x, double y)
        {
            return x / y;
        }
    }
}
