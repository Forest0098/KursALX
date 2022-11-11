using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlxCourseHomework.MailingService;
using AlxCourseHomework.MailingService.Classes;

namespace AlxCourseHomework
{
    public class Homework1Test
    {
        public static void Run()
        {
            var messageNumber01 = new EMail("Mateusz", "Andrzej", "Czy dobrze napisalem te klase?", "Panie psorze, chcialem sie zapytac o te klasy, co ja ten, no.");
            var messageNumber02 = new EMail("Appoloniusz", "Andrzej", "!", "Wziones ten kombinezon?");
            var messageNumber03 = new EMail("Bohater greckiej tragedii", "Nowozytny filozof", "Pic czy nie pic?", "O to jest pytanie!");
            var messageNumber04 = new EMail("BerbeluchaL0VER", "AncymonBimbrownictwa", "Zacier czy nastaw?", "Ktora forma jest poprawna?");
            var messageNumber05 = new EMail("UrzadSkarbowy", "Mateusz", "Co Ty nam wplacales?", "Masz sie stawic, bo my nie tolerujemy uczciwych ludzi");

            EmailService.SendEmail(messageNumber01);
            EmailService.SendEmail(messageNumber02);
            EmailService.SendEmail(messageNumber03);
            EmailService.SendEmail(messageNumber04);
            EmailService.SendEmail(messageNumber05);
        }
    }
}
