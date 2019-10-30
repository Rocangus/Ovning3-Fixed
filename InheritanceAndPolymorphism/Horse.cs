using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3.InheritanceAndPolymorphism
{
    public class Horse : Animal
    {
        public int RacesWon { get; protected set; }
        public Horse(string name, double weight, int age, int raceswon) : base(name, weight, age)
        {
            RacesWon = raceswon;
        }

        public override string Stats()
        {
            return String.Format(base.Stats() + ", races won: {0}", RacesWon);
        }
    }
}
