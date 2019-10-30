using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3.InheritanceAndPolymorphism
{
    public class Animal
    {
        // Any additional property that all animals should have should be added in this class; Animal
        public string Name { get; protected set; }
        public double Weight { get; protected set; }
        public int Age { get; protected set; }

        public Animal(string name, double weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }

        public virtual string Stats()
        {
            return String.Format("Name: {0}, weight: {1}, age {2}", Name, Weight, Age);
        }
    }
}
