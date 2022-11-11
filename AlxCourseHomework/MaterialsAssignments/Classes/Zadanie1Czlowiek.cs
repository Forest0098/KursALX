using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlxCourseHomework.MaterialsAssignments.Classes
{
    internal class Zadanie1Czlowiek
    {
        string Imie;
        string Nazwisko;
        int Wiek;
        double Wzrost;
        string Plec;
        long PESEL;

        public Zadanie1Czlowiek() { }

        public Zadanie1Czlowiek(string imie, string nazwisko, int wiek, double wzrost, string plec, long pesel)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Wiek = wiek;
            Wzrost = wzrost;
            Plec = plec;
            PESEL = pesel;
        }

        public void Present()
        {
            Console.WriteLine($"Niech sie stanie czlowiek!\n" +
                $"Imie: {Imie}\nNazwisko: {Nazwisko}\nWiek: {Wiek}\n" +
                $"Wzrost: {Wzrost}\nPlec: {Plec}\nPESEL: {PESEL}\n");
        }

        public void Present2AfterIntConversion()
        {
            int wzrostInt = Convert.ToInt32(Wzrost);
            Console.WriteLine($"Niech sie stanie czlowiek!\n" +
                $"Imie: {Imie}\nNazwisko: {Nazwisko}\nWiek: {Wiek}\n" +
                $"Wzrost: {wzrostInt}\nPlec: {Plec}\nPESEL: {PESEL}\n");
        }
    }
}
