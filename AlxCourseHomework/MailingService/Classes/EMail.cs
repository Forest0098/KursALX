using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlxCourseHomework.MailingService.Classes
{
    public class EMail
    {
        public string From;
        public string To;
        public string Subject;
        public string Message;

        public EMail() { }

        public EMail(string from, string to, string subject, string message)
        {
            From = from;
            To = to;
            Subject = subject;
            Message = message;
        }
    }
}
