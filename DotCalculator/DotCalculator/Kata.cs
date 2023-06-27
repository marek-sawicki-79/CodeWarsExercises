using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotCalculator
{
    public static class Kata
    {
        public static string Calculator(string txt)
        {
            //int dotCount = 0;
            //string result = "";
            //string[] elements = txt.Split(' ');
            //switch (elements[1])
            //{
            //    case "+":
            //        dotCount = elements[0].Length + elements[2].Length;
            //        result = string.Join("", Enumerable.Repeat(".", dotCount));
            //        return result;
            //    case "-":
            //        dotCount = elements[0].Length - elements[2].Length;
            //        result = string.Join("", Enumerable.Repeat(".", dotCount));
            //        return result;
            //    case "//":
            //        dotCount = elements[0].Length / elements[2].Length;
            //        result = string.Join("", Enumerable.Repeat(".", dotCount));
            //        return result;
            //    case "*":
            //        dotCount = elements[0].Length * elements[2].Length;
            //        result = string.Join("", Enumerable.Repeat(".", dotCount));
            //        return result;
            //        default:
            //        return "bad data";
            //}

            var s = txt.Replace("//", "/").Split();
            return new string('.', Convert.ToInt32(new DataTable().Compute($"{s[0].Length}{s[1]}{s[2].Length}", null)));
        }
    }
}
