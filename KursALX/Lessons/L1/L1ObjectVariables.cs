using KursALX.Lessons.L1.Classes;

namespace KursALX.Lessons.L1
{
    public class L1ObjectVariables
    {
        public static void Run1()
        {
            Console.WriteLine("Variables");
            Dog dog = new Dog();
            dog.Jump();
            dog.Bark();
            dog.Name = "Gustaw";
            dog.Race = "Maly Munsterlander";
            dog.Age = 4;
            Console.WriteLine("Attention here is dog " + dog.Name);
            Console.WriteLine("Race " + dog.Race);
            Console.WriteLine("Age " + dog.Age);
            Dog.Eat();
            Dog dogGustaw = new Dog();
        }

        public static void Run2()
        {
            Dog dogGustaw = new Dog();
            dogGustaw.Race = "MalyMunsterlander";
            dogGustaw.Age = 4;
            dogGustaw.Name = "Gustaw";
            dogGustaw.GoodBoi = true;
            dogGustaw.Present();
            DogOffspringStats stats = dogGustaw.Breed();
            Console.WriteLine("Number of male pups: " + stats.NumberOfMalePups);
            Console.WriteLine("Number of female pups: " + stats.NumberOfFemalePups);
            Console.WriteLine(dogGustaw.Breed());
            dogGustaw.Jump();
            dogGustaw.Bark();
            Console.WriteLine(dogGustaw.Add(2, 3));
        }

        public void WriteSmth()
        {
            Console.WriteLine("writesmth");
        }
    }
}
