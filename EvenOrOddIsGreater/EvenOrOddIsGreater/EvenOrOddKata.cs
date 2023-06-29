using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOddIsGreater
{
    public class EvenOrOddKata
    {
        public static string EvenOrOdd(string str)
        {
            List<int> odds = new List<int>();
            List<int> evens = new List<int>();
            int[] numbers = str.Select(c => Convert.ToInt32(c.ToString())).ToArray();
            foreach(int n in numbers)
            {
                if(n % 2 == 0)
                {
                    evens.Add(n);
                }
                else odds.Add(n);
            }
            return (odds.Sum() > evens.Sum()) ? "Odd is greater than Even" :
                (odds.Sum() < evens.Sum()) ? "Even is greater than Odd" : "Even and Odd are the same";
        }
    }
}
