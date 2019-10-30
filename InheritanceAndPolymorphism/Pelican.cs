using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3.InheritanceAndPolymorphism
{
    public class Pelican : Bird
    {
        public int FishInBill { get; protected set; }
        public Pelican(string name, double weight, int age, int feathers, int fishinbill) : base(name, weight, age, feathers)
        {
            FishInBill = fishinbill;
        }

        public override string Stats()
        {
            return String.Format(base.Stats() + ", fish in bill: {0}", FishInBill);
        }
    }
}
