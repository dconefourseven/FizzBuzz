using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    class FizzBuzz
    {
        // ---- Variables ----

        private int m_countTarget = 0;

        // ---- Constructor ----

        public FizzBuzz(int _target)
        {
            m_countTarget = _target;
        }

        // ---- Methods ----

        public void DoWork()
        {
            int index = 1;
            while (index <= m_countTarget)
            {
                if (((index % 3) == 0) && ((index % 5) == 0))
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if ((index % 3) == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if ((index % 5) == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine("{0}", index);
                }

                ++index;
            }
        }
    }
}
