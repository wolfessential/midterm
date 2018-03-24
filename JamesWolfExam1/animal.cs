using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamesWolfExam1//Instuctions didn't say to make this a Windows form app of TOY. SO I decided to just do this in a console app.
{
    class animal //This is my animal class. 
    {
        //The class should have appropriate data type fields.
        //These are my data type fields.
        private string theAnimalType;
        private string theBreed;
        private string theColor;
        private string theGender;
        private double theCost;
        private double theSalesTax; //Added a field to store sales tax


        //Setting my properties for all fields by getters and setters

        public string TheAnimalType
        {
            get
            {
                return theAnimalType;
            }

            set
            {
                theAnimalType = value;
            }
        }

        public string TheBreed
        {
            get
            {
                return theBreed;
            }
            set
            {
                theBreed = value;
            }
        }

        public string TheColor
        {
            get
            {
                return theColor;
            }
            set
            {
                theColor = value;
            }
        }


        //Per the instuctions, edit my gender property so it looks for values "F" and "M"
        //and change to "Female" and "Male". I wasn't sure if it only wanted to set Male
        //or Female only by F or M, but I decided to just follow instuctions as they were written.
        public string TheGender
        {
            get
            {
                return theGender;
            }
            //I had originally had my setter like this but the instuctions said to change, I didn't know if I should have left this in
            //But decieded to comment it out and follow the instuctions as written.

            //set
            //{
            //    theGender = value;
            //}
            set
            {
                
                if (value == "M" )
                {
                    theGender = value + "Male";
                }

                if (value =="F")
                {
                    theGender = value + "Female";
                }

            }
        }
        public double TheCost
        {
            get
            {
                return theCost;
            }
            set
            {
                theCost = value;
            }
        }
        //This is my Default Constructor that will set the fields as listed bellow. The vaules match the feilds above.
        public animal()
        {
            theAnimalType = "Cat";
            theBreed = "Siamese";
            theColor = "Seal Point";
            theGender = "Male";
            theCost = 5000.00;
        }

        //I built a constructor that will accept the all fields values to instantiate when needed
        public animal(string aAnimalType, string aBreed, string aColor, string aGender, double aCost)
        {
            theAnimalType = aAnimalType;
            theBreed = aBreed;
            theColor = aColor;
            theGender = aGender;
            theCost = aCost;
        }
        //Added a field above with the other fields.
        //I did not add to the constructors per instructions.
        //This is a method to calculate sales tax of 7.5 percent and then store that amount in the field.
        //I made this void because instructions did not say to return just store.
        public void CalculateSalesTax()
        {
            theSalesTax = theCost * 0.075;
        }
            

    }
}
