using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3.InheritanceAndPolymorphism
{
    public class Bird : Animal
    {
        public int Feathers { get; protected set; }
        public Bird(string name, double weight, int age, int feathers) : base(name, weight, age)
        {
            Feathers = feathers;
        }
    }
}
