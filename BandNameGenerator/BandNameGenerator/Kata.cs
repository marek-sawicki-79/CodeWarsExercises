using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandNameGenerator
{
    public class Kata
    {
        public static string BandNameGenerator(string str)
        {
            if (str[0] != str[str.Length - 1])
            {
                return $"The {char.ToUpper(str[0])}{str.Substring(1)}";
            }
            else
            {
                return char.ToUpper(str[0]) + str.Substring(1) + str.Substring(1);
            }
        }
    }
}
