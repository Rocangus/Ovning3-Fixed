using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3
{
    // This class is static because it only changes the state of other objects, not itself.
    public static class PersonHandler
    {
        // Creates a new person.
        public static Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            if (age <= 0)
            {
                PrintAgeError();
                return null;
            }
            if (String.IsNullOrEmpty(fname))
            {
                PrintFirstNameError();
                return null;
            }
            if (String.IsNullOrEmpty(lname))
            {
                PrintLastNameError();
                return null;
            }
            if (height <= 0)
            {
                PrintHeightError();
                return null;
            }
            if (weight <= 0)
            {
                PrintWeightError();
                return null;
            }
            Person pers = new Person(age, fname, lname, height, weight);
            return pers;
        }

        // Methods that print various error messages to the console follow below.
        private static void PrintHeightError()
        {
            Console.WriteLine("Height must be greater than zero.");
        }

        private static void PrintLastNameError()
        {
            Console.WriteLine("Last name must not be empty.");
        }

        private static void PrintFirstNameError()
        {
            Console.WriteLine("First name must not be empty.");
        }

        private static void PrintAgeError()
        {
            Console.WriteLine("A person's age must be greater than zero.");
        }

        private static void PrintWeightError()
        {
            Console.WriteLine("Weight must be greater than zero.");
        }

        // Getters and setters as appropriate for the different properties follow below. Guard statements omitted on purpose.
        public static int GetAge(Person pers)
        {
            return pers.Age;
        }
        public static void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        public static string GetFname (Person pers)
        {
            return pers.FName;
        }

        public static string GetLname (Person pers)
        {
            return pers.LName;
        }

        public static double GetHeight (Person pers)
        {
            return pers.Height;
        }

        public static void SetHeight(Person pers, double height)
        {
                pers.Height = height;
        }

        public static double GetWeight(Person pers)
        {
            return pers.Weight;
        }

        public static void SetWeight(Person pers, double weight)
        {
            pers.Weight = weight;
        }
    }
}
