using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3.InheritanceAndPolymorphism
{
    public class Animal
    {
        public string Name { get; protected set; }
        public double Weight { get; protected set; }
        public int Age { get; protected set; }

        public Animal(string name, double weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }
    }
}
