using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JamesWolfChapt7Arrays
{
    public partial class CalculateTemps : Form
    {
        CalculatorBusniess cb;
        public CalculateTemps()
        {
            InitializeComponent();
            cb = new CalculatorBusniess();
        }

        private void HighestCalc_Click(object sender, EventArgs e)
        {
            OutPutDisplayCalc.Text = string.Format("The Highest Temp of the week was: {0}", (cb.DetermineHighest(
                                                  Convert.ToInt32(SundayTextBox.Text), 
                                                  Convert.ToInt32(MondayTextBox.Text), 
                                                  Convert.ToInt32(TuesdayTextBox.Text), 
                                                  Convert.ToInt32(WednesdayTextBox.Text), 
                                                  Convert.ToInt32(ThursdayTextBox.Text), 
                                                  Convert.ToInt32(FridayTextBox.Text), 
                                                  Convert.ToInt32(SaturdayTextBox.Text))));

            

        }

        private void LowestCalc_Click(object sender, EventArgs e)
        {
            OutPutDisplayCalc.Text = string.Format("The Lowest Temp of the week was: {0}", (cb.DetermineLowest(
                                                  Convert.ToInt32(SundayTextBox.Text),
                                                  Convert.ToInt32(MondayTextBox.Text),
                                                  Convert.ToInt32(TuesdayTextBox.Text),
                                                  Convert.ToInt32(WednesdayTextBox.Text),
                                                  Convert.ToInt32(ThursdayTextBox.Text),
                                                  Convert.ToInt32(FridayTextBox.Text),
                                                  Convert.ToInt32(SaturdayTextBox.Text))));
        }

        private void AveCalc_Click(object sender, EventArgs e)
        {
            OutPutDisplayCalc.Text = string.Format("The Average Temp of the week was: {0}", (cb.DetermineAverage(
                                                             Convert.ToInt32(SundayTextBox.Text),
                                                             Convert.ToInt32(MondayTextBox.Text),
                                                             Convert.ToInt32(TuesdayTextBox.Text),
                                                             Convert.ToInt32(WednesdayTextBox.Text),
                                                             Convert.ToInt32(ThursdayTextBox.Text),
                                                             Convert.ToInt32(FridayTextBox.Text),
                                                             Convert.ToInt32(SaturdayTextBox.Text))));
        }

        private void AveWithOutLCalc_Click(object sender, EventArgs e)
        {
            OutPutDisplayCalc.Text = string.Format("The Average Temperature of the week Excluding the Lowest Tempature was: {0}", (cb.DetermineAverageExcludingLowest(
                                                            Convert.ToInt32(SundayTextBox.Text),
                                                            Convert.ToInt32(MondayTextBox.Text),
                                                            Convert.ToInt32(TuesdayTextBox.Text),
                                                            Convert.ToInt32(WednesdayTextBox.Text),
                                                            Convert.ToInt32(ThursdayTextBox.Text),
                                                            Convert.ToInt32(FridayTextBox.Text),
                                                            Convert.ToInt32(SaturdayTextBox.Text))));
        }
    }
}
