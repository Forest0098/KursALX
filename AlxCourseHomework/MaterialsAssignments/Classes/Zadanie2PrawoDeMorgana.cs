using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlxCourseHomework.MaterialsAssignments.Classes
{
    public class Zadanie2PrawoDeMorgana
    {
        public bool Pierwszy;
        public bool Drugi;

        public Zadanie2PrawoDeMorgana(bool pierwszy, bool drugi)
        {
            this.Pierwszy = pierwszy;
            this.Drugi = drugi;
        }
        public void RunPrawoDeMorgana()
        {
            if ((!Pierwszy && !Drugi) == !(Pierwszy || Drugi))
            {
                Console.WriteLine($"dla pierwszego argumentu {Pierwszy} i drugiego argumentu {Drugi} twierdzenie jest prawdziwe");
            }
            else
            {
                Console.WriteLine("\nno cos sie zesralo!");
            }
        }
    }
}
