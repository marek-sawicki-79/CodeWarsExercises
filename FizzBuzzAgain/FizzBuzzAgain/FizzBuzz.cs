using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzAgain
{
	public class FizzBuzz
	{
		public static string[] GetFizzBuzzArray(int n)
		{
			string[] result = new string[n];
			for (int i = 1; i <= n; i++)
			{
				if (i % 3 == 0 && i % 5 == 0) result[i - 1] = "FizzBuzz";
				else if (i % 3 == 0) result[i - 1] = "Fizz";
				else if (i % 5 == 0) result[i - 1] = "Buzz";
				else result[i - 1] = i.ToString();
			}

			return result;
		}
	}
}
