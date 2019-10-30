using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3.InheritanceAndPolymorphism
{
    public class Hedgehog : Animal
    {
        public int NoOfSpikes { get; protected set; }
        public Hedgehog(string name, double weight, int age, int noofspikes) : base(name, weight, age)
        {
            NoOfSpikes = noofspikes;
        }
    }
}
