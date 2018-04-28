using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordScambler
{
    public partial class Winner : Form
    {
        public Winner()
        {
            InitializeComponent();
        }

        // Button to go back to the welcome page
        private void BtnRestart_Click(object sender, EventArgs e)
        {
            Hide();
            Welcome f1 = new Welcome();
            f1.ShowDialog();
            Close();
        }

        // Button to close the program
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
