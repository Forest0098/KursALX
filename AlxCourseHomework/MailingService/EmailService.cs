using AlxCourseHomework.MailingService.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlxCourseHomework.MailingService
{
    public class EmailService
    {
        public EMail eMail;
        public static void SendEmail(EMail eMail)
        {
            Console.WriteLine("\n***NEW**MESSAGE***");
            Console.WriteLine($"From: {eMail.From}");
            Console.WriteLine("******************");
            Console.WriteLine($"To: {eMail.To}");
            Console.WriteLine("******************");
            Console.WriteLine($"Subject: {eMail.Subject}");
            Console.WriteLine("******************");
            Console.WriteLine($"Message: {eMail.Message}");
            Console.WriteLine("**END*OF*MESSAGE**");
            Console.WriteLine("******************");
            //CreateNewEMail();
        }

        private static void CreateNewEMail()
        {
            Console.WriteLine("********************************");
            Console.WriteLine("**********NEW MESSAGE***********");
            Console.WriteLine("********************************");
            Console.WriteLine("Who wants to send message?: ");
            var fromWhoThisEmailIsSent = Console.ReadLine();
            Console.WriteLine("********************************");
            Console.WriteLine("Who to send to");
            var toWhoThisEmailIsSent = Console.ReadLine();
            Console.WriteLine("********************************");
            Console.WriteLine("Subject: ");
            var subjectOfTheEmail = Console.ReadLine();
            Console.WriteLine("********************************");
            var messageOfTheEmail = Console.ReadLine();

            Console.WriteLine("Send it? (Y/N): ");
            string sendThisEmailOrNo = Console.ReadLine();

            switch (sendThisEmailOrNo)
            {
                case "y":
                case "Y":
                    Console.WriteLine("Email has been sent!");
                    break;
                case "n":
                case "N":
                    Console.WriteLine("Burp");
                    break;
            }

            EMail messageNumber01 = new EMail(fromWhoThisEmailIsSent, toWhoThisEmailIsSent, subjectOfTheEmail, messageOfTheEmail);
            Console.WriteLine($"The email has been sent!\nFrom: {messageNumber01}");
        }
    }
}
