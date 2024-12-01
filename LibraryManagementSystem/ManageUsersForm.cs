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
        LibrarySystemController controller;
        public ManageUsersForm()
        {
            InitializeComponent();
            controller = new LibrarySystemController();
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            userListDataGridView.DataSource = null;
            userListDataGridView.DataSource = controller.GetAllUsers();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = nameTextbox.Text;
            string email = emailTextBox.Text;
            string role = roleTextbox.Text;

            controller.AddUser(name, email, role);
            UpdateGrid();
            MessageBox.Show("User added succefully.");
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (userListDataGridView.SelectedRows.Count > 0)
            {
                User selectedUser = (User)userListDataGridView.SelectedRows[0].DataBoundItem;
                controller.GetAllUsers().Remove(selectedUser);
                UpdateGrid();
                MessageBox.Show("User removed succefully.");
            }
        }
    }
}
