using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3.Polymorphism
{
    public class DivideByZeroError : UserError
    {
        public override string UEMessage()
        {
            return "You did something which caused the program to attempt to divide by zero. This fired an error!";
        }
    }
}
