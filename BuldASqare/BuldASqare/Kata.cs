using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuldASqare
{
    public static class Kata
    {
        public static string GenerateShape(int n)
        {
            char plus = '+';
            StringBuilder square = new StringBuilder();
            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    square.Append(plus);
                }
                if(i < n - 1)
                {
                    square.Append("\n");
                }
            }
            return square.ToString();
        }
    }
}
