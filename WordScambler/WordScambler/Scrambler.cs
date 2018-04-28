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
    public partial class Scrambler : Form
    {

        ScrambleClass cb;
        public Scrambler()
        {
            InitializeComponent();
            cb = new ScrambleClass();
            TxtInput.Focus();
        }


        // Button to exit
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

      

      

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (RbtEasy.Checked)
            {
                LblWord.Text = cb.ScrambleEasy();

            }

            if (RbtMedium.Checked)  
            {
                LblWord.Text = cb.ScrambleMedium();
            }

            if (RbtHard.Checked)
            {
                LblWord.Text = cb.ScrambleHard();
            }

        }


        private void BtnInput_Click(object sender, EventArgs e)
        {
            string UserGuess;
            UserGuess = TxtInput.Text.ToString();
            bool value = cb.CompareWord(UserGuess);

            if(value == true)
            {
                MessageBox.Show("You are correct!!", "Correct", MessageBoxButtons.OK);
                if (RbtEasy.Checked)
                {
                    LblWord.Text = cb.ScrambleEasy();
                }

                if (RbtMedium.Checked)
                {
                    LblWord.Text = cb.ScrambleMedium();
                }

                if (RbtHard.Checked)
                {
                    LblWord.Text = cb.ScrambleHard();
                }

            }
            else
            {
                MessageBox.Show("Wrong, try again!", "Incorrect", MessageBoxButtons.OK);
            }

        }
    }
   
}



