using System;

namespace PerformanceLibrary.Executable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running StringBuilder");
            var watch = System.Diagnostics.Stopwatch.StartNew();
            PerformanceLibrary.Class1.TightLoopStringBuilder();
            watch.Stop();
            Console.WriteLine($"Time Elapsed: {watch.ElapsedMilliseconds}ms");

            Console.WriteLine("Running Concatenate");
            watch.Reset();
            watch.Start();
            PerformanceLibrary.Class1.TightLoopConcatenate();
            watch.Stop();
            Console.WriteLine($"Tme Elapsed: {watch.ElapsedMilliseconds}ms");
            Console.WriteLine("Press enter to close the app.");
            Console.ReadKey(true);
        }
    }
}
