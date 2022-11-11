using AlxCourseHomework.MaterialsAssignments.Classes;

namespace AlxCourseHomework.MaterialsAssignments
{
    public class Zadanie2Matematyka
    {
        public static void Run()
        {
            UruchomZadanieZFunkcja();
            UruchomZadanieZPrawemDeMorgana();
        }

        private static void UruchomZadanieZFunkcja()
        {
            int a = 3;
            int b = 6;
            int c = 15;
            int Powiekszenie = 5;

            int wynik1 = ((a ^ b) / 2) % c;
            Console.WriteLine($"\nwynik dzialania ((a ^ b) / 2) % c : {wynik1}\n");
            Console.WriteLine($"\nczy wynik {wynik1} powiekszony o {Powiekszenie} jest wiekszy od a? \n");

            int wynik2 = (wynik1 + Powiekszenie);
            if (wynik2 < a)
            {
                Console.WriteLine("\nwynik jest mniejszy niz a");
            }
            else if (wynik2 > a)
            {
                Console.WriteLine("\nwynik jest wiekszy niz a");
            }
            else
            {
                Console.WriteLine("\nXXXXX\nerror\nXXXXX\n");
            }
        }

        private static void UruchomZadanieZPrawemDeMorgana()
        {
            Console.WriteLine("\nI prawo de Morgana\n" +
                "negacja koniunkcji jest rownowazna alternatywie negacji\n");
            var prawdoDeMorgana0 = new Zadanie2PrawoDeMorgana(true, true);
            prawdoDeMorgana0.RunPrawoDeMorgana();
            var prawdoDeMorgana1 = new Zadanie2PrawoDeMorgana(false, true);
            prawdoDeMorgana1.RunPrawoDeMorgana();
            var prawdoDeMorgana2 = new Zadanie2PrawoDeMorgana(false, false);
            prawdoDeMorgana2.RunPrawoDeMorgana();
            var prawdoDeMorgana3 = new Zadanie2PrawoDeMorgana(true, false);
            prawdoDeMorgana3.RunPrawoDeMorgana();
        }
    }
}
