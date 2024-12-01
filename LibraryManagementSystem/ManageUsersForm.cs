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
    public partial class ManageUsersForm : Form
    {
        private LibrarySystemController controller;
        public ManageUsersForm()
        {
            InitializeComponent();
            controller = new LibrarySystemController();
        }

        private void viewUserButton_Click(object sender, EventArgs e)
        {
            //removing users
            userIdLabel.Visible = false;
            removeUsersButton.Visible = false;
            //for search users
            fillFormLabel.Visible = false;
            userNameLabel.Visible = false;
            nameTB.Visible = false;
            searchUsersButton.Visible = false;
            searchUserListView.Visible = false;
            searchUserListView.Items.Clear();

            // Get all users
            List<User> users = controller.ListAllUsers();

            // Ensure ListView is configured correctly
            userListView.View = View.Details;
            userListView.Columns.Clear();
            userListView.Columns.Add("User ID", 100, HorizontalAlignment.Left);
            userListView.Columns.Add("Name", 150, HorizontalAlignment.Left);
            userListView.Columns.Add("Email", 200, HorizontalAlignment.Left);

            // Clear existing items
            userListView.Items.Clear();

            // Populate the ListView with user data
            foreach (var user in users)
            {
                ListViewItem item = new ListViewItem(user.UserId.ToString());
                item.SubItems.Add(user.Name);
                item.SubItems.Add(user.Email);
                userListView.Items.Add(item);
            }

            userListView.Visible = true;
        }

        private void searchUserButton_Click(object sender, EventArgs e)
        {
            //for listing users
            userListView.Items.Clear();
            userListView.Visible = false;
            //for search users
            fillFormLabel.Visible = true;
            userNameLabel.Visible = true;
            nameTB.Visible = true;
            searchUsersButton.Visible = true;
            searchUserListView.Visible = true;
            //removing users
            userIdLabel.Visible = false;
            removeUsersButton.Visible = false;
        }

        private void searchUsersButton_Click(object sender, EventArgs e)
        {
            // Clear previous search results
            searchUserListView.Items.Clear();

            // Get the search term from the TextBox
            string searchName = nameTB.Text;

            // Validate the search term
            if (string.IsNullOrWhiteSpace(searchName))
            {
                nameTB.Clear();
                MessageBox.Show("Please enter a valid name to search.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Call the SearchUsers method in the controller
            var searchResults = controller.SearchUsers(searchName);

            // Display the results in the ListView
            if (searchResults != null && searchResults.Count > 0)
            {
                searchUserListView.View = View.Details;

                // Configure the columns if not already set
                if (searchUserListView.Columns.Count == 0)
                {
                    searchUserListView.Columns.Add("User ID", 100, HorizontalAlignment.Left);
                    searchUserListView.Columns.Add("Name", 150, HorizontalAlignment.Left);
                    searchUserListView.Columns.Add("Email", 200, HorizontalAlignment.Left);
                }

                // Add the users to the ListView
                foreach (var user in searchResults)
                {
                    ListViewItem item = new ListViewItem(user.UserId.ToString());
                    item.SubItems.Add(user.Name);
                    item.SubItems.Add(user.Email);
                    searchUserListView.Items.Add(item);
                }

                searchUserListView.Visible = true;
            }
            else
            {
                // No results found
                nameTB.Clear();
                MessageBox.Show("No users found matching the search criteria.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void removeUserButton_Click(object sender, EventArgs e)
        {
            //for search users
            userNameLabel.Visible = false;
            searchUsersButton.Visible = false;
            searchUserListView.Visible = false;
            searchUserListView.Items.Clear();
            //for listing users
            userListView.Items.Clear();
            userListView.Visible = false;
            //for removing customers
            fillFormLabel.Visible = true;
            userIdLabel.Visible = true;
            removeUsersButton.Visible = true;
            nameTB.Visible = true;
        }

        private void removeUsersButton_Click(object sender, EventArgs e)
        {
            // Get the user ID from the TextBox (nameTB is acting as userIdTB)
            if (int.TryParse(nameTB.Text, out int userId))
            {
                // Call the RemoveUser method
                bool isRemoved = controller.RemoveUser(userId);

                if (isRemoved)
                {
                    MessageBox.Show($"User with ID {userId} removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nameTB.Clear(); // Clear the TextBox after success
                }
                else
                {
                    MessageBox.Show($"User with ID {userId} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nameTB.Clear();
                }
            }
            else
            {
                // Handle invalid input (e.g., non-numeric or empty)
                MessageBox.Show("Please enter a valid User ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nameTB.Clear();

            }
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            LibrarySystemForm librarySystem = new LibrarySystemForm("Librarian");
            librarySystem.Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
