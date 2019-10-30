using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3.InheritanceAndPolymorphism
{
    public class Swan : Bird
    {
        public bool IsAngry { get; protected set; }
        public Swan(string name, double weight, int age, int feathers, bool isangry) : base(name, weight, age, feathers)
        {
            IsAngry = isangry;
        }
    }
}
