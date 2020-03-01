using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Division(10, 2);
            //Output:
            //5
            //The method always gets here
            Division(10, 0);
            //Output:
            //Attempted to divide by zero
            //The method always gets here
        }

        private static void Division(int numerator, int denominator)
        {
            try
            {
                Console.WriteLine(numerator / denominator);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("The method always gets here");
            }
        }   
    } 
}
