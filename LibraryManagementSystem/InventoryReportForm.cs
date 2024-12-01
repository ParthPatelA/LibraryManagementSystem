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
    public partial class InventoryReportForm : Form
    {
        private LibrarySystemController controller;
        public InventoryReportForm()
        {
            InitializeComponent();
            controller = new LibrarySystemController();
        }

        private void generateInventoryReportButton_Click(object sender, EventArgs e)
        {
            // Clear the RichTextBox
            reportRichTextBox.Clear();

            // Generate the inventory report
            string inventory = controller.GenerateInventoryReport();

            // Add the report to the RichTextBox with formatting
            reportRichTextBox.AppendText("Inventory Report\n");
            var lines = inventory.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            foreach (var line in lines)
            {
                reportRichTextBox.AppendText(line + "\n");
            }

            reportRichTextBox.AppendText("\n");
        }

        private void generateUserReportButton_Click(object sender, EventArgs e)
        {
            // Clear the RichTextBox
            reportRichTextBox.Clear();

            // Generate the user report
            string user = controller.GenerateUserReport();

            // Add the report to the RichTextBox with formatting
            reportRichTextBox.AppendText("User Report\n");
            var lines = user.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            foreach (var line in lines)
            {
                reportRichTextBox.AppendText(line + "\n");
            }

            reportRichTextBox.AppendText("\n");
        }

        private void returnToPreviousScreen_Click(object sender, EventArgs e)
        {
            LibrarySystemForm librarySystemForm = new LibrarySystemForm();
            librarySystemForm.Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
