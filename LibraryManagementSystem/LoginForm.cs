using System;
using System.Globalization;
using System.Resources;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class LoginForm : Form
    {
        private static string selectedRole;
        private LibrarySystemController controller;
        ResourceManager resManager; // For managing resources
        CultureInfo cultureInfo;

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
            if (selectedRole.Equals("Librarian") || selectedRole.Equals("Bibliothécaire") || selectedRole.Equals("Bibliotecario"))
            {
                user = new Librarian(name, email);
                LibrarySystem.GetInstance().CurrentUser = user;
                controller.AddUser(name, email, selectedRole);

                // Navigate to Librarian view
                LibrarySystemForm librarySystem = new LibrarySystemForm();
                librarySystem.Show();
                this.Hide();
            }
            else if (selectedRole.Equals("Customer") || selectedRole.Equals("Client") || selectedRole.Equals("Cliente"))
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
                if (role == "Librarian" || role == "Customer" || role == "Client" || role == "Bibliothécaire" || role == "Bibliotecario" || role == "Cliente")
                {
                    selectedRole = role;
                }
                else
                {
                    selectedRole = null;
                }
            }
        }

        private void languagesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var changeLanguage = new ChangeLanguage();
            switch (languagesComboBox.SelectedIndex)
            {
                case 0: changeLanguage.UpdateConfig("language", "en");
                        Application.Restart();
                        break;

                case 1: changeLanguage.UpdateConfig("language", "fr-CA");
                        Application.Restart();
                        break;

                case 2: changeLanguage.UpdateConfig("language", "es");
                    Application.Restart();
                    break;
            }


        }

    

    }
}
