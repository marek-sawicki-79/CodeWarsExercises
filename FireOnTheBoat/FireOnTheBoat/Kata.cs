using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireOnTheBoat
{
    public class Kata
    {
        public static string FireFight(string s)
        {
            //string[] boatItems = s.Split(" ");
            //for(int i = 0; i < boatItems.Length; i++)
            //{
            //    if(boatItems[i] == "Fire")
            //    {
            //        boatItems[i] = "~~";
            //    }
            //}
            //return string.Join(" ", boatItems);

            return s.Replace("Fire", "~~");
        }
    }
}
