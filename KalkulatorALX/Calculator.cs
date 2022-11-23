using KalkulatorALX.Interfaces;
using System;

namespace KalkulatorALX
{
    public class Calculator : ICalculator
    {
        List<char> ValidChars;
        char[] ValidOperatorArray = { '+', '-', '*', '/' };

        public Calculator()
        {
            ValidChars = new List<char>();
            ValidChars.Add('+');
            ValidChars.Add('-');
            ValidChars.Add('*');
            ValidChars.Add('/');
        }
        public void Run()
        {
            Console.WriteLine("Running calculator...\n");
            Console.WriteLine("Choose operation: ");
            Console.WriteLine("+\taddition");
            Console.WriteLine("-\tsubstraction");
            Console.WriteLine("*\tmultiplication");
            Console.WriteLine("/\tdivision");
            Console.WriteLine();
            var operationCharacterInfo = Console.ReadKey();

            while(ValidOperation(operationCharacterInfo.KeyChar)) 
            {
                operationCharacterInfo = CalculatorWaitingForKey(operationCharacterInfo);
            }
        }

        private bool ValidOperation(char operationCharacter)
        {
            return ValidOperatorArray.Contains(operationCharacter);
        }

        private ConsoleKeyInfo CalculatorWaitingForKey(ConsoleKeyInfo operationCharacterInfo)
        {
            Console.WriteLine();
            Console.Write("X number: ");
            var x = Double.Parse(Console.ReadLine());
            Console.Write("Y number: ");
            var y = Double.Parse(Console.ReadLine());
            PerformOperation(operationCharacterInfo.KeyChar, x, y);

            Console.Write("Choose operation:  ");
            operationCharacterInfo = Console.ReadKey();
            return operationCharacterInfo;
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
                    Console.WriteLine($"{x} * {y} = {Multiply(x, y)}");
                    break;
                case '/':
                    Console.WriteLine($"{x} / {y} = {Divide(x, y)}");
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

        private double Substract(double x, double y)
        {
            return x - y;
        }

        private double Multiply(double x, double y)
        {
            return x * y;
        }

        private double Divide(double x, double y)
        {
            return x / y;
        }
    }
}
