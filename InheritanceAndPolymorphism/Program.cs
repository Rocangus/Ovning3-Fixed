using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3.InheritanceAndPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<Animal>();

            animals.Add(new Swan("Bertil", 19.8, 4, 250, true));
            animals.Add(new Dog("Lassie", 14.7, 5, 3.2));
            animals.Add(new Hedgehog("Olle", 7.4, 2, 453));
            animals.Add(new Flamingo("Helge", 6.8, 3, 253, DateTime.Now));
            animals.Add(new Bird("Wilhelm", 0.1, 2, 57));
            animals.Add(new Pelican("Rudolf", 5.7, 3, 643, 3));
            animals.Add(new Horse("Gustav", 175.38, 6, 4));

            StringBuilder builder = new StringBuilder();

            foreach (Animal animal in animals)
            {
                builder.AppendLine(animal.Name);
            }

            Console.WriteLine(builder.ToString());
        }
    }
}
