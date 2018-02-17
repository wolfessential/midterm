using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamesWolfLab3_GranolaBar
{
    class GranolaBar
    {
        static void Main(string[] args)
        {
            
            DisplayGreetings();

            Console.ReadKey();

            

            DisplayInputBars();
            Console.ReadKey();

            GetPriceBar();
            Console.ReadKey();



        }

        public static void DisplayGreetings()
        {
            Console.WriteLine("Welcome Computer Culb member to the Granola Bar Calculator!\nPlease press any key to continue: ");
            
        }

        public static int GetCasesSold()
        {
            Console.WriteLine("How many cases did you sell?");
            int stuCasesSold = Convert.ToInt32(Console.ReadLine());
            return stuCasesSold;
            
        }
        
        public static int ClaculateBars( int caseSold)
        {
            return caseSold * 12;
           
        }

        public static decimal GetPriceBar()
        {
            Console.WriteLine("What price did sell each bar?\n(Please enter in decimal format ie 5.00) : ");
            decimal stuBarPrice = Convert.ToDecimal(Console.ReadLine());
            return stuBarPrice;
        }

        public static int ClaculateTotalBPrice(int barsSold, int caseSold, int stuBarPrice)
        {
            return  barsSold * stuBarPrice - (caseSold * 5);
        }
    
        public static void DisplayInputBars()
        {
            int stuCasesSold = GetCasesSold();
            int barsSold = ClaculateBars(stuCasesSold);
            Console.WriteLine("Number of actual bars sold {0}/npress any key to continue:", barsSold);
        }

        public static void DisplayTotalBeforeTax()
        {
            int totalPriceAfterTax = ClaculateTotalBPrice(); 
      
            Console.WriteLine("You made this much before Student Government Tax: {0:c} ", totalPriceAfterTax);
        }

    }

}
