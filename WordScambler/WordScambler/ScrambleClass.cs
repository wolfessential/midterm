using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordScambler
    // James, Kyle Words by Chad
{
    class ScrambleClass
    {
        // Declare variables
        private string OringinalWord;
        private string strUserWord;
        // Radomize the words
        Random r = new Random();
        Random r2 = new Random();
        int intRandom = 0;

        // Methods for the scrambling/word list
        public string ScrambleEasy()
            // Easy words
        {
            // Array for the word list
            string[] strWordList = { "cat", "dog", "boy", "ice", "mad", "nut", "old", "ram", "cup",
        "car", "kid", "toy", "bin", "bit", "sun", "one", "two", "six", "ten", "abs",
        "ace", "son", "box", "bun", "bid", "bee", "run", "see", "sea", "lip" };
            string EasyMixArrange = null;
            intRandom = r.Next(30);
            EasyMixArrange = strWordList[intRandom];
            strUserWord = EasyMixArrange;
            OringinalWord = EasyMixArrange;
            for (int i = 0; i < 20; i++)
            {
                if (EasyMixArrange == OringinalWord) // this is checking to see the unscrambled word is not displayed and if it is it loops through the scrambling again
                {
                    string strArrange2;
                    int intRandom2 = r2.Next(EasyMixArrange.Length);
                    strArrange2 = EasyMixArrange.Substring(intRandom2, 1);
                    EasyMixArrange = EasyMixArrange.Remove(intRandom2, 1);
                    EasyMixArrange = EasyMixArrange.Insert(EasyMixArrange.Length, strArrange2);

                }

                else
                {
                    break;
                }
               
            }


            

            return EasyMixArrange;

        }


       

        public string ScrambleMedium()
        {
            // Array for the word list
            string[] strWordList = { "nose", "easy", "girl", "grew", "nice", "tree", "then",
                         "than", "this", "that", "bird", "grow", "game", "hard", "sell", "fall",
                         "more", "gift", "jump", "snow", "rain", "fish", "able", "also", "acid",
                         "area", "math", "four", "five", "nine"  };
            string MedMixArrange = null;
            intRandom = r.Next(30);
            MedMixArrange = strWordList[intRandom];
            strUserWord = MedMixArrange;
            OringinalWord = MedMixArrange;
            for (int i = 0; i < 20; i++)
            {
                if (MedMixArrange == OringinalWord) // this is checking to see the unscrambled word is not displayed and if it is it loops through the scrambling again
                {
                    string strArrange2;
                    int intRandom2 = r2.Next(MedMixArrange.Length);
                    strArrange2 = MedMixArrange.Substring(intRandom2, 1);
                    MedMixArrange = MedMixArrange.Remove(intRandom2, 1);
                    MedMixArrange = MedMixArrange.Insert(MedMixArrange.Length, strArrange2);

                }

                else
                {
                    break;
                }
            
            }



            return MedMixArrange;
        }

        public string ScrambleHard()
        {
            // Array for the word list
            string[] strWordList = {"three", "spell", "grave", "stone", "truck", "apple",
                               "craft", "horse", "start", "train", "paint", "agree",
                              "again", "alert", "block", "cover", "daily", "cream", "delay", "earth",
                             "faith", "lunch", "magic", "rapid", "sleep", "title", "upper", "worse",
                                "woman", "virus", "water"
};
            string HardMixArrange = null;
            intRandom = r.Next(31);
            HardMixArrange = strWordList[intRandom];
            strUserWord = HardMixArrange;
            OringinalWord = HardMixArrange;
            for (int i = 0; i < 20; i++)
            {
                if(HardMixArrange == OringinalWord) // this is checking to see the unscrambled word is not displayed and if it is it loops through the scrambling again
                {

                    string strArrange2;
                    int intRandom2 = r2.Next(HardMixArrange.Length);
                    strArrange2 = HardMixArrange.Substring(intRandom2, 1);
                    HardMixArrange = HardMixArrange.Remove(intRandom2, 1);
                    HardMixArrange = HardMixArrange.Insert(HardMixArrange.Length, strArrange2);

                }

                else
                {
                    break;
                }


                
            }



            return HardMixArrange;
        }

        // Comparing the user input to the correct and returns true or false
        public bool CompareWord(string UserGuess)

        {
            if (UserGuess.ToLower() == OringinalWord)
            {
                // True 
                bool Value = true;
                return Value;
            }
            else 
            {
                // False
                bool Value = false;
                return Value;
            }

        }



    }

}
