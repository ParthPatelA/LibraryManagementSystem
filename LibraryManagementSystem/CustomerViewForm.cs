using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class CustomerViewForm : Form
    {
        private LibrarySystemController controller;
        private LibrarySystem librarySystem;
        private static String selectedSearchType;
        public CustomerViewForm()
        {
            InitializeComponent();
            controller = new LibrarySystemController();
            librarySystem = LibrarySystem.GetInstance();
        }

        private void viewBooksButton_Click(object sender, EventArgs e)
        {
            bookListView.Items.Clear();
            var books = controller.ListAllBooks();
            if (books.Count > 0)
            {
                bookListView.Visible = true;
                foreach (var book in books)
                {
                    ListViewItem item = new ListViewItem(book.BookId.ToString());
                    item.SubItems.Add(book.Title);
                    item.SubItems.Add(book.Author);
                    item.SubItems.Add(book.CopiesAvailable.ToString());
                    bookListView.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("No books available.");
            }

        }

        private void searchBooksButton_Click(object sender, EventArgs e)
        {
            returnBookButton.Visible = false;
            bookIdPromptLabel.Visible = false;
            bookIdTextBox.Visible = false;
            borrowBookButton.Visible = false;
            searchBookListView.Items.Clear();
            searchLabelPromptLabel.Visible = true;
            searchByComboBox.Visible = true;
            queryPromptLabel.Visible = true;
            queryTextBox.Visible = true;
            searchButton.Visible = true;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string query = queryTextBox.Text.Trim();
            if (string.IsNullOrEmpty(query))
            {
                MessageBox.Show("Please enter a valid search query.");
                queryTextBox.Clear();
                return;
            }
            List<Book> results = SearchForBooks(selectedSearchType, query);
            searchBookListView.Items.Clear();
            searchBookListView.Visible = true;
            if (results.Count > 0)
            {
                foreach (var book in results)
                {
                    ListViewItem item = new ListViewItem(book.BookId.ToString());
                    item.SubItems.Add(book.Title);
                    item.SubItems.Add(book.Author);
                    item.SubItems.Add(book.Genre);
                    item.SubItems.Add(book.CopiesAvailable.ToString());
                    searchBookListView.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("No books found matching your search.");
                queryTextBox.Clear();
            }
        }

        private void searchByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string choice = searchByComboBox.SelectedItem.ToString();
            switch (choice.ToLower())
            {
                case "title":
                    selectedSearchType = choice;
                    break;
                case "author":
                    selectedSearchType = choice;
                    break;
                case "genre":
                    selectedSearchType = choice;
                    break;
                default:
                    selectedSearchType = "";
                    break;
            }
            UpdateQueryPromptLabel();
        }

        private void UpdateQueryPromptLabel()
        {
            switch (selectedSearchType)
            {
                case "title":
                    queryPromptLabel.Text = "Enter book title:";
                    break;
                case "author":
                    queryPromptLabel.Text = "Enter author's name:";
                    break;
                case "genre":
                    queryPromptLabel.Text = "Enter book genre:";
                    break;
                default:
                    queryPromptLabel.Text = "Enter search query:";
                    break;
            }
        }
        public List<Book> SearchForBooks(string searchType, string query)
        {
            List<Book> results = new List<Book>();
            switch (searchType.ToLower())
            {
                case "title":
                    results = librarySystem.SearchBookByTitle(query);
                    break;
                case "author":
                    results = librarySystem.SearchBookByAuthor(query);
                    break;
                case "genre":
                    results = librarySystem.SearchBookByGenre(query);
                    break;
                default:
                    MessageBox.Show("Invalid search type selected.");
                    break;
            }
            return results;
        }

        private void borrowBooksButton_Click(object sender, EventArgs e)
        {
            searchBookListView.Items.Clear();
            searchBookListView.Visible = false;
            bookListView.Items.Clear();
            bookListView.Visible = false;
            searchLabelPromptLabel.Visible = false;
            searchByComboBox.Visible = false;
            queryPromptLabel.Visible = false;
            queryTextBox.Visible = false;
            searchButton.Visible = false;
            bookIdPromptLabel.Visible = true;
            bookIdTextBox.Visible = true;
            borrowBookButton.Visible = true;
        }

        private void borrowBookButton_Click(object sender, EventArgs e)
        {
            try
            {
                int bookId;
                bool isValid = int.TryParse(bookIdTextBox.Text, out bookId);
                if (isValid && bookId > 0)
                {
                    int userId = librarySystem.CurrentUser.UserId;
                    controller.BorrowBook(bookId, userId);
                }
                else
                {
                    MessageBox.Show("Please enter a valid Book ID.");
                    bookIdTextBox.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                bookIdTextBox.Clear();
            }

        }
        private void returnBooksButton_Click(object sender, EventArgs e)
        {
            searchBookListView.Items.Clear();
            searchBookListView.Visible = false;
            bookListView.Items.Clear();
            bookListView.Visible = false;
            searchLabelPromptLabel.Visible = false;
            searchByComboBox.Visible = false;
            queryPromptLabel.Visible = false;
            queryTextBox.Visible = false;
            searchButton.Visible = false;
            borrowBookButton.Visible = false;

            bookIdPromptLabel.Visible = true;
            bookIdTextBox.Visible = true;
            returnBookButton.Visible = true;
        }

        private void returnBookButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(bookIdTextBox.Text, out int bookId))
            {
                int userId = librarySystem.CurrentUser.UserId;

                try
                {
                  controller.ReturnBook(bookId, userId); // Call the updated ReturnBook method
                  MessageBox.Show($"Book with ID {bookId} successfully returned.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error returning book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bookIdTextBox.Clear() ;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid book ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                bookIdTextBox.Clear();
            }
        }
    }
}
