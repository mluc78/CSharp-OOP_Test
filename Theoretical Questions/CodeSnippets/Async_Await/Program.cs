using System;
using System.Threading;
using System.Threading.Tasks;

namespace Async_Await
{
    class Program
    {
        static void Main(string[] args)
        {
            var function = LongRunningFunction();
            
            Console.WriteLine("Waiting for the function result...");

            //Here the main thread gets blocked while waiting for the task inside the function to finish
            int result = function.Result;

            Console.WriteLine($"The result of the long task is: {result}");
            //Output:
            /*
            Long task started
            Waiting fot the function result...
            Long task finished
            The result of the long task is: 10
            */
        }

        static async Task<int> LongRunningFunction()
        {
            int result;

            var longProcess = new Task<int>(() =>
            {
                Console.WriteLine("Long task started");
                //Simulating some long running process 
                Thread.Sleep(5000);

                return 10;
            });
            longProcess.Start();

            //Due to the await operator, while the task is running on a separate thread, this function waits "asynchronously"
            //(without blocking the main thread) for the task to finish
            //Also when the task is finished, a callback to this function will let it finish
            result = await longProcess;
            Console.WriteLine("Long task finished");
            
            return result;
        }
    }
}
