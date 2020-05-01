using System;
using System.Diagnostics;
using System.Threading;

namespace FizzBuzz
{
    class Program
    {
        const int m_target = 100000;
        const int m_numCounters = 200;

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

            FizzBuzz[] fizzbuzzers = new FizzBuzz[m_numCounters];
            for (int index = 0; index < m_numCounters; ++index)
            {
                fizzbuzzers[index] = new FizzBuzz(m_target);
            }

            foreach (var fb in fizzbuzzers)
            {
                fb.DoWork();
            }

            // There's no need to check that they've all finished. They're synchronous.  
            //bool allComplete = false;
            //while (!allComplete)
            //{
            //    allComplete = true;
            //    foreach (var fb in fizzbuzzers)
            //    {
            //        if (!fb.Complete)
            //        {
            //            allComplete = false;
            //            break;
            //        }
            //    }
            //}

            stopWatch.Stop();

            TimeSpan timeSpan = stopWatch.Elapsed;
            return timeSpan;
        }

        static TimeSpan DoAsyncWork()
        {
            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();

            FizzBuzz[] fizzbuzzers = new FizzBuzz[m_numCounters];
            for (int index = 0; index < m_numCounters; ++index)
            {
                fizzbuzzers[index] = new FizzBuzz(m_target);
            }

            foreach (var fb in fizzbuzzers)
            {
                fb.DoAsyncWork();
            }

            // This work is overhead that must be done to ensure that all of the work has been completed.
            bool allComplete = false;
            while (!allComplete)
            {
                allComplete = true;
                foreach (var fb in fizzbuzzers)
                {
                    if (!fb.Complete)
                    {
                        allComplete = false;
                        break;
                    }
                }
                Console.Write('.');
            }

            Console.WriteLine();
            stopWatch.Stop();

            TimeSpan timeSpan = stopWatch.Elapsed;
            return timeSpan;
        }
    }
}
