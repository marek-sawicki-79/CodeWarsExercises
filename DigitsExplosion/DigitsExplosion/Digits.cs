﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitsExplosion
{
    public class Digits
    {
        public static string Explode(string s)
        {
            string result = "";
            foreach (char c in s)
            {
                string ble = new string(c, int.Parse(c.ToString()));
                result = result + ble;
            }
            return result;
        }
    }
}
