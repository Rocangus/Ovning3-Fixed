using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3.Polymorphism
{
    public class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a textinput in a numericonly field. This fired an error!";
        }
    }
}
