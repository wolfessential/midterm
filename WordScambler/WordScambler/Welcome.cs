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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        // Button to go the scramble page
        private void BtnNext_Click(object sender, EventArgs e)
        {
            Hide();
            Scrambler f2 = new Scrambler();
            f2.ShowDialog();
            Close();
        }

        // Button to exit
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
