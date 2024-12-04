using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Book
    {
        public int BookId { get; private set; } // Auto-generated ID
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string YearPublished { get; set; }
        public string ISBN { get; set; }
        public int CopiesAvailable { get; set; }
        public bool IsAvailable { get; set; } = true;

        public Book(string title, string author, string genre, string yearPublished, string iSBN, int copiesAvailable, bool isAvailable)
        {
            BookId = IdGenerator.GenerateUserId();
            Title = title;
            Author = author;
            Genre = genre;
            YearPublished = yearPublished;
            ISBN = iSBN;
            CopiesAvailable = copiesAvailable;
            IsAvailable = isAvailable;
        }
    }
}