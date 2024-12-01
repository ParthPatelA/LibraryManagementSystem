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
    public partial class LibrarySystemForm : Form
    {

        private LibrarySystemController librarySystemController;
        private LibrarySystem librarySystem;
        
        public LibrarySystemForm(String role) { 

            InitializeComponent();
            librarySystemController = new LibrarySystemController();
            librarySystem = LibrarySystem.GetInstance();
        }

        private void LibrarySystemForm_Load(object sender, EventArgs e)
        {
            welcomeLabel.Text = $"Welcome, {librarySystem.CurrentUser.Name}";
        }
        private void ManageBookButton_Click(object sender, EventArgs e)
        {
            ManageBooksForm manageBook = new ManageBooksForm();
            manageBook.Show();
            this.Hide();
        }

        private void manageUsersButton_Click(object sender, EventArgs e)
        {
            ManageUsersForm manageUsers = new ManageUsersForm();
            manageUsers.Show();
            this.Hide();
        }

        private void SearchCatalogButton_Click(object sender, EventArgs e)
        {
            SearchBooksForm searchBooks = new SearchBooksForm();
            searchBooks.Show();
            this.Hide();
        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            InventoryReportForm inventoryReport = new InventoryReportForm();
            inventoryReport.Show();
            this.Hide();
        }

        private void borrowReturnButton_Click(object sender, EventArgs e)
        {
            BorrowBooksForm borrowBooks = new BorrowBooksForm();
            borrowBooks.Show();
            this.Hide();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            ReturnBooksForm returnBooks = new ReturnBooksForm();
            returnBooks.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LibrarySummaryGroupBox_Enter(object sender, EventArgs e)
        {
            totalBooksLabel.Text = $"Total Books: {librarySystem.GetAllBooks().Count}";
            totalUsersLabel.Text = $"Total Users: {librarySystem.GetAllBooks().Count}";
            int borrowedBooksCount = librarySystem.GetAllBooks().Count(Book => !Book.IsAvailable);
            borrowedBooksLabel.Text = $"Bororwed Books: {borrowedBooksCount}";
        }

        private void returnLoginFormButton_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
    }
}
