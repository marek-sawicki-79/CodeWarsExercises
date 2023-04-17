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
                if (x[i] < '5')
                {
                    newX += '0';
                }
                else newX +='1';
            }
            return newX;
        }
    }
}
