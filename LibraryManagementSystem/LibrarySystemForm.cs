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

        public LibrarySystemForm()
        {

            InitializeComponent();
            librarySystemController = new LibrarySystemController();
            librarySystem = LibrarySystem.GetInstance();
        }

        private void LibrarySystemForm_Load(object sender, EventArgs e)
        {
            welcomeLabel.Text = $"Welcome, {librarySystem.CurrentUser.Name}";
            totalBooksLabel.Text = $"Total Books: {librarySystemController.ListAllBooks().Count}";
            totalUsersLabel.Text = $"Total Users: {librarySystemController.ListAllUsers().Count}";
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

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            InventoryReportForm inventoryReport = new InventoryReportForm();
            inventoryReport.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void returnLoginFormButton_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUsForm aboutUsForm = new AboutUsForm();
            aboutUsForm.Show();
            this.Hide();
        }
    }
}
