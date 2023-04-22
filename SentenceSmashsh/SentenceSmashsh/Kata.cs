using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenceSmashsh
{
    public class Kata
    {
        public static string Smash(string[] words)
        {
            //string result = "";
            //for (int i = 0; i < words.Length; i++)
            //{
            //    result += words[i];
            //    if (i != words.Length - 1)
            //    {
            //        result += " ";
            //    }
            //}
            //return result;
            return string.Join(" ", words);
        }
    }
}
