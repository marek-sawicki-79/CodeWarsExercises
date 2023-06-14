using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvevStringSort
{
    public class Kata
    {
        public static string SortMyString(string s)
        {
            //List<char> evenChars = new List<char>();
            //List<char> oddChars = new List<char>();
            //for(int i = 0; i < s.Length; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        evenChars.Add(s[i]);
            //    }
            //    else
            //    {
            //        oddChars.Add(s[i]);
            //    }
            //}
            //return $"{string.Concat(evenChars)} {string.Concat(oddChars)}";
            return $"{string.Concat(s.Where((x, i) => i % 2 == 0))} {string.Concat(s.Where((x, i) => i % 2 != 0))}";
        }
    }    
}
