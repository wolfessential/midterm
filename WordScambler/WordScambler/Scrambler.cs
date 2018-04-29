using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace WordScambler
    // Coded Chad, James, Avery, Kyle
{
    public partial class Scrambler : Form
    {
        // To bring in the music
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        // To call the sramble class 
        ScrambleClass cb;
        // Set the counter for each round
        int counter = 0; 
        public Scrambler()
        {
            // Song we are bringing in
            player.URL = "mario.mp3";
            InitializeComponent();
            // Generates the new scramble class
            cb = new ScrambleClass();
            // To focus the cusor
            TxtInput.Focus();
        }

        // Starts the music to play
        public void Scrambler_Load(object sender, EventArgs e)
        {
            // Play song
            player.controls.play();
        }
        // Button to exit
        private void BtnExit_Click(object sender, EventArgs e)
        {
            // Close program
            Close();
        }

      

      
        // Level selection
        private void StartButton_Click(object sender, EventArgs e)
        {
            // When easy is checked will call the easy method from the Scramble Class
            if (RbtEasy.Checked)
            {
                LblWord.Text = cb.ScrambleEasy();
            }

            // When medium is checked will call the medium method from the Scramble Class
            if (RbtMedium.Checked)  
            {
                LblWord.Text = cb.ScrambleMedium();
            }

            // When hard is checked will call the hard method from the Scramble Class
            if (RbtHard.Checked)
            {
                LblWord.Text = cb.ScrambleHard();
            }

        }

        // Submit button
        //For the user to input what they think is correct
        private void BtnInput_Click(object sender, EventArgs e)
        {
            // for the user to guess
             string UserGuess;
            // to compare user input to word
             UserGuess = TxtInput.Text.ToString();
             bool value = cb.CompareWord(UserGuess);
            // The counter for each round if gussed correctly
             if (value == true)
             {
                // Display message box for right anwser
                MessageBox.Show("You are correct!!", "Correct", MessageBoxButtons.OK);
                {
                    // What radio button is click for each word list: This is Easy
                    if (RbtEasy.Checked)
                    {
                        LblWord.Text = cb.ScrambleEasy();
                        TxtInput.Clear();
                        TxtInput.Focus();
                    }

                    //What radio button is click for each word list: This is Medium
                    if (RbtMedium.Checked)
                    {
                        LblWord.Text = cb.ScrambleMedium();
                        TxtInput.Clear();
                        TxtInput.Focus();
                    }

                    //What radio button is click for each word list: This is Hard
                    if (RbtHard.Checked)
                    {
                        LblWord.Text = cb.ScrambleHard();
                        TxtInput.Clear();
                        TxtInput.Focus();
                    }
                }
                counter++;
             }
             // If the user is incorrect
             else
             {
                // Message box for incorrect
                MessageBox.Show("Wrong, try again!", "Incorrect", MessageBoxButtons.OK);
             }
             // Once counter has reached 5
             if(counter == 5)
             {
                // Hide currect window
                Hide();
                // Move to winner form
                Winner f3 = new Winner();
                f3.ShowDialog();
                Close();
             }
         }

        // For music
        // To start the music
        private void BtnStart_Click(object sender, EventArgs e)
        {
            player.controls.play();
            BtnStart.Visible = false;
            BtnStop.Visible = true;
        }

        // To stop the music
        private void BtnStop_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            BtnStart.Visible = true;
            BtnStop.Visible = false;
        }
    }
 }
   




