using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JamesWolfLab8ExcHand
{
    public partial class Calculator : Form
    {
        CalculatorBusniess cb; // Create new CalculatorBusniess
        public Calculator()
        {
            InitializeComponent();
            cb = new CalculatorBusniess(); //cb will make a new instance of CalculatorBusniess
        }


        //When you click the "Calculate" button the following will happen
        private void button1_Click(object sender, EventArgs e)
        {
            if (AdditionButton1.Checked) // This checks if the radio button for addtion is checked
                //if it is it will do the Addition method 
            {

                //This will check to make sure the user input was vaild in the way my method will use the NumberTextboxes data.
                //If the user inputs an incorrect input they'll receive an error 
                //I also included the type of error in the message box so the user will know what they did wrong.
                try
                {
                    OutputCalc.Text = Convert.ToString(cb.Addition(Convert.ToInt32(NumberOneTextB.Text), Convert.ToInt32(NumberTwoTextB.Text)));
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error Invaild Entery: " + ex.Message);
                }

            }


            if (SubtractionButton2.Checked)// This checks if the radio button for Subtraction is checked
                                           //if it is it will do the Subtraction method
            {
                //This will check to make sure the user input was vaild in the way my method will use the NumberTextboxes data.
                //If the user inputs an incorrect input they'll receive an error 
                //I also included the type of error in the message box so the user will know what they did wrong.
                try
                {
                    OutputCalc.Text = Convert.ToString(cb.Subtraction(Convert.ToInt32(NumberOneTextB.Text), Convert.ToInt32(NumberTwoTextB.Text)));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Invaild Entery: " + ex.Message);
                }
            }

            if (MultiplyButton3.Checked)// This checks if the radio button for Multiply is checked
                                        //if it is it will do the Multiply method
            {
                //This will check to make sure the user input was vaild in the way my method will use the NumberTextboxes data.
                //If the user inputs an incorrect input they'll receive an error 
                //I also included the type of error in the message box so the user will know what they did wrong.
                try
                {
                    OutputCalc.Text = Convert.ToString(cb.Multiply(Convert.ToInt32(NumberOneTextB.Text), Convert.ToInt32(NumberTwoTextB.Text)));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Invaild Entery: " + ex.Message);
                }
            }

            if (DivisionButton4.Checked)// This checks if the radio button for Divide is checked
                                        //if it is it will do the Divide method
            {
                //This will check to make sure the user input was vaild in the way my method will use the NumberTextboxes data.
                //If the user inputs an incorrect input they'll receive an error 
                //I also included the type of error in the message box so the user will know what they did wrong.
                try
                {
                    OutputCalc.Text = Convert.ToString(cb.Divide(Convert.ToInt32(NumberOneTextB.Text), Convert.ToInt32(NumberTwoTextB.Text)));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Invaild Entery: " + ex.Message);
                }

            }
        }
    }
}
