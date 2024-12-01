using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class ManageBooksForm : Form
    {
        private LibrarySystemController librarySystemController;
        public ManageBooksForm()
        {
            InitializeComponent();
            librarySystemController = new LibrarySystemController();
        }

        private void listAllBooksButton_Click(object sender, EventArgs e)
        {
            //for removing books
            bookIdLabel.Visible = false;
            bookIdTB.Visible = false;
            removeBooksButton.Visible = false;
            //for adding books
            fillOutFormLabel.Visible = false;
            availabilityTB.Visible = false;
            availabilityLabel.Visible = false;
            copiesAvailableTB.Visible = false;
            copiesAvailableLabel.Visible = false;
            isbnTB.Visible = false;
            isbnLabel.Visible = false;
            yearPublishedTB.Visible = false;
            yearPublishedLabel.Visible = false;
            genreTB.Visible = false;
            genreLabel.Visible = false;
            authorTB.Visible = false;
            authorLabel.Visible = false;
            titleTB.Visible = false;
            titleLabel.Visible = false;
            addBooksButton.Visible = false;
            bookListView.Items.Clear();

            var books = librarySystemController.ListAllBooks();
            if (books.Count > 0)
            {
                // Ensure ListView is in Details mode and columns are set
                bookListView.View = View.Details;
                bookListView.Columns.Clear();
                bookListView.Columns.Add("Book ID", 100, HorizontalAlignment.Left);
                bookListView.Columns.Add("Title", 150, HorizontalAlignment.Left);
                bookListView.Columns.Add("Author", 150, HorizontalAlignment.Left);
                bookListView.Columns.Add("Copies Available", 120, HorizontalAlignment.Left);

                // Clear existing items
                bookListView.Items.Clear();

                // Populate the ListView
                foreach (var book in books)
                {
                    ListViewItem item = new ListViewItem(book.BookId.ToString());
                    item.SubItems.Add(book.Title);
                    item.SubItems.Add(book.Author);
                    item.SubItems.Add(book.CopiesAvailable.ToString());
                    bookListView.Items.Add(item);
                }

                bookListView.Visible = true;
            }
            else
            {
                MessageBox.Show("No books available.");
            }
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            //clearing list view
            bookListView.Items.Clear();
            bookListView.Visible = false;
            //for adding books
            fillOutFormLabel.Visible = true;
            availabilityTB.Visible = true;
            availabilityLabel.Visible = true;
            copiesAvailableTB.Visible = true;
            copiesAvailableLabel.Visible = true;
            isbnTB.Visible = true;
            isbnLabel.Visible = true;
            yearPublishedTB.Visible = true;
            yearPublishedLabel.Visible = true;
            genreTB.Visible = true;
            genreLabel.Visible = true;
            authorTB.Visible = true;
            authorLabel.Visible = true;
            titleTB.Visible = true;
            titleLabel.Visible = true;
            addBooksButton.Visible = true;
            //for removing books
            bookIdLabel.Visible = false;
            bookIdTB.Visible = false;
            removeBooksButton.Visible = false;


        }

        private void addBooksButton_Click(object sender, EventArgs e)
        {

            try
            {
                // Gather input from text boxes
                string title = titleTB.Text;
                string author = authorTB.Text;
                string genre = genreTB.Text;
                string yearPublished = yearPublishedTB.Text;
                string isbn = isbnTB.Text;
                int copiesAvailable = int.Parse(copiesAvailableTB.Text);
                bool isAvailable = availabilityTB.Text.ToLower() == "true";
                // Create a new Book object
                Book newBook = new Book(title, author, genre, yearPublished, isbn, copiesAvailable, isAvailable);
                // Add the book to the library system
                AddBook(newBook);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid data in all fields.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clearTextBoxs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearTextBoxs();   
            }
        }


        public void AddBook(Book book)
        {
            if (book == null)
            {
                MessageBox.Show("Cannot add a null book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearTextBoxs();
                return;
            }

            try
            {
                librarySystemController.AddBook(book);
                MessageBox.Show($"Book '{book.Title}' added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearTextBoxs();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Validation error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clearTextBoxs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearTextBoxs();
            }
        }

        public void clearTextBoxs()
        {
            availabilityTB.Clear();
            copiesAvailableTB.Clear();
            isbnTB.Clear();
            yearPublishedTB.Clear();
            genreTB.Clear();
            authorTB.Clear();
            titleTB.Clear();
        }


        private void removeBookButton_Click(object sender, EventArgs e)
        {
            //clearing list view
            bookListView.Items.Clear();
            bookListView.Visible = false;
            //for adding books
            availabilityTB.Visible = false;
            availabilityLabel.Visible = false;
            copiesAvailableTB.Visible = false;
            copiesAvailableLabel.Visible = false;
            isbnTB.Visible = false;
            isbnLabel.Visible = false;
            yearPublishedTB.Visible = false;
            yearPublishedLabel.Visible = false;
            genreTB.Visible = false;
            genreLabel.Visible = false;
            authorTB.Visible = false;
            authorLabel.Visible = false;
            titleTB.Visible = false;
            titleLabel.Visible = false;
            addBooksButton.Visible = false;
            bookListView.Items.Clear();
            //for removing books
            fillOutFormLabel.Visible = true;
            bookIdLabel.Visible = true;
            bookIdTB.Visible = true;
            removeBooksButton.Visible = true;
        }

        private void removeBooksButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the bookId from the text box
                int bookId = int.Parse(bookIdTB.Text);

                // Call the RemoveBook method
                if (librarySystemController.RemoveBook(bookId))
                {
                    MessageBox.Show($"Book with ID {bookId} removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Book with ID {bookId} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    bookIdTB.Clear();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid numeric Book ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                bookIdTB.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bookIdTB.Clear();
            }
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            LibrarySystemForm librarySystemForm = new LibrarySystemForm("Librarian");
            librarySystemForm.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
