//Creating Classes and Object
using System;
namespace Exercise2_01
{
    class Program
    {
        public static void Main(String[] args)
        {
            Books book1 = new Books();
            book1.Author = "New Writer";
            book1.Title = "First Book";
            book1.Publised = "Publisher";
            book1.Description = "";

            Books book2 = new Books();
            book2.Author = "New Writer";
            book2.Title = "Second Book";
            book2.Publised = "Publisher";
            book2.Description = "Interesting read";

            Print(book1);
            Print(book2);
        }
        public static void Print(Books book)
        {
            Console.WriteLine("Book1 is {0}. Its Author is {1} Publisher by the {2} and Description is {3}", book.Title, book.Author, book.Publised, book.Description);
        }
    }

public class Books
    {
        public string Author;
        public string Title;
        public string Publised;
        public string Description;
    }

}