using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursALX.Assigments.Classes
{
    public class Krowa
    {
        public string Color;
        public string Sex;
        public bool CzyDajeMleko;

        
        public Krowa(string color)
        {
            Color = color;
            Sex = "bull";
            CzyDajeMleko = false;
        }

        public Krowa(string color, bool czyDajeMleko)
        {
            Color = color;
            CzyDajeMleko = czyDajeMleko;
        }

        public Krowa(string color, string sex, bool czyDajeMleko)
        {
            Color = color;
            Sex = sex;
            CzyDajeMleko = czyDajeMleko;
        }

        public void Present()
        {
            Console.WriteLine($"Here is a new cow ");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Sex: {Sex}");
            Console.WriteLine($"Does it gives milk: {CzyDajeMleko}");
        }
    }
}
