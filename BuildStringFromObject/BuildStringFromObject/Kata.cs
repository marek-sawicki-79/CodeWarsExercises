using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildStringFromObject
{
    public static class Kata
    {
        public static string StringifyDict<TKey, TValue>(Dictionary<TKey, TValue> hash)
        {
            return $"{String.Join(",", hash.Keys)}={String.Join(",", hash.Values)}";
        }
    }
}
