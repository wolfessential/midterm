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
    // Coded by Chad
    // This code is for displaying the page for the winners
{
    public partial class Winner : Form
    {
        public Winner()
        {
            InitializeComponent();
        }

        // Button to go back to the scrambler page
        private void BtnRestart_Click(object sender, EventArgs e)
        {
            // Hide current form
            Hide();
            // Call scrambler
            Scrambler f2 = new Scrambler();
            f2.ShowDialog();
            // Close current window
            Close();
        }

        // Button to close the program
        private void BtnExit_Click(object sender, EventArgs e)
        {
            // This closes program
            Close();
        }
    }
}
