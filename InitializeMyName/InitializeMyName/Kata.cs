using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitializeMyName
{
    public class Kata
    {
        public static string InitializeNames(string name)
        {
            //string[] names = name.Split(' ');
            //if(names.Length > 2)
            //{
            //    for(int i = 1; i < names.Length - 1; i++)
            //    {
            //        names[i] = $"{names[i][0]}.";
            //    }
            //}
            //return string.Join(" ", names);

            return name.Split().Skip(1).SkipLast(1).Aggregate(name, (s, n) => s.Replace(n, n[0] + "."));
        }
    }
}
