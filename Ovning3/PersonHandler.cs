using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3
{
    public class PersonHandler
    {
        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            if (age <= 0)
            {
                Console.WriteLine("A person's age must be greater than zero.");
                return null;
            }
            if (String.IsNullOrEmpty(fname)) 
            {
                Console.WriteLine("First name must not be empty.");
                return null;
            }
            if (String.IsNullOrEmpty(lname))
            {
                Console.WriteLine("Last name must not be empty.");
                return null;
            }
            if (height <= 0)
            {
                Console.WriteLine("Height must be greater than zero.");
                return null;
            }
            if (weight <= 0)
            {
                Console.WriteLine("Weight must be greater than zero.");
                return null;
            }
            Person pers = new Person(age, fname, lname, height, weight);
            return pers;
        } 

        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }
    }
}
