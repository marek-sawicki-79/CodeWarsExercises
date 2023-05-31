using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortMyAnimals
{
    public class Animal
    {
        public string Name { get; set; }
        public int NumberOfLegs { get; set; }
    }

    public class AnimalSorter
    {
        public List<Animal> Sort(List<Animal> input)
        {
            if (input == null || input.Count == 0) return input;
            else return input.OrderBy(a => a.NumberOfLegs).ThenBy(b => b.Name).ToList();
        }
    }
}
