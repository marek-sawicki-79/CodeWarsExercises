﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SpecialNumber
{
    class Kata
    {
        public static string SpecialNumber(int number)
        {
            //string compare = "012345";
            //string num = number.ToString();
            //return (num.All(c => compare.Contains(c))) ? "Special!!" : "NOT!!";

            return Regex.IsMatch(number.ToString(), "[^0-5]") ? "NOT!!" : "Special!!";
        }
    }
}
