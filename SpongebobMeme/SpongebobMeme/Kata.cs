using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpongebobMeme
{
    public class Kata
    {
        public static string SpongeMeme(string sentence)
        {
            StringBuilder result = new StringBuilder();
            for(int i = 0; i < sentence.Length; i++)
            {
                if(i % 2 == 0)
                {
                    result.Append(char.ToUpper(sentence[i]));
                }
                else
                {
                    result.Append(char.ToLower(sentence[i]));
                }
            }
            return result.ToString();
        }
    }
}
