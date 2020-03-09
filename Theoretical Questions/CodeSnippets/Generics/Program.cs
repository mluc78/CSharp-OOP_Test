using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var GenericClassForInt = new GenericClass<int>() { Variable = 10 };

            //compile-time error due to the condition the generic to be a value type (non-nullable)
            var GenericClassForString = new GenericClass<string>();
        }
    }

    public class GenericClass<T> where T : struct
    {
        public T Variable;
    }
}
