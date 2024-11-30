using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Librarian : User
    {
        public Librarian(string name, string email) : base(name, email)
        {
        }

        public void AddBook(List<Book> books, Book book)
        {
            books.Add(book);
        }

        public void RemoveBook(List<Book> books, int bookId)
        {
            books.RemoveAll(b => b.BookId == bookId);
        }

        public void GenerateReport(List<Book> books)
        {
            foreach (var book in books)
            {
                Console.WriteLine($"Book ID: {book.BookId}, Title: {book.Title}, Available: {book.IsAvailable}");
            }
        }
    }
}
