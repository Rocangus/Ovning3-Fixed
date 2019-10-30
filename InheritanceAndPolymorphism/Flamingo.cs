using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3.InheritanceAndPolymorphism
{
    public class Flamingo : Bird
    {
        public DateTime LastCaughtSleeping { get; protected set; }
        public Flamingo(string name, double weight, int age, int feathers, DateTime lastcaughtsleeping) : base(name, weight, age, feathers)
        {
            LastCaughtSleeping = lastcaughtsleeping;
        }

        public override string Stats()
        {
            return String.Format(base.Stats() + ", last caught sleeping: {0}", LastCaughtSleeping);
        }
    }
}
