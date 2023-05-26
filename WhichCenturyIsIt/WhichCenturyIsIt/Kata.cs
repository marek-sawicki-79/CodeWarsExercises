using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhichCenturyIsIt
{
    public class Kata
    {
        public static string WhatCentury(string year)
        {
            int century = (int)Math.Ceiling(double.Parse(year) / 100);
            string age = century.ToString();
            if (century > 19 && age[1] == '1') return $"{age}st";
            else if (century > 19 && age[1] == '2') return $"{age}nd";
            else if (century > 19 && age[1] == '3') return $"{age}rd";
            else return $"{age}th";
        }
    }
}
