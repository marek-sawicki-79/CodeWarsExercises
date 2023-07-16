using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordValues
{
    public class Kata
    {
        public static int[] WordValue(string[] a)
        {
            int[] result = new int[a.Length];
            int index = 0;
            for (int i = 0; i < a.Length; i++)
            {
                int wordValue = 0;
                foreach (char c in a[i])
                {
                    int charValue = 0;
                    if (c == ' ')
                    {
                        charValue = 0;
                    }
                    else
                    {
                        charValue = (int)(char.ToLower(c) - 'a') + 1;
                    }
                    wordValue += charValue;
                }
                result[index] = wordValue * (i + 1);
                index++;
            }
            return result;
        }
    }
}
