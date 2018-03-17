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
            OutPutDisplayCalc.Text = string.Format("The highest Temp of the week was: {0}", cb.DetermineHighest(cb.DetermineHighest(Convert.ToInt32(SundayTextBox.Text), Convert.ToInt32(MondayTextBox.Text), Convert.ToInt32(TuesdayTextBox.Text), Convert.ToInt32(WednesdayTextBox.Text), Convert.ToInt32(ThursdayTextBox.Text), (Convert.ToInt32(FridayTextBox.Text)), Convert.ToInt32(SaturdayTextBox.Text));

            //int num1, num2, num3, num4, num5, num6, num7;
            //if (int.TryParse(SundayTextBox.Text, out num1) && int.TryParse(MondayTextBox.Text, out num2) && int.TryParse(TuesdayTextBox.Text, out num3) && int.TryParse(WednesdayTextBox.Text, out num4) &&
            //    int.TryParse(ThursdayTextBox.Text, out num5) && int.TryParse(FridayTextBox.Text, out num6) && int.TryParse(SaturdayTextBox.Text, out num7))
            //{
            //    cb.DetermineHighest( num1, num2, num3, num4, num5, num6, num7);
            //    OutPutDisplayCalc.Text = string.Format("The highest Temp of the week was: {0}", cb.DetermineAverage());
            //}

            //else
            //{
            //    SundayTextBox.Text = "0";
            //    MondayTextBox.Text = "0";
            //    TuesdayTextBox.Text = "0";
            //    WednesdayTextBox.Text = "0";
            //    ThursdayTextBox.Text = "0";
            //    FridayTextBox.Text = "0";
            //    SaturdayTextBox.Text = "0";
            //}

        }
    }
}
