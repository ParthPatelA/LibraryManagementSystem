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
            reportListView.Items.Clear();
            String iventory = controller.GenerateInventoryReport();
            reportListView.Items.Add(iventory);

        }

        private void generateUserReportButton_Click(object sender, EventArgs e)
        {
            reportListView.Items.Clear();
            String user = controller.GenerateUserReport();
            reportListView.Items.Add(user);
        }
    }
}
