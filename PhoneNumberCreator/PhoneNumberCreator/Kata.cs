using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumberCreator
{
    public class Kata
    {
        public static string CreatePhoneNumber(int[] numbers)
        {
            return $"({numbers[0]}{numbers[1]}{numbers[2]}) " +
                $"{numbers[3]}{numbers[4]}{numbers[5]}-" +
                $"{numbers[6]}{numbers[7]}{numbers[8]}{numbers[9]}";
        }
    }
}
