using KursALX.Assigments.M2.L2;

namespace KursALX.Assigments.M2.L2
{
    public class BookStorageApp
    {
        public static void Run()
        {
            Console.WriteLine("***************************************");
            Console.WriteLine("***Witamy w naszej malej bibliotece!***");
            Console.WriteLine("***************************************");
            Console.WriteLine("***********Co chcesz zrobic?***********");

            char actionToPerform = 'y';

            do
            {
                KeyRulesReminder();
                Console.WriteLine("*************PRESS*BUTTON**************");
                actionToPerform = Console.ReadKey().KeyChar;
                switch (actionToPerform)
                {
                    case '1':
                        AddBookToStorage();
                        break;
                    case '2':
                        ShowBooksLists();
                        break;
                    default:
                        WrongButtonPrompt();
                        break;
                }
            } while (actionToPerform != 'q');

            static void KeyRulesReminder()
            {
                Console.WriteLine("***************************************");
                Console.WriteLine("***** 1 - dodac ksiazke");
                Console.WriteLine("***** 2 - sprawdz stan magazynowy");
                Console.WriteLine("***** q - wyjdz z programu.");
                Console.WriteLine("***************************************");
            }

            static void AddBookToStorage()
            {
                Console.WriteLine("***************************************");
                Console.WriteLine("**********Dodawanie Ksiazki************");
                Console.WriteLine("***************************************");
                BookStorageService.AddBook();
            }

            static void ShowBooksLists()
            {
                Console.WriteLine("***************************************");
                Console.WriteLine("*********Sprawdzanie magazynu**********");
                Console.WriteLine("***************************************");
                BookStorageService.ShowBooksLists();
            }
            
            static void WrongButtonPrompt()
            {
                Console.WriteLine("*************WRONG*BUTTON**************");
                Console.WriteLine("********* wybierz 1, 2 lub q **********");
            }
        }
    }
}
