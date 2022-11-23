using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursALX.Assigments.M2.L2
{
    public class BookStorageService
    {
        List<string> ListaKryminalow = new List<string>();
        List<string> ListaRomansidel = new List<string>();
        List<string> ListaAutobiografii = new List<string>();
        List<string> ListaHistorycznych = new List<string>();
        List<string> ListaSwierszczykow = new List<string>();

        public static void AddBook()
        {
            Console.WriteLine("Jaki to tytul? ");
            string booksTitle = Console.ReadLine();
            Console.WriteLine("Kto jest autorem? ");
            string booksAuthor = Console.ReadLine();
            Console.WriteLine("Jaki to gatunek? ");
            Console.WriteLine("1 - kryminal, 2 - romans,\n3 - autobiografia, 4 - historia,\n5 - swierszczyk: ");
            Console.WriteLine("*************PRESS*BUTTON**************");
            char booksGenre = Console.ReadKey().KeyChar;

            switch (booksGenre)
            {
                case '1':
                    Console.WriteLine();
                    break;
                case '2':
                    Console.WriteLine();
                    break;
                case '3':
                    Console.WriteLine();
                    break;
                case '4':
                    Console.WriteLine();
                    break;
                case '5':
                    Console.WriteLine();
                    break;  
            }
        }

        public static void ShowBooksLists()
        { 
        
        }
    }
}
