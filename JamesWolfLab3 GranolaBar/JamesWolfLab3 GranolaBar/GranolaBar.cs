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
            
            //Diplay the greeting method 
            DisplayGreetings();

            //Get input for how many cases sold and put into stuCasesSOld
            Console.WriteLine("How many cases did you sell?");
            int stuCasesSold = Convert.ToInt32(Console.ReadLine());

            //Get input for the price per bar sold and put into stuBarPrice
            Console.WriteLine("What price did you sell each bar?\n(Please enter in decimal format ie 5.00): ");
            decimal stuBarPrice = Convert.ToDecimal(Console.ReadLine());

            //The assignment asked to display number of bars actually sold, this code is doing that. Displaying bars sold
            int barsSold = CalculateBars(stuCasesSold);
            Console.WriteLine("Number of actual bars sold {0}\n", barsSold);

            //Calling method CalculateTotalBPrice and putting it into totalPriceBeforeTax to display how much they made before tax
            decimal totalPriceBeforeTax = CalculateTotalBPrice(barsSold, stuCasesSold, stuBarPrice);
            Console.WriteLine("You made {0:c} before Student Government Tax\nPlease press any key to continue:", totalPriceBeforeTax);
            Console.ReadKey();


            //Converting to a double totalPriceBeforetax and Calculating in the tax to Tax
            double converttotalPriceBeforeTax = Convert.ToDouble(totalPriceBeforeTax);
            double Tax = .1 * converttotalPriceBeforeTax;

            //Displaying Tax owed to Student Government
            Console.WriteLine("You owe the Student Government {0:c} in Tax\nPlease press any key to continue:", Tax);
            Console.ReadKey();

            //Converting to a double totalPriceBeforetax and put into convertFinalPrice and then subtracting convertFinalPrice from tax and put into finalTotal
            double convertFinalPrice = Convert.ToDouble(totalPriceBeforeTax);
            double finalTotal = convertFinalPrice - Tax;

            //Displaying the final amount the user made after tax is taken out
            Console.WriteLine("Finally the total amount you've earned for the club (after Student Government Tax) is\n{0:c}\nThanks Computer Club member for using this program. Press any key to exit!", finalTotal);
            Console.ReadKey();
        }



        //Method to display a greeting 
        public static void DisplayGreetings()
        {
            Console.WriteLine("Welcome Computer Club member to the Granola Bar Calculator!\nPlease press any key to continue:");
            Console.ReadKey();
        }

        //Method to calculate the total number of bars sold by multiplying casesSold by 12
        public static int CalculateBars(int caseSold)
        {
            return caseSold * 12;
        }


        //Method to calculate to total price after you subtract the cost per case which is $5
        public static decimal CalculateTotalBPrice(int barsSold, int caseSold, decimal stuBarPrice)
        {
            decimal convertBarsSold = Convert.ToDecimal(barsSold);
            decimal convertCaseSold = Convert.ToDecimal(caseSold);
            return convertBarsSold * stuBarPrice - (convertCaseSold * 5);
        }

        
    } 
}