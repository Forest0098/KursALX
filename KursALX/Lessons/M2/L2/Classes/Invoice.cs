using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursALX.Lessons.M2.L2.Classes
{
    public class Invoice
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public int NIP { get; set; }
        public double BruttoAmount { get; set; }
        public double NettoAmount { get; set; }

        public void PresentInvoice()
        {
            Console.WriteLine($"[Invoice] Id: {Id}");
            Console.WriteLine($"\tCustomer name: {CustomerName}");
            Console.WriteLine($"\tNIP: {NIP}");
            Console.WriteLine($"\tBrutto: {BruttoAmount}");
            Console.WriteLine($"\tNetto: {NettoAmount}");
        }
    }
}
