using AlxCourseHomework.MaterialsAssignments.Enums;
using AlxCourseHomework.MaterialsAssignments.Classes;

namespace AlxCourseHomework.MaterialsAssignments
{
    public class Zadanie1DodawanieNowegoCzlowieka
    {
        public static void NiechSieStanieCzlowiek()
        {
            FunkcjaTworzacaCzlowieka();
            KtoregoDniaSieNarodzilCzlowiek();
        }

        public static void FunkcjaTworzacaCzlowieka()
        {
            var czlowiek = new Zadanie1Czlowiek("Marian", "Nowak", 47, 1.78, "mezczyzna", 750731696969);
            czlowiek.Present(); //czesc pierwsza zadania, wyswietlanie danych o czlowieku
            czlowiek.Present2AfterIntConversion(); //czesc druga zadania, wyswietlanie danych o czlowieku po konwersji doubla na int 
        }

        public static void KtoregoDniaSieNarodzilCzlowiek()
        {
            var kalendarz = new Zadanie1Kalendarz(Zadanie1DniTygodnia.SOBOTA, Zadanie1WszystkieMiesiace.LISTOPAD);
            kalendarz.Present();
        }
    }
}
