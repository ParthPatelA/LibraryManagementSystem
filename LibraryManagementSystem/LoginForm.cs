using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class LoginForm : Form
    {
        private static string selectedRole;
        private LibrarySystemController controller;

        public LoginForm()
        {
            InitializeComponent();
            controller = new LibrarySystemController();
        }

        private void validateButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text.Trim();
            string email = emailTextBox.Text.Trim();
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);

            // Validate inputs
            if (string.IsNullOrEmpty(name) || !regex.IsMatch(email))
            {
                displayMessage.Text = "ERROR: Name or email is invalid.";
                return;
            }

            // Check if role is selected
            if (string.IsNullOrEmpty(selectedRole))
            {
                displayMessage.Text = "ERROR: You must select your role.";
                return;
            }

            // Create a user based on the selected role
            User user;
            if (selectedRole.Equals("Librarian"))
            {
                user = new Librarian(name, email);
                LibrarySystem.GetInstance().CurrentUser = user;
                controller.AddUser(name, email, selectedRole);
                
                // Navigate to Librarian view
                LibrarySystemForm librarySystem = new LibrarySystemForm(selectedRole);
                librarySystem.Show();
                this.Hide();
            }
            else if (selectedRole.Equals("Customer"))
            {
                user = new Customer(name, email);
                LibrarySystem.GetInstance().CurrentUser = user;
                controller.AddUser(name, email, selectedRole);

                // Navigate to Customer view
                CustomerViewForm customerViewForm = new CustomerViewForm();
                customerViewForm.Show();
                this.Hide();
            }
        }

        private void roleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = roleComboBox.SelectedItem;
            if (selectedItem != null)
            {
                string role = selectedItem.ToString().Trim();
                if (role == "Librarian" || role == "Customer")
                {
                    selectedRole = role;
                }
            }
        }
    }
}
