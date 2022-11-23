using KursALX.Lessons.M2.L2.Classes;

namespace KursALX.Lessons.M2.L2
{
    public class L2GettersAndSetters
    {
        public static void Run()
        {
            var computer = new Computer();
            computer.Brand = "Dell";
            computer.ProcessorFrequency = 3.2;
            computer.NumberOfCores = 3;
            computer.Name = "My PC";
            PresentComputer(computer);
            Console.WriteLine();

            var computer1 = new Computer();
            computer1.Brand = "Dell";
            computer1.ProcessorFrequency = 10;
            computer1.NumberOfCores = 3;
            computer1.Name = "My PC";
            PresentComputer(computer);
            Console.WriteLine();
        }

        private static void PresentComputer(Computer computer)
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("*******************************************");
            Console.WriteLine($"Name: {computer.Name}");
            Console.WriteLine("*******************************************");
            Console.WriteLine($"\tProcessor frequency: {computer.ProcessorFrequency}");
            Console.WriteLine($"\tNumber of cores: {computer.NumberOfCores}");
            Console.WriteLine("*******************************************");
            Console.WriteLine($"\tBrand: {computer.Brand}");
            Console.WriteLine("*******************************************");
            Console.WriteLine("*******************************************");
        }
    }
}
