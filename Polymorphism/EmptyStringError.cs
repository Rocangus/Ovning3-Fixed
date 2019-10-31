using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3.Polymorphism
{
    public class EmptyStringError : UserError
    {
        public override string UEMessage()
        {
            return "That input resulted in an empty string and will be ignored.";
        }
    }
}
