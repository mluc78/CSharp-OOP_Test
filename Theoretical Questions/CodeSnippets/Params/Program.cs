using System;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            VariableParamsFunction(1, 2, 3, 4, 5, 6);
        }

        static void VariableParamsFunction(params int[] variableParams)
        {
            foreach(var p in variableParams)
                Console.WriteLine(p);
        }
    }
}
