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

            Console.WriteLine("How many cases did you sell?");
            int stuCasesSold = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What price did you sell each bar?\n(Please enter in decimal format ie 5.00): ");
            decimal stuBarPrice = Convert.ToDecimal(Console.ReadLine());

            int barsSold = CalculateBars(stuCasesSold);
            Console.WriteLine("Number of actual bars sold {0}\n", barsSold);

            decimal totalPriceAfterTax = CalculateTotalBPrice(barsSold, stuCasesSold, stuBarPrice);
            Console.WriteLine("You made {0:c} before Student Government Theft", totalPriceAfterTax);
            Console.ReadKey();
        }

        public static void DisplayGreetings()
        {
            Console.WriteLine("Welcome Computer Club member to the Granola Bar Calculator!\nPlease press any key to continue:");
            Console.ReadKey();
        }
        
        public static int CalculateBars(int caseSold)
        {
            return caseSold * 12;
        }

        public static decimal CalculateTotalBPrice(int barsSold, int caseSold, decimal stuBarPrice)
        {
            decimal convertBarsSold = Convert.ToDecimal(barsSold);
            decimal convertCaseSold = Convert.ToDecimal(caseSold);
            return convertBarsSold * stuBarPrice - (convertCaseSold * 5);
        }
    }
}
