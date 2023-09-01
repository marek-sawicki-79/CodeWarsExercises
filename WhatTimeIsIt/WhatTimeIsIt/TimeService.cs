using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatTimeIsIt
{
    public class TimeService
    {

        public string GetMilitaryTimeFromStandardTime(string time)
        {
            string[] strings = time.Split(':');
            string[] result = new string[strings.Length];
            result[1] = strings[1];
            result[2] = strings[2].Substring(0, strings[2].Length - 2);

            if (strings[2].EndsWith("PM"))
            {
                result[0] = (int.Parse(strings[0]) + 12).ToString();
            }
            else if (strings[0] == "12" && strings[2].EndsWith("AM"))
            {
                result[0] = "00";
            }
            else
            {
                result[0] = strings[0];
            }
            return string.Join(":", result);
        }
    }
}
