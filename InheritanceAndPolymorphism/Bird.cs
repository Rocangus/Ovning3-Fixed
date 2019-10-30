using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3.InheritanceAndPolymorphism
{
    public class Bird : Animal
    {
        // Any additional property that all birds should have should be added in this class; Bird
        public int Feathers { get; protected set; }
        public Bird(string name, double weight, int age, int feathers) : base(name, weight, age)
        {
            Feathers = feathers;
        }

        public override string Stats()
        {
            return String.Format(base.Stats() + ", number of feathers: {0}", Feathers);
        }
    }
}
