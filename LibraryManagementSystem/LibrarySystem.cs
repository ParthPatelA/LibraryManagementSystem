using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace LibraryManagementSystem
{
    // A singleton class that manages library operations such as adding, removing, and searching books and users.

    internal class LibrarySystem
    {
        private static LibrarySystem instance;
        private static readonly object lockObject = new object();

        private List<Book> books = new List<Book>();
        private List<User> users = new List<User>();
        public User CurrentUser { get; set; }

        private readonly string logFilePath = "LibrarySystemLog.txt";
        private readonly string booksFilePath = "BooksData.json";
        private readonly string usersFilePath = "UsersData.json";

        // Private constructor to enforce singleton pattern. Initializes library system by loading books and users from files.

        private LibrarySystem()
        {
            // Initialize log file
            if (!File.Exists(logFilePath))
                File.Create(logFilePath).Dispose();

            // Load books from file
            if (File.Exists(booksFilePath))
            {
                try
                {
                    string booksJson = File.ReadAllText(booksFilePath);
                    books = JsonConvert.DeserializeObject<List<Book>>(booksJson) ?? new List<Book>();
                }
                catch (Exception ex)
                {
                    LogAction($"Failed to load books data: {ex.Message}");
                }
            }

            // Load users from file
            if (File.Exists(usersFilePath))
            {
                try
                {
                    string usersJson = File.ReadAllText(usersFilePath);
                    users = JsonConvert.DeserializeObject<List<User>>(usersJson) ?? new List<User>();
                }
                catch (Exception ex)
                {
                    LogAction($"Failed to load users data: {ex.Message}");
                }
            }
        }
        // Retrieves the singleton instance of the library system.

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
        // Logs an action or message to the log file.
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
        // Saves the current list of books to the file.
        private void SaveBooksToFile()
        {
            try
            {
                string booksJson = JsonConvert.SerializeObject(books, Formatting.Indented);
                File.WriteAllText(booksFilePath, booksJson);
            }
            catch (Exception ex)
            {
                LogAction($"Failed to save books data: {ex.Message}");
            }
        }
        // Saves the current list of users to the file.
        private void SaveUsersToFile()
        {
            try
            {
                string usersJson = JsonConvert.SerializeObject(users, Formatting.Indented);
                File.WriteAllText(usersFilePath, usersJson);
            }
            catch (Exception ex)
            {
                LogAction($"Failed to save users data: {ex.Message}");
            }
        }
        // Adds a book to the library system.
        public void AddBook(Book book)
        {
            if (book == null) throw new ArgumentNullException(nameof(book));
            books.Add(book);
            SaveBooksToFile();
            LogAction($"Book added: {book.Title} (ID: {book.BookId})");
        }
        // Removes a book from the library system by its ID.
        public bool RemoveBook(int bookId)
        {
            var book = books.FirstOrDefault(b => b.BookId == bookId);
            if (book == null) return false;
            books.Remove(book);
            SaveBooksToFile();
            LogAction($"Book removed: {book.Title} (ID: {bookId})");
            return true;
        }
        // Adds a user to the library system.
        public void AddUser(User user)
        {
            if (user == null) throw new ArgumentNullException(nameof(user));
            users.Add(user);
            SaveUsersToFile();
            LogAction($"User added: {user.Name} (ID: {user.UserId})");
        }
        // Removes a user from the library system by their ID.
        public bool RemoveUser(int userId)
        {
            var user = users.FirstOrDefault(u => u.UserId == userId);
            if (user == null) return false;
            users.Remove(user);
            SaveUsersToFile();
            LogAction($"User removed: {user.Name} (ID: {user.UserId})");
            return true;
        }
        // Allows a user to borrow a book.
        public void BorrowBook(int bookId, int userId)
        {
            var book = books.FirstOrDefault(b => b.BookId == bookId);
            var user = users.FirstOrDefault(u => u.UserId == userId);

            if (book == null) throw new InvalidOperationException("Book not found.");
            if (user == null) throw new InvalidOperationException("User not found.");
            if (book.CopiesAvailable <= 0) throw new InvalidOperationException("No copies available.");

            book.CopiesAvailable--;
            if (user is Customer customer)
            {
                customer.BorrowBook(bookId);
            }
            LogAction($"Book borrowed: {book.Title} by User {user.Name} (ID: {userId})");
            SaveBooksToFile();
        }
        //Allows a user to return a borrowed book.
        public void ReturnBook(int bookId, int userId)
        {
            var book = books.FirstOrDefault(b => b.BookId == bookId);
            var user = users.FirstOrDefault(u => u.UserId == userId);

            if (book == null) throw new InvalidOperationException("Book not found.");

            book.CopiesAvailable++;
            if (user is Customer customer)
            {
                customer.RemoveBook(bookId);
            }
            SaveBooksToFile();
            LogAction($"Book returned: {book.Title} by User {user.Name} (ID: {userId})");
        }

        private bool ContainsIgnoreCase(string source, string toCheck)
        {
            return source?.IndexOf(toCheck, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        public List<Book> SearchBookByTitle(string title) =>
            books.Where(b => ContainsIgnoreCase(b.Title, title)).ToList();

        public List<Book> SearchBookByAuthor(string author) =>
            books.Where(b => ContainsIgnoreCase(b.Author, author)).ToList();

        public List<Book> SearchBookByGenre(string genre) =>
            books.Where(b => ContainsIgnoreCase(b.Genre, genre)).ToList();

        public List<User> SearchUserByName(string name) =>
            users.Where(u => ContainsIgnoreCase(u.Name, name)).ToList();

        public List<Book> GetAllBooks() => new List<Book>(books);

        public List<User> GetAllUsers() => new List<User>(users);

        public string GenerateInventoryReport() =>
            string.Join(Environment.NewLine, books.Select(b => $"{b.Title} ({b.CopiesAvailable} copies available)"));

        public string GenerateUserReport() =>
            string.Join(Environment.NewLine, users.Select(u => $"{u.Name} ({u.GetType().Name})"));
    }
}
