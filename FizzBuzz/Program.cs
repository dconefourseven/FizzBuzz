using System;
using System.Diagnostics;
using System.Threading;

namespace FizzBuzz
{
    class Program
    {
        const int m_target = 50000;
        //const int m_numCounters = 3;

        static void Main(/*string[] args*/)
        {
            Console.WriteLine("Do work.");
            var timeSpan = DoWork();
            Console.WriteLine("Do work complete.");

            Console.WriteLine("Do async work.");
            var timeSpanAsync = DoAsyncWork();
            Console.WriteLine("Do async work complete.");

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds / 10);
            Console.WriteLine("Sync " + elapsedTime);

            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", timeSpanAsync.Hours, timeSpanAsync.Minutes, timeSpanAsync.Seconds, timeSpanAsync.Milliseconds / 10);
            Console.WriteLine("Async " + elapsedTime);

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        static TimeSpan DoWork()
        {
            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();

            var fb1 = new FizzBuzz(m_target);
            fb1.DoWork();

            var fb2 = new FizzBuzz(m_target);
            fb2.DoWork();

            var fb3 = new FizzBuzz(m_target);
            fb3.DoWork();

            //while (
            //    !fb1.Complete
            //    || !fb2.Complete
            //    || !fb3.Complete
            //    )
            //{
            //    Thread.Sleep(1);
            //}

            stopWatch.Stop();

            TimeSpan timeSpan = stopWatch.Elapsed;
            return timeSpan;
        }

        static TimeSpan DoAsyncWork()
        {
            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();

            var fb1 = new FizzBuzz(m_target);
            fb1.DoAsyncWork();

            var fb2 = new FizzBuzz(m_target);
            fb2.DoAsyncWork();

            var fb3 = new FizzBuzz(m_target);
            fb3.DoAsyncWork();

            while (
                !fb1.Complete
                || !fb2.Complete
                || !fb3.Complete
                )
            {
                Console.Write('.');
                Thread.Sleep(1);
            }
            Console.WriteLine();
            stopWatch.Stop();

            TimeSpan timeSpan = stopWatch.Elapsed;
            return timeSpan;
        }
    }
}
