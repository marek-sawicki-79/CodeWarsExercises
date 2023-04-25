using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectStringMistakes
{
    public class Kata
    {
        public static string Correct(string text)
        {
            Dictionary<char, char> fixMistake = new Dictionary<char, char>()
            {
                { '5', 'S' },
                { '0', 'O' },
                { '1', 'I' }

            };
            StringBuilder result = new StringBuilder();
            foreach (char c in text)
            {
                    if (char.IsDigit(c))
                    {
                        result.Append(fixMistake[c]);
                    }
                    else result.Append(c);
            }
            return result.ToString();
        }
    }
}
