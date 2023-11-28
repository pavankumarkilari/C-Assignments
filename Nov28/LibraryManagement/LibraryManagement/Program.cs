using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            while (true)
            {
                Console.WriteLine("\nChoose an option to perform:");
                Console.WriteLine("1. Add a new book, \n2. View all books, \n3. Search a book by Id, \n4. Search a book by title \n5. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        library.AddBook();
                        break;
                    case 2:
                        library.ViewAllBooks();
                        break;
                    case 3:
                        library.SearchBookById();
                        break;
                    case 4:
                        library.SearchBookByTitle();
                        break;
                    case 5:
                        Console.WriteLine("You are choosen to exit.");
                        break;
                    default:
                        Console.WriteLine("Enter a valid option!");
                        break;
                }
                if(choice == 5)
                {
                    break;
                }
            }
        }
    }
}
