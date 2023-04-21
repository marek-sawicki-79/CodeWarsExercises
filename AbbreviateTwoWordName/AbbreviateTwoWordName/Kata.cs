using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbreviateTwoWordName
{
    public class Kata
    {
        public static string AbbrevName(string name)
        {
            string[] nameSplit = name.Split(' ');
            char first = nameSplit[0][0];
            char second = nameSplit[1][0];
            return $"{first.ToString().ToUpper()}.{second.ToString().ToUpper()}";
        }
    }
}
