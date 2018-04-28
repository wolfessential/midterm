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


        //Where can I put this button?? I have the code to compare an input 
        //against the word in the word list but I don't know where to put it so 
        //I can compare when the user clicks the submit button..
        //CODE FOR COMAPRE.. Do I make this a method somewhere maybe in the
        //ScrambleClass? Or its own class?
        //CODE:
        //string UserGuess;
        //UserGuess = TxtInput.Text.ToString();
        //if (UserGuess.ToLower() == strWordList)
        //{MessageBox.Show("You are correct!!", MessageBoxButtons.OK);
        //TxtInput.Clear();
        //ScrambleEasy();
        //}
        //else
        //{MessageBox.Show("Wrong, try again!", MessageBoxButtons.OK);
        //TxtInput.Clear();
        //}

        private void BtnInput_Click(object sender, EventArgs e)
        {
            string UserGuess;
            UserGuess = TxtInput.Text.ToString();

        }
    }
   
}



