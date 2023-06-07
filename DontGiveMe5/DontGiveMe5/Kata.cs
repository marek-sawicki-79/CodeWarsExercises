using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontGiveMe5
{
    public class Kata
    {
        public static int DontGiveMeFive(int start, int end)
        {
            List<int> numbers = new List<int>();
            for (int i = start; i <= end; i++)
            {
                if (!i.ToString().Contains("5"))
                {
                    numbers.Add(i);
                }
            }
            return numbers.Count;
        }
    }
}
