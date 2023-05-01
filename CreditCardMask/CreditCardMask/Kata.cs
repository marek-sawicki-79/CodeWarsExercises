using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardMask
{
    public static class Kata
    {
        public static string Maskify(string cc)
        {
            if (cc.Count() <= 4)
            {
                return cc;
            }
            else
            {
                return cc.Remove(0, cc.Length - 4).Insert(0, new string('#', cc.Length - 4));
            }
        }
    }
}
