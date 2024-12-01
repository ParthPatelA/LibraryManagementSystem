using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LibraryManagementSystem
{
    internal class LibrarySystem
    {
        private static LibrarySystem instance;
        private static readonly object lockObject = new object();

        private List<Book> books = new List<Book>();
        private List<User> users = new List<User>();
        public User CurrentUser { get; set; }

        private readonly string logFilePath = "LibrarySystemLog.txt";
        private readonly string inventoryFilePath = "BookInventory.txt";

        private LibrarySystem()
        {
            if (!File.Exists(logFilePath))
                File.Create(logFilePath).Dispose();
            if (!File.Exists(inventoryFilePath))
                File.Create(inventoryFilePath).Dispose();
        }

        public static LibrarySystem GetInstance()
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new LibrarySystem();
                    }
                }
            }
            return instance;
        }

        // Log Actions with formatted date and message
        private void LogAction(string message)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(logFilePath, append: true))
                {
                    writer.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} | {message}");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Failed to write to log file: {ex.Message}");
            }
        }

        // Update Inventory File with formatted output
        private void UpdateInventoryFile()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(inventoryFilePath, append: false))
                {
                    // Write header with column names, adjusting width for readability
                    writer.WriteLine($"{"ID",-5}{"Title",-30}{"Author",-30}{"Copies Available",-15}{"ISBN",-15}");
                    writer.WriteLine(new string('-', 95)); // Add a separator line for better readability

                    foreach (var book in books)
                    {
                        // Format each line with fixed width for each property
                        writer.WriteLine($"{book.BookId,-5}{book.Title,-30}{book.Author,-30}{book.CopiesAvailable,-15}{book.ISBN,-15}");
                    }
                }
            }
            catch (IOException ex)
            {
                LogAction($"Failed to update inventory file: {ex.Message}");
            }
        }


        // 1. Add Book
        public void AddBook(Book book)
        {
            if (book == null) throw new ArgumentNullException(nameof(book));
            books.Add(book);
            LogAction($"Book added: {book.Title} (ID: {book.BookId})");
            UpdateInventoryFile();
        }

        // 2. Remove Book
        public bool RemoveBook(int bookId)
        {
            var book = books.FirstOrDefault(b => b.BookId == bookId);
            if (book == null) return false;
            books.Remove(book);
            LogAction($"Book removed: {book.Title} (ID: {bookId})");
            UpdateInventoryFile();
            return true;
        }

        // 3. Add User
        public void AddUser(User user)
        {
            if (user == null) throw new ArgumentNullException(nameof(user));
            users.Add(user);
            LogAction($"User added: {user.Name} (ID: {user.UserId})");
        }

        // 4. Remove User
        public bool RemoveUser(int userId)
        {
            var user = users.FirstOrDefault(u => u.UserId == userId);
            if (user == null) return false;
            users.Remove(user);
            LogAction($"User removed: {user.Name} (ID: {user.UserId})");
            return true;
        }

        // 5. Borrow Book
        public void BorrowBook(int bookId, int userId)
        {
            var book = books.FirstOrDefault(b => b.BookId == bookId);
            var user = users.FirstOrDefault(u => u.UserId == userId);

            if (book == null) throw new InvalidOperationException("Book not found.");
            if (user == null) throw new InvalidOperationException("User not found.");
            if (book.CopiesAvailable <= 0) throw new InvalidOperationException("No copies available.");

            book.CopiesAvailable--;
            LogAction($"Book borrowed: {book.Title} by User {user.Name} (ID: {userId})");
            UpdateInventoryFile();
        }

        // 6. Return Book
        public void ReturnBook(int bookId, int userId)
        {
            var book = books.FirstOrDefault(b => b.BookId == bookId);

            if (book == null) throw new InvalidOperationException("Book not found.");

            book.CopiesAvailable++;
            LogAction($"Book returned: {book.Title} by User ID: {userId}");
            UpdateInventoryFile();
        }

        // 7. Search Book by Title
        public List<Book> SearchBookByTitle(string title)
        {
            return books.Where(b => b.Title != null &&
                                    b.Title.IndexOf(title, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
        }

        // 8. Search Book by Author
        public List<Book> SearchBookByAuthor(string author)
        {
            return books.Where(b => b.Author != null &&
                                    b.Author.IndexOf(author, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
        }
        // 9. Search Book by Genre
        public List<Book> SearchBookByGenre(string genre)
        {
            return books.Where(b => b.Genre.Equals(genre, StringComparison.OrdinalIgnoreCase)).ToList();
        }


        // 10. Search User by Name
        public List<User> SearchUserByName(string name)
        {
            return users.Where(u => u.Name != null &&
                                    u.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
        }

        // 11. Generate Inventory Report with formatted output
        public string GenerateInventoryReport()
        {
            var report = string.Join(Environment.NewLine, books.Select(b =>
                $"{"Title:",-15} {b.Title,-30} {"Author:",-10} {b.Author,-30} {"Copies Available:",-20} {b.CopiesAvailable}"));
            LogAction("Inventory report generated.");
            return report;
        }

        // 12. Generate User Report with formatted output
        public string GenerateUserReport()
        {
            var report = string.Join(Environment.NewLine, users.Select(u =>
                $"{"Name:",-10} {u.Name,-30} {"Email:",-10} {u.Email,-30}"));
            LogAction("User report generated.");
            return report;
        }


        // 13. Check Availability by Book ID
        public bool IsBookAvailable(int bookId)
        {
            var book = books.FirstOrDefault(b => b.BookId == bookId);
            return book != null && book.CopiesAvailable > 0;
        }

        // 14. Get All Books
        public List<Book> GetAllBooks()
        {
            return books;
        }

        // 15. Get All Users
        public List<User> GetAllUsers()
        {
            return users;
        }

    }
}
