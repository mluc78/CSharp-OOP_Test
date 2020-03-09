using System;
using System.Linq;

namespace EmailChecking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ValidateEmail("abc@yahoo.com"));
            Console.WriteLine(ValidateEmail("@gmail"));
            Console.WriteLine(ValidateEmail("@"));
            Console.WriteLine(ValidateEmail("a@b@c"));
        }

        //Assumption: valid email -> text1@text2
        //text1, text2, text3 -> have to be non-empty
        //only one '@' <- delimiters
        static bool ValidateEmail(string emailToCheck)
        {
            var emailParts = emailToCheck.Split('@');
            return !emailParts.Any(e => e.Length == 0) && emailParts.Length == 2;
        }
    }
}
