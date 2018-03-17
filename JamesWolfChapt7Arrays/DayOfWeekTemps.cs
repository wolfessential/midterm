using System;
using System.Linq;
namespace JamesWolfChapt7Arrays
{
    class DayOfWeekTemps
    {
        public int[] weekTemps;

        public DayOfWeekTemps()
        {

        }

        public DayOfWeekTemps(int temp1, int temp2, int temp3, int temp4, int temp5, int temp6, int temp7)
        {
            weekTemps = new int[] { temp1, temp2, temp3, temp4, temp5, temp6, temp7 };
            Array.Sort(weekTemps);
        }

        public int[] WeekTemps
        {
            get { return weekTemps; }
        }

        public int GetHighestTemp()
        {
            return weekTemps[6];
        }

        public int GetLowestTemp()
        {
            return weekTemps[0];
        }

        public int GetAverageTemp()
        {
            int totaler = 0;
            foreach(int temp in WeekTemps)
            {
                totaler += temp;
            }
            return totaler / WeekTemps.Length;
        }

        public int GetAveWithoutLowest()
        {
            int totaler = 0;
            int lowT = weekTemps[0];
            
            foreach (int temp in WeekTemps)
            {
                totaler += temp;
            }
            int min = weekTemps.Min();
            int aveT = ((totaler - min) / (WeekTemps.Length - 1));
            return aveT;
        }
    }
}

