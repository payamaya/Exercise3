using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public abstract class UserError
    {
        public abstract string UEMessage();

        public class NumericInputError : UserError 
        {
            public override string UEMessage()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Polymorfism UserError");
                Console.ResetColor();
                return "You tried to use a numeric input in a text only filed.This fires an error!";
            }
        }
        public class TextInputError : UserError
        {
            public override string UEMessage()
            {
                return "You tried to use a text input in a numeric only field.This fired an error!";
            }
        }   
        public class NullInputError : UserError
        {
            public override string UEMessage()
            {
                return "You tried to input a null value into a field. This fired an error!";
            }
        }   
        public class EmptyInputError : UserError
        {
            public override string UEMessage()
            {
                return "You tried to input an empty value into a field. This fired an error!";
            }
        }        
        public class SpecialChracterInputError : UserError
        {
            public override string UEMessage()
            {
                return "You tried to input a special character into a field that accepts only numeric values. This fired an error!";
            }
        }
    }
}
