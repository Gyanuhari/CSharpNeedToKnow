using System;

namespace WorkingWithStopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 1000; i++)
                Console.WriteLine(i);
            watch.Stop();

            Console.WriteLine($"First Execution Time: {watch.ElapsedMilliseconds} ms");

            if (!watch.IsRunning)//checks if it is running
                watch.Restart(); //Restarts time to 0 and starts measuring
                                 //watch.Start(); Starts from where it was stopped

            for (int i = 0; i < 1000; i++)
                Console.WriteLine(i);
            watch.Stop();

            Console.WriteLine($"Second Execution Time: {watch.ElapsedMilliseconds} ms");
        }
    }
}
