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
            Horse gustav = new Horse("Gustav", 175.38, 6, 4);
            animals.Add(gustav);

            StringBuilder builder = new StringBuilder();

            foreach (Animal animal in animals)
            {
                builder.AppendLine(animal.Name);
            }

            Console.WriteLine(builder.ToString());

            //var dogs = new List<Dog>();
            //dogs.Add(gustav);
            // This does not work because an instance of Horse is not an instance of Dog or a class derived from Dog.
            // The list must take the type Animal in order for all my animals to be accepted.

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Stats());
            }
            // The compiler ensures that the latest override is executed and that is why each derived class has its' specific override of Stats() run.

            PrintStatsForDogOnly(animals);
        }

        // Calls Stats() for the Animal instances that are an instance of the derived class Dog only.
        private static void PrintStatsForDogOnly(List<Animal> animals)
        {
            foreach (Animal animal in animals)
            {
                if (animal is Dog)
                {
                    Console.WriteLine(animal.Stats());
                }
            }
        }
    }
}
