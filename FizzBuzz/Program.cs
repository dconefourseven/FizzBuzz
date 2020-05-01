using System;
using System.Diagnostics;
using System.Threading;

namespace FizzBuzz
{
    class Program
    {
        static void Main(/*string[] args*/)
        {
            Console.WriteLine("Begin FizzBuzz!");
            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();

            var fb1 = new FizzBuzz(5000);
            fb1.DoAsyncWork();

            var fb2 = new FizzBuzz(5000);
            fb2.DoAsyncWork();

            var fb3 = new FizzBuzz(5000);
            fb3.DoAsyncWork();

            while (
                !fb1.Complete
                || !fb2.Complete
                || !fb3.Complete
                )
            {
                Thread.Sleep(1);
            }

            stopWatch.Stop();

            TimeSpan timeSpan = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
            Console.WriteLine("End FizzBuzz.");

            Console.ReadKey();
        }
    }
}
