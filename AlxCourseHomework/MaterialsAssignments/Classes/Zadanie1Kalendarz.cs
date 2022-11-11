using AlxCourseHomework.MaterialsAssignments.Enums;

namespace AlxCourseHomework.MaterialsAssignments.Classes
{
    public class Zadanie1Kalendarz
    {
        public Zadanie1DniTygodnia DzienTygodnia;
        public Zadanie1WszystkieMiesiace Miesiac;

        public Zadanie1Kalendarz() { }

        public Zadanie1Kalendarz(Zadanie1DniTygodnia DzienTygodnia, Zadanie1WszystkieMiesiace Miesiac)
        {
            this.DzienTygodnia = DzienTygodnia;
            this.Miesiac = Miesiac;
        }
        public void Present()
        {
            Console.WriteLine($"dzien tygodnia: {DzienTygodnia}\nmiesiac: {Miesiac}");
        }
    }
}
