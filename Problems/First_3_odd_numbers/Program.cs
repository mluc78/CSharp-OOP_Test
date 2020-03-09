using System;
using System.Collections.Generic;
using System.Linq;

namespace First_3_odd_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list =  new List<int>() {1, 2, 2, 4, 5, 6, 7};
            IEnumerable<int> result1, result2;

            //Solution I -> Pros: it doesn't iterate through the whole sequence, only until it finds 3 odd numbers
            //           -> Cons: has to double check if a number is odd
            int numberOfOdds = 3;
            result1 = list.TakeWhile(x => 
            {
                if(numberOfOdds == 0)
                    return false;
                if(x % 2 != 0)
                    numberOfOdds--;
                return true;
            }).Where(x => x % 2 != 0);

            //Solution II -> Pros: no double checking if a number is odd and short/clear
            //            -> Cons: iterates through the entire list to select the odd numbers even if only the first 3 are required
            result2 = list.Where(x => x % 2 != 0).Take(3);

        }
    }
}
