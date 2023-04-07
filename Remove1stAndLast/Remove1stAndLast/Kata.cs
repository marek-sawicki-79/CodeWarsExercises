using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove1stAndLast
{
    public class Kata
    {
        public static string Remove_char(string s)
        {
            var sToCharList = s.ToCharArray().ToList();
            sToCharList.RemoveAt(0);
            sToCharList.RemoveAt(sToCharList.Count - 1);
            var result = sToCharList.ToString(); 
            return result;
        }
    }
}
