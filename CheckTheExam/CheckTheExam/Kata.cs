using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckTheExam
{
    public static class Kata
    {
        public static int CheckExam(string[] arr1, string[] arr2)
        {
            int result = 0;
            for (int i = 0; i < arr1.Length && i < arr2.Length; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    result += 4;
                }
                else if (arr2[i] == "")
                {
                    continue;
                }
                else if (arr1[i] != arr2[i])
                {
                    result -= 1;
                }
            }
            if (result < 0) return 0;
            else return result;
        }
    }
}
