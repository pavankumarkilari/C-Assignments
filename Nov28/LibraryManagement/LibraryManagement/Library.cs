using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Library
    {
        List<Book> bookList = new List<Book>();

        public Library()
        {
            Book Book01 = new Book
            {
                BookId = 101,
                Title = "Avatar",
                Genre = "Science fiction",
                Author = "James Cameron",
                IsAvailable = true
            };
            Book Book02 = new Book
            {
                BookId = 102,
                Title = "Bahubali",
                Genre = "Historical fiction",
                Author = "S. S. Rajamouli",
                IsAvailable = true
            };
            Book Book03 = new Book
            {
                BookId = 103,
                Title = "Salaar",
                Genre = "Action",
                Author = "Prasanth Neel",
                IsAvailable = false
            };
            bookList.AddRange(new Book[] { Book01, Book02, Book03 });
        }
        public void AddBook()
        {
            Console.Write("Enter book Id: ");
            int Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter book title: ");
            string title = Console.ReadLine();
            Console.Write("Enter book Genre: ");
            string genre  = Console.ReadLine();
            Console.Write("Enter book Author: ");
            string author = Console.ReadLine();
            Console.Write("Enter the book Is Available or Not?(true / false): ");
            bool available = bool.Parse(Console.ReadLine());
            Book newBook = new Book
            {
                BookId = Id,
                Title = title,
                Genre = genre,
                Author = author,
                IsAvailable = available
            };
            bookList.AddRange(new Book[] { newBook });
        }
        public void ViewAllBooks()
        {
            foreach ( Book book in bookList )
            {
                Console.WriteLine($"Book Id = {book.BookId}, Title = {book.Title}, Genre = {book.Genre}, Author = {book.Author}, Is Available = {book.IsAvailable}");
            }
        }
        public void SearchBookById()
        {
            Console.WriteLine("Enter the book Id to search: ");
            int id = Convert.ToInt32(Console.ReadLine());
            bool found =false;
            foreach ( Book book in bookList )
            {
                if (id == book.BookId)
                {
                    found = true;
                    Console.WriteLine($"Book Id = {book.BookId}, Title = {book.Title}, Genre = {book.Genre}, Author = {book.Author}, Is Available = {book.IsAvailable}");
                }
            }
            if (found == false)
            {
                Console.WriteLine($"Book is not available with the id: {id}");
            }

        }
        public void SearchBookByTitle()
        {
            Console.WriteLine("Enter the book title to search: ");
            string title = Console.ReadLine();
            bool found = false;
            foreach (Book book in bookList)
            {
                if (title == book.Title)
                {
                    found = true;
                    Console.WriteLine($"Book Id = {book.BookId}, Title = {book.Title}, Genre = {book.Genre}, Author = {book.Author}, Is Available = {book.IsAvailable}");
                }
            }
            if(found == false)
            {
                Console.WriteLine($"Book is not available with the title: {title}");
            }
        }
    }
}
