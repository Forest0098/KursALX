using KursALX.Assigments.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursALX.Assigments
{
    public class ConstructorWsi
    {
        public static void Run()
        {
            var krowa = new Krowa("black", "bull", false);

            var blackBull = new Krowa("black", "bull", false);

            var brownCow = new Krowa("brown", false);

            var blackAndWhiteCow = new Krowa("black and white", true);

            krowa.Present();
        }
    }
}