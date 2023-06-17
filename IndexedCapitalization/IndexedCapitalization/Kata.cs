using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexedCapitalization
{
    public static class Kata
    {
        public static string Capitalize(string s, List<int> idxs)
        {
            char[] charArr = s.ToCharArray();
            foreach(int index in idxs)
            {
                if(index > charArr.Length)
                {
                    break;
                }
                else
                {
                    charArr[index] = char.ToUpper(charArr[index]);
                }
            }
            return new string(charArr);
        }
    }
}
