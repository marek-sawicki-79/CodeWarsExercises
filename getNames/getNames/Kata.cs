﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getNames
{
    public class Kata
    {
        public static string[] GetNames(Person[] data)
        {
            string[] names = new string[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                names[i] = data[i].Name;
            }
            return names;
        }
        public class Person
        {
            public int Age;
            public string Name;

            public Person(string name = "John", int age = 21)
            {
                Age = age;
                Name = name;
            }
        }

        Person[] data = new Person[]
        {
            new Person("Joe", 20),
            new Person("Bill", 30),
             new Person("Kate", 23)
        };
    }
}
