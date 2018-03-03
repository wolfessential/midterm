using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JamesWolfChapter5
{
    public partial class AreaCalculator : Form
    {
        CalculatorBusniess cb;
        public AreaCalculator()
        {
            InitializeComponent();
            cb = new CalculatorBusniess();
        }

      

        private void AreaOfCircle_CheckedChanged(object sender, EventArgs e)
        {
           if (AreaOfCircle.Checked)
            {
                RadiusData.Visible = true;
            }
           else
            {
                RadiusData.Visible = false;
            }
           
        }

        private void AreaOfRectangle_CheckedChanged(object sender, EventArgs e)
        {
            if (AreaOfRectangle.Checked)
            {
                LengthData.Visible = true;
                WidthData.Visible = true;
            }
            else
            {
                LengthData.Visible = false;
                WidthData.Visible = false;
            }

        }

        private void AreaOfCylinder_CheckedChanged(object sender, EventArgs e)
        {
            if (AreaOfCylinder.Checked)
            {
                RadiusData.Visible = true;
                HeightData.Visible = true;
            }
            else
            {
                RadiusData.Visible = false;
                HeightData.Visible = false;
            }
        }
    }

   
}
