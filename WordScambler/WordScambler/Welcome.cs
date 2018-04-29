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
// Coded Avery
// This code is for displaying the welcome page
{
    public partial class Srambler : Form
    {
        public Srambler()
        {
            InitializeComponent();
        }

        // Button to go the scramble page
        private void BtnNext_Click(object sender, EventArgs e)
        {
            //Hide current form
            Hide();
            // Call Scrambler form
            Scrambler f2 = new Scrambler();
            f2.ShowDialog();
            // Close current window
            Close();
        }

        // Button to exit
        private void BtnExit_Click(object sender, EventArgs e)
        {
            // This closes the program
            Close();
        }
    }
}
