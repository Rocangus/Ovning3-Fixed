using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3.Polymorphism
{
    public class NumberFormatError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to write a number with punctuation for grouping sections of three digits. This fired an error!";
        }
    }
}
