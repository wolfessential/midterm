﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordScambler
{
    class ScrambleClass
    {
        private string strUserWord;
        Random r = new Random();
        Random r2 = new Random();
        int intRandom = 0;

        public string ScrambleEasy()
        {

            string[] strWordList = { "cat", "dog", "boy", "cup", "car", "kid", "toy", "ball", "fall", "joy" };
            string EasyMixArrange = null;
            intRandom = r.Next(10);
            EasyMixArrange = strWordList[intRandom];
            strUserWord = EasyMixArrange;
            for (int i = 0; i < 20; i++)
            {
                string strArrange2;
                int intRandom2 = r2.Next(EasyMixArrange.Length);
                strArrange2 = EasyMixArrange.Substring(intRandom2, 1);
                EasyMixArrange = EasyMixArrange.Remove(intRandom2, 1);
                EasyMixArrange = EasyMixArrange.Insert(EasyMixArrange.Length, strArrange2);
            }


            

            return EasyMixArrange;

        }


       

        public string ScrambleMedium()
        {

            string[] strWordList = { "nose", "grow", "bird", "game", "hard", "jump", "sell", "gift", "more", "jean" };
            string MedMixArrange = null;
            intRandom = r.Next(10);
            MedMixArrange = strWordList[intRandom];
            strUserWord = MedMixArrange;
            for (int i = 0; i < 20; i++)
            {
                string strArrange2;
                int intRandom2 = r2.Next(MedMixArrange.Length);
                strArrange2 = MedMixArrange.Substring(intRandom2, 1);
                MedMixArrange = MedMixArrange.Remove(intRandom2, 1);
                MedMixArrange = MedMixArrange.Insert(MedMixArrange.Length, strArrange2);
            }


            return MedMixArrange;
        }

        public string ScrambleHard()
        {

            string[] strWordList = { "truck", "train", "craft", "dinner", "apple", "start", "paint", "room", "chair", "phone" };
            string HardMixArrange = null;
            intRandom = r.Next(10);
            HardMixArrange = strWordList[intRandom];
            strUserWord = HardMixArrange;
            for (int i = 0; i < 20; i++)
            {
                string strArrange2;
                int intRandom2 = r2.Next(HardMixArrange.Length);
                strArrange2 = HardMixArrange.Substring(intRandom2, 1);
                HardMixArrange = HardMixArrange.Remove(intRandom2, 1);
                HardMixArrange = HardMixArrange.Insert(HardMixArrange.Length, strArrange2);
            }


            return HardMixArrange;
        }



    }

}
