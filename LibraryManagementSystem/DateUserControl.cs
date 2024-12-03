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
    public partial class DateUserControl : UserControl
    {
        public DateUserControl()
        {
            InitializeComponent();
        }

        private void dateTimer_Tick(object sender, EventArgs e)
        {
            displayLabel.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
        }
    }
}
