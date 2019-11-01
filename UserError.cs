using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Example
{
    public  abstract class UserError
    {
        public abstract string UEMessage();
    }

    public class NumericInputError : UserError
    {
        public override string UEMessage()
        {
           return "You tried to use a numeric input in a text only field. This fired an error !";
        }
    }

    public class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a text input in a numeric only field. This fired an error !";
        }
    }

    public class IndexOutofBound : UserError
    {
        public override string UEMessage()
        {
            return "Index out of range.Check the Index value !!!";
        }
    }

    public class  FieldLengthValidation: UserError
    {
        public override string UEMessage()
        {
            return "The Input exceeds the Actual length of the Field.!!!";

        }
    }

    public class  ClassNotFound : UserError
    {
        public override string UEMessage()
        {
            return "Class definiton not found. Check the definition of the class";

        }
    }
}
