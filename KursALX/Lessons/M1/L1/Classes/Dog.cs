﻿using KursALX.Lessons.M1.L1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursALX.Lessons.M1.L1.Classes
{
    public class Dog
    {
        public string Name;
        public int Age;
        public string Race;
        public bool GoodBoi = true;

        public void Jump()
        {
            Console.WriteLine("Boing! Boing!");
        }
        public void Bark()
        {
            Console.WriteLine("Woof! Woof!");
        }
        public static void Eat()
        {
            Console.WriteLine("Omnomnom");
        }
        public int GetOlderAge()
        {
            return Age + 1;
        }
        public void GrowOlder(int numberOfYears)
        {
            Age = Age + numberOfYears;
        }

        public int Add(int x, int y)
        {
            return x + y;
        }
        public DogOffspringStats Breed()
        {
            DogOffspringStats dogOffspringStats = new DogOffspringStats();
            dogOffspringStats.NumberOfMalePups = 3;
            dogOffspringStats.NumberOfFemalePups = 7;
            return dogOffspringStats;
        }

        public void Present()
        {
            Console.WriteLine("Attention here is dog " + Name);
            Console.WriteLine("Race " + Race);
            Console.WriteLine("Age " + Age);
            Console.WriteLine("Is he a good boi?: " + GoodBoi);
        }
    }
}
