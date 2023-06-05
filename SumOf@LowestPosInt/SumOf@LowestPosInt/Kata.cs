using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOf_LowestPosInt
{
	public static class Kata
	{
		public static int sumTwoSmallestNumbers(int[] numbers)
		{
			Array.Sort(numbers);
			return numbers[0] + numbers[1];
		}
	}
}
