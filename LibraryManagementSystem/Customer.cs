using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Customer : User
    {
        public List<int> BorrowedBooks { get; set; }
        public Customer(string name, string email) : base(name, email)
        {
            BorrowedBooks = new List<int>();
        }

        public void BorrowBook(int bookId)
        {
            BorrowedBooks.Add(bookId);
        }

        public void RemoveBook(int bookId)
        {
            BorrowedBooks.Remove(bookId);
        }
    }
}
