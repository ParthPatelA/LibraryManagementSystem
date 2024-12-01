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
        private static readonly HashSet<int> generatedIds = new HashSet<int>();
        private static readonly Random random = new Random();

        public Book(string title, string author, string genre, string yearPublished, string iSBN, int copiesAvailable, bool isAvailable)
        {
            BookId = GenerateUniqueRandomId();
            Title = title;
            Author = author;
            Genre = genre;
            YearPublished = yearPublished;
            ISBN = iSBN;
            CopiesAvailable = copiesAvailable;
            IsAvailable = isAvailable;
        }

        public static int GenerateUniqueRandomId()
        {
            int newId;

            // Keep generating until we get a unique ID
            do
            {
                newId = random.Next(1, 1000); // Generate a random ID within a range
            } while (!generatedIds.Add(newId)); // Add to HashSet, ensures uniqueness

            return newId;
        }
    }
}