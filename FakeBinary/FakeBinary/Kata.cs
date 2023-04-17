using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeBinary
{
    public class Kata
    {
        public static string FakeBin(string x)
        {
            string newX = "";
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] < 5)
                {
                    newX = x.Replace(x[i], '0');
                }
                else newX = x.Replace(x[i], '1');
            }
            return newX;
        }
    }
}
