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
            var uniqueCharCount = s.ToLower().GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
            int countThatSh = uniqueCharCount.First().Value;
            return uniqueCharCount.All(pair => pair.Value == countThatSh);
        }
    }
}
