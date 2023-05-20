using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatAndMouse
{
    public class Kata
    {
        public static string CatMouse(string x)
        {
            int count = 0;
            foreach(char c in x)
            {
                if (c == '.') count++;
            }
            if(count > 3) return "Escaped!";
            else return "Caught!";
        }
    }
}
