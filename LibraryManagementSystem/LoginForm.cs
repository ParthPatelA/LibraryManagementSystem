using System;
using System.CodeDom;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class LoginForm : Form
    {
        private static String selectedRole;
        private LibrarySystemController controller;

        public LoginForm()
        {

            InitializeComponent();
            controller = new LibrarySystemController();
        }

        private void validateButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string email = emailTextBox.Text;
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);

            // Validate inputs
            if (string.IsNullOrEmpty(name) || !regex.IsMatch(email))
            {
                displayMessage.Text = "ERROR: Name or email is invalid";
                return;
            }

            // Check if role is selected
            if (string.IsNullOrEmpty(selectedRole))
            {
                displayMessage.Text = "ERROR: You must select your role";
                return;
            }

            // Create a user based on the selected role
            User user;
            if (selectedRole.Equals("Librarian"))
            {
                user = new Librarian(name, email);
                LibrarySystem.GetInstance().user = user; 
                controller.AddUser(name, email, selectedRole);
                LibrarySystemForm librarySystem = new LibrarySystemForm();
                librarySystem.Show();
                this.Hide();
            }
            else if (selectedRole.Equals("Customer"))
            {
                user = new Customer(name, email);
                LibrarySystem.GetInstance().user = user;
                controller.AddUser(name, email, selectedRole);
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
                String role = selectedItem.ToString().Trim();
                switch (role)
                {
                    case "Librarian":
                        selectedRole = role;

                        break;
                    case "Customer":
                        selectedRole = role;
                        break;
                }
            }
        }
    }
}
