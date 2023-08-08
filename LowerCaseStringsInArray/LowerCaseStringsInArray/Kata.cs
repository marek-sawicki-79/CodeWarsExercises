using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowerCaseStringsInArray
{
    public class Kata
    {
        public static object[] ArrayLowerCase(object[] arr)
        {
            object[] resultArr = new object[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                _ = (arr[i] is string) ? resultArr[i] = arr[i].ToString().ToLower() : resultArr[i] = arr[i];
            }
            return resultArr;
        }
    }
}
