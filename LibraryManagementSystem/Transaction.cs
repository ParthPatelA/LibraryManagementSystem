using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Transaction
    {
        public int TransactionId { get; set; }
        public int BookId { get; set; }
        public int CustomerId { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime? ReturnDate { get; set; }

        public Transaction(int transactionId, int bookId, int customerId, DateTime borrowDate)
        {
            TransactionId = transactionId;
            BookId = bookId;
            CustomerId = customerId;
            BorrowDate = borrowDate;
            ReturnDate = null;
        }

        public void MarkAsReturned()
        {
            ReturnDate = DateTime.Now;
        }
    }
}
