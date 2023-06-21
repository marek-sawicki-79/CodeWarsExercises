using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOfFirstChars
{
    public partial class Kata
    {
        public static string MakeString(string s)
        {
            string[] toGet = s.Split(' ');
            List<char> chars = new List<char>();
            foreach (string word in toGet)
            {
                chars.Add(word[0]);
            }
            return new string(chars.ToArray());
        }
    }
}
