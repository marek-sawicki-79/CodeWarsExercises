using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithmGenerate
{
    public class Kata
    {
        public string Generate(int length)
        {
            Random random = new Random();
            int[] result = new int[length];
            for(int i = 0; i < length; i++)
            {
                result[i] = random.Next(2);
            }
            return string.Join("", result);
        }
    }
}
