using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamesWolfExam1 //This is not part of the EXAM. 
    //For FUN I wanted to try and make an interface just to see what it would look like
    //or do. Just for fun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to the Pet Store database\nPress any key to continue.");
            Console.ReadKey();

            Console.Write("Please fill out the info bellow.\nAnimal Type: ");
            string animalType = Console.ReadLine();
            Console.Write("\nAnimal Breed: ");
            string breedType = Console.ReadLine();
            Console.Write("\nColor: ");
            string colorType = Console.ReadLine();
            Console.Write("\nGender (M or F): ");
            string genderType = Console.ReadLine();
            Console.Write("\nCost: ");
            double animalCost = Convert.ToDouble(Console.ReadLine());

            animal cb = new animal(animalType, breedType, colorType, genderType, animalCost);

            Console.Write("\n\nIs this information correct?\n\nAnimal: {0}\nBreed: {1}\nColor: {2}\nGender: {3}\nCost: {4:c}\n ", cb.TheAnimalType, cb.TheBreed, cb.TheColor, cb.TheGender, cb.TheCost);
            Console.ReadKey();

            
        }
    }
}
