using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllUnique
{
    public class Unique
    {
        public static bool HasUniqueChars(string str)
        {
            //char[]charArr = str.ToCharArray();
            //Array.Sort(charArr);
            //for(int i = 1; i < str.Length; i++)
            //{
            //    if (charArr[i] == charArr[i - 1]) return false;
            //}
            //return true;
            return str.Distinct().Count() == str.Length;
        }
    }
}
