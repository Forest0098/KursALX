using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursALX.Assigments.M2.L2
{
    public class Book
    {
        string BookTitle;
        string BookAuthor;
        string BookGenre;
        string BookPricePerUnit;
        string BookCoverType;

        //ew metoda prezentujaca
        public static void ShowBook(Book book)
        {
            Console.WriteLine("Tytul ksiazki: ");
            Console.WriteLine(book.BookTitle);
            Console.WriteLine("Autor ksiazki: ");
            Console.WriteLine(book.BookAuthor);
            Console.WriteLine("Gatunek: ");
            Console.WriteLine(book.BookGenre);
            Console.WriteLine("Koszt jednostkowy: ");
            Console.WriteLine(book.BookPricePerUnit);
            Console.WriteLine("Rodzaj okladki: ");
            Console.WriteLine(book.BookCoverType);
        }
    }
}
