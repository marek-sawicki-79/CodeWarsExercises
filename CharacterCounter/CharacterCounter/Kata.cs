using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCounter
{
    public class Kata
    {
        public static bool ValidateWord(string s)
        {
            int uniqueCharCount = s.ToLower().Distinct().Count();
            return (s.Length % uniqueCharCount == 0);
        }
    }
}
