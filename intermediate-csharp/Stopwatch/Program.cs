using System;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            System.Threading.Thread.Sleep(2000);
            stopwatch.Stop();
            stopwatch.Start();
            System.Threading.Thread.Sleep(3000);
            stopwatch.Start();
            stopwatch.Stop();
        }
    }
}
