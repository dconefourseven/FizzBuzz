using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Begin FizzBuzz!");

            var fizzbuzzer = new FizzBuzz(100);
            fizzbuzzer.DoWork();

            Console.WriteLine("End FizzBuzz.");
        }
    }
}
