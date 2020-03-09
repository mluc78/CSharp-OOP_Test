using System;
using System.Collections.Generic;
using System.Linq;

namespace First_3_odd_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list =  new List<int>() {1, 2, 2, 4, 5, 6, 7, 9, 13};

            int numberOfOddsFilteredOut = 3;
            var result = list.Where(e => 
            {
                if(numberOfOddsFilteredOut == 0)
                    return true;
                if(e % 2 != 0)
                {
                    numberOfOddsFilteredOut--;
                    return false;
                }
                return true;
            });

            result.ToList().ForEach(e => Console.WriteLine(e));

        }
    }
}

// A bit too complicated. Find an easier solution. But good!
