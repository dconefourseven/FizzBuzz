using System;
using System.Diagnostics;

namespace FizzBuzz
{
    class Program
    {
        static void Main(/*string[] args*/)
        {
            Console.WriteLine("Begin FizzBuzz!");
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            var fizzbuzzer = new FizzBuzz(100);
            fizzbuzzer.DoWork();
            stopwatch.Stop();

            TimeSpan ts = stopwatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
            Console.WriteLine("End FizzBuzz.");
            
            bool endProgram = false;
            while (!endProgram)
            {
                Console.WriteLine("Enter Y to continue...");
                string line = Console.ReadLine();
                endProgram = String.Compare(line, "Y", true) == 0;
            }
        }
    }
}
