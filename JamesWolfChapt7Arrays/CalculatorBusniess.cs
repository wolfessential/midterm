using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamesWolfChapt7Arrays
{
    class CalculatorBusniess
    {
        public int[] weeksTemps;
        public int numDaysUnder;
        public int averageCalc;
        public int averageExcludingLowest;
        public int highest;
        public int lowest;
        public int numberDaysUnderU;
        DayOfWeekTemps currentTemps;

        public int[] WeeksTemperatures
        {
            get
            {
                return weeksTemps;
            }
        }

        public int NumberDaysUnder
        {
            get
            {
                return numDaysUnder;
            }
        }

        public int AverageCalc
        {
            get
            {
                return averageCalc;
            }
        }

        public int AverageExLowest
        {
            set
            {
                averageExcludingLowest = value;
            }
            get
            {
                return averageExcludingLowest;
            }
        }


        public int ReturnHighest
        {
            set
            {
                highest = value;
            }
            get
            {
                return highest;
            }
        }

        public int ReturnLowest
        {
            set
            {
                lowest = value;
            }
            get
            {
                return lowest;
            }
        }

        public int NumberOfDaysUnderU
        {
            set
            {
                numberDaysUnderU = value;
            }
            get
            {
                return numberDaysUnderU;
            }
        }
        public CalculatorBusniess()
        {

        }
        public CalculatorBusniess(int[] wTemps, int daysU)
        {
            weeksTemps = wTemps;
            numDaysUnder = daysU;
            DetermineAverage();
            DetermineAverageExcludingLowest();
            //DetermineHighest;
            DetermineLowest();
            DetermineNumberOfDays();
            
        }
       
        public int DetermineAverage()
        {
            int inaverage = 0;
            for (int i = 0; i<7; i++)
            {
                inaverage = inaverage + weeksTemps[i];

            }
            averageCalc = inaverage / 7;
            return inaverage;
        }

        public int DetermineAverageExcludingLowest()
        {
            for (int i = 0; i < 7; i++)
            {
                averageExcludingLowest = averageExcludingLowest + weeksTemps[i];
                if (weeksTemps[i] < lowest)
                {
                    lowest = weeksTemps[i];
                }
            }
            averageExcludingLowest = ((averageExcludingLowest - lowest) / 7);
            return averageExcludingLowest;
        }

        public CalculatorBusniess (int temp1, int temp2, int temp3, int temp4, int temp5, int temp6, int temp7)
        {
            weeksTemps = new int[] { temp1, temp2, temp3, temp4, temp5, temp6, temp7 };
            Array.Sort(weeksTemps);
        }

        public int DetermineLowest()
        {
            return weeksTemps[0];
        }

        public int DetermineHighest(int temp1, int temp2, int temp3, int temp4, int temp5, int temp6, int temp7)
        {
            currentTemps = new DayOfWeekTemps(temp1, temp2, temp3, temp4, temp5, temp6, temp7);
            //Array.Sort(weeksTemps);
            return currentTemps.GetHighestTemp();

        }

        public int DetermineNumberOfDays()
        {
            for (int i = 0; i < 7; i++)
            {
                if (weeksTemps[i] < numDaysUnder)
                {
                    numberDaysUnderU++;
                }
            }
            return numberDaysUnderU;
        }
    } 
}
