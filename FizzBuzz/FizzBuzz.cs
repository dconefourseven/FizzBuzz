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

        private string m_buffer = "";

        // ---- Constructor ----

        public FizzBuzz(int _target)
        {
            m_countTarget = _target;
        }

        // ---- Methods ----

        public void DoWork()
        {
            m_buffer = "";
            m_buffer += "Begin FizzBuzz!\n";
            m_complete = false;

            int index = 1;
            while (index <= m_countTarget)
            {
                if (((index % 3) == 0) && ((index % 5) == 0))
                {
                    m_buffer += "FizzBuzz\n";
                }
                else if ((index % 3) == 0)
                {
                    m_buffer += "Fizz\n";
                }
                else if ((index % 5) == 0)
                {
                    m_buffer += "Buzz\n";
                }
                else
                {
                    m_buffer += String.Format("{0}\n", index);
                }

                ++index;
            }

            m_buffer += "End FizzBuzz!\n";
            m_complete = true;
        }

        public async void DoAsyncWork()
        {
            m_buffer = "";
            m_buffer += "Begin FizzBuzz!\n";
            m_complete = false;

            await Task.Run(() =>
            {
                int index = 1;
                while (index <= m_countTarget)
                {
                    if (((index % 3) == 0) && ((index % 5) == 0))
                    {
                        m_buffer += "FizzBuzz\n";
                    }
                    else if ((index % 3) == 0)
                    {
                        m_buffer += "Fizz\n";
                    }
                    else if ((index % 5) == 0)
                    {
                        m_buffer += "Buzz\n";
                    }
                    else
                    {
                        m_buffer += String.Format("{0}\n", index);
                    }

                    ++index;
                }
            });

            m_buffer += "End FizzBuzz!\n";
            m_complete = true;
        }
    }
}
