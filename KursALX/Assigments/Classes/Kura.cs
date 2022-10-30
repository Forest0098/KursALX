using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursALX.Assigments.Classes
{
    public class Kura
    {
        public int IloscKur;
        public int IleJestJajek;

        public Kura() { }

        public Kura(int iloscKur, int ileJestJajek)
        {
            IloscKur = iloscKur;
            IleJestJajek = ileJestJajek;
        }

        public static void SiadlaKuraNaGrzedzie()
        {
            Console.WriteLine("Siadla kura na grzedzie");
        }

        public void KoKoKo()
        {
            Console.WriteLine("Ko Ko Ko");
        }

        public void Present()
        {
            Console.WriteLine($"Na podworku biega az {IloscKur}");
            KoKoKo();
            SiadlaKuraNaGrzedzie();
            Console.WriteLine($"A zniosly tyle jajek {IleJestJajek}");
        }
    }
}
