using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {

            InitializeComponent();

        }

        private void validateButton_Click(object sender, EventArgs e)
        {
            String role = roleComboBox.SelectedItem.ToString();
            String name = nameTextBox.Text;
            String email = emailTextBox.Text;
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);

            if (name == null || regex.IsMatch(email) )
            {
                User user = new User(name, email, role);
                // Create an instance of LibrarySystemForm
                LibrarySystemForm librarySystem = new LibrarySystemForm(roleComboBox.SelectedItem.ToString());

                // Show the LibrarySystemForm as a modal window
                librarySystem.Show();

                // After closing the modal, close the LoginForm
                this.Hide();

            }
            else
            {
                displayMessage.Text = "ERROR : name or email is invalid";
            }
            //string role = roleComboBox.SelectedItem?.ToString();
            //if (role == "Customer")
            //{
            //} else if (role == "Librarian")
            //{
            //}
        }
    }
}
