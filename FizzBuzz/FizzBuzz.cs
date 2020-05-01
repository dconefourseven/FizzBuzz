using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class FizzBuzz
    {
        // ---- Variables ----

        private int m_countTarget = 0;

        private bool m_complete = false;
        public bool Complete { get { return m_complete; } private set { m_complete = value; } }

        // ---- Constructor ----

        public FizzBuzz(int _target)
        {
            m_countTarget = _target;
        }

        // ---- Methods ----

        public void DoWork()
        {
            Console.WriteLine("Begin FizzBuzz!");
            m_complete = false;

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
            
            Console.WriteLine("End FizzBuzz!");
            m_complete = true;
        }

        public async void DoAsyncWork()
        {
            Console.WriteLine("Begin FizzBuzz!");
            m_complete = false;

            await Task.Run(() =>
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
            });

            Console.WriteLine("End FizzBuzz!");
            m_complete = true;
        }
    }
}
