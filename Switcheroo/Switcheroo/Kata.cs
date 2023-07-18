using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switcheroo
{
    public class Kata
    {
        public static string Switcheroo(string x)
        {
            //StringBuilder newX = new StringBuilder();
            //foreach (char c in x)
            //{
            //    _ = (c == 'a') ? newX.Append('b') : (c == 'b') ? newX.Append('a') : newX.Append(c);
            //}
            //return newX.ToString();

            return x.Replace("a", "d").Replace("b", "a").Replace("d", "b");
        }
    }
}
