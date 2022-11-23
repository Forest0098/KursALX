using KursALX.Lessons.M2.L2.Interfaces;

namespace KursALX.Lessons.M2.L2.Classes
{
    public class Hello : IHello
    {
        public void SayGoodMorning()
        {
            Console.WriteLine("Good morning.");
        }

        public void SayGoodMorning(string name)
        {
            Console.WriteLine($"Good morning {name}.");
        }

        public void SayHello()
        {
            Console.WriteLine("Hello.");
        }

        public void SayHello(string name)
        {
            Console.WriteLine($"Hello {name}.");
        }
    }
}
