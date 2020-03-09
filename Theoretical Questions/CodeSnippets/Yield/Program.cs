using System;
using System.Collections.Generic;
using System.Linq;

namespace Yield
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() {"ac", "cdee", "e"};

            f(list).ToList().ForEach(e => Console.WriteLine(e));
        }

        public static IEnumerable<int> f(List<string> list)
        {
            //will return an IEnumerable that when iterated with a foreach loop "yields" the length of the string from the list in the argument
            foreach(var e in list)
                yield return e.Length;
        }
    }
}
