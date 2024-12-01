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
        LibrarySystemController controller;
        
        public ManageBooksForm()
        {
            
            InitializeComponent();
            UpdateBookGrid();
            controller = new LibrarySystemController();
            
        }

        private void UpdateBookGrid()
        {
            bookListDataGridView.DataSource = null;
            bookListDataGridView.DataSource = controller.GetAllBooks();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            string title = titleTextbox.Text;
            string author = authorTextBox.Text;
            string genre = genreTextBox.Text;
            string year  = yearTextBox.Text;
            int amount = int.Parse(amountTextBox.Text);
            string isbn = ISBNTextBox.Text;
            bool isAvailble = availableCheckbox.Checked;

            controller.AddBook(title, author, genre, year, isbn, amount, isAvailble);
            UpdateBookGrid();
            MessageBox.Show("Book added succefully.");

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (bookListDataGridView.SelectedRows.Count > 0)
            {
                Book selectedBook = (Book)bookListDataGridView.SelectedRows[0].DataBoundItem;
                controller.GetAllBooks().Remove(selectedBook);
                UpdateBookGrid();
                MessageBox.Show("Book removed succefully.");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
        }
    }
}
