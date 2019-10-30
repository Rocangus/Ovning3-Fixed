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
                new NumericInputError(), new TextInputError(), new NumericInputError(), new TextInputError()
            };

            foreach (UserError err in errors)
            {
                Console.WriteLine(err.UEMessage());
            }
        }
    }
}
