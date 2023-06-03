using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFiltering
{
    public class ListFilterer
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            List<int> result = new List<int>();
            foreach(object item in listOfItems)
            {
                if(item is int)
                {
                    result.Add((int)item);
                }
            }
            return result;
        }
    }

}
