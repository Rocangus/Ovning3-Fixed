using System;
using System.Collections.Generic;

namespace Ovning3.Polymorphism
{
    class Program
    {
        // Initializes some errors into a list, then prints the messages from the errors in said list.
        static void Main(string[] args)
        {
            var errors = new List<UserError>()
            {
                new NumericInputError(), new TextInputError(), new NumericInputError(), new TextInputError(),
                new DivideByZeroError(), new NumberFormatError(), new EmptyStringError()
            };

            foreach (UserError err in errors)
            {
                Console.WriteLine(err.UEMessage());
            }
        }
        // Polymorphism is important because it allows the same code to be used for different classes.
        // Polymorphism allows for things like the foreach statement above. Regardless of which class the item actually is of, you can run the same code. No need to check for types or so forh; 
        // just write the statement you want to run and it will pretty much just work.
        // An abstract class is inherited much like a normal class. The difference between such a class and an interface is that a class can implement as many interfaces as you like,
        // but each class can only inherit from one abstract class at a time.
    }
}
