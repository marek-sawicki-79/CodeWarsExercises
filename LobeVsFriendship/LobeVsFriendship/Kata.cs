using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobeVsFriendship
{
    public static class Kata
    {
        public static int WordsToMarks(string str)
        {
            int result = 0;
            foreach(char c in str)
            {
                result += c - 96;
            }
            return result;
        }
    }
}
