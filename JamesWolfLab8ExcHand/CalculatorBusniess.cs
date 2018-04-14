using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamesWolfLab8ExcHand
{
    class CalculatorBusniess //This is my CalculatorBusniess class this will handle my calculations.
    {


        //Addition method, when a new instance of CalculatorBusniess is created and this is called it will 
        //take two intergers from the two textboxes and return the calculation.
        public int Addition( int numOneIn, int NumTwoIn )
        {
            int additionOutput = 0;
            int addMath = numOneIn + NumTwoIn;
            additionOutput = addMath;
            return additionOutput;

        }

        //Subtraction method, when a new instance of CalculatorBusniess is created and this is called it will 
        //take two intergers from the two textboxes and return the calculation.
        public int Subtraction(int numOneIn, int NumTwoIn)
        {
            int subtractionOutput = 0;
            int subMath = numOneIn - NumTwoIn;
            subtractionOutput = subMath;
            return subtractionOutput;
        }

        //Multiply method, when a new instance of CalculatorBusniess is created and this is called it will 
        //take two intergers from the two textboxes and return the calculation.
        public int Multiply(int numOneIn, int NumTwoIn)
        {
            int multiplyOutput = 0;
            int mulMath = numOneIn * NumTwoIn;
            multiplyOutput = mulMath;
            return multiplyOutput;
        }

        //Divide method, when a new instance of CalculatorBusniess is created and this is called it will 
        //take two intergers from the two textboxes and return the calculation.
        public int Divide(int numOneIn, int NumTwoIn)
        {
            double divideOutput;
            Convert.ToDouble(numOneIn);
            Convert.ToDouble(NumTwoIn);
            double divMath =  numOneIn /  NumTwoIn;
            divideOutput = divMath;
            return Convert.ToInt32(divideOutput);
        }
    }
}
