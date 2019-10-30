using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3.InheritanceAndPolymorphism
{
    public class Dog : Animal
    {
        public double TailLength { get; protected set; }
        public Dog(string name, double weight, int age, double taillength) : base(name, weight, age)
        {
            TailLength = taillength;
        }

        public override string Stats()
        {
            return String.Format(base.Stats() + ", tail length: {0}", TailLength);
        }

        public string Speak()
        {
            return "Woff!";
        }
    }
}
