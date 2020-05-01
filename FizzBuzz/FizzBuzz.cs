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

        public bool Complete { get; private set; } = false;

        private string m_buffer = "";

        // ---- Constructor ----

        public FizzBuzz(int _target)
        {
            m_countTarget = _target;
        }

        // ---- Methods ----

        public void DoWork()
        {
            StringBuilder sb = new System.Text.StringBuilder();            
            sb.Append("Begin FizzBuzz!\n");
            Complete = false;

            int index = 1;
            while (index <= m_countTarget)
            {
                if (((index % 3) == 0) && ((index % 5) == 0))
                {
                    sb.Append("FizzBuzz\n");
                }
                else if ((index % 3) == 0)
                {
                    sb.Append("Fizz\n");
                }
                else if ((index % 5) == 0)
                {
                    sb.Append("Buzz\n");
                }
                else
                {
                    sb.Append(String.Format("{0}\n", index));
                }

                ++index;
            }

            sb.Append("End FizzBuzz!\n");
            m_buffer = sb.ToString();
            Complete = true;
        }

        public async void DoAsyncWork()
        {
            StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("Begin FizzBuzz!\n");
            Complete = false;

            await Task.Run(() =>
            {
                int index = 1;
                while (index <= m_countTarget)
                {
                    if (((index % 3) == 0) && ((index % 5) == 0))
                    {
                        sb.Append("FizzBuzz\n");
                    }
                    else if ((index % 3) == 0)
                    {
                        sb.Append("Fizz\n");
                    }
                    else if ((index % 5) == 0)
                    {
                        sb.Append("Buzz\n");
                    }
                    else
                    {
                        sb.Append(String.Format("{0}\n", index));
                    }

                    ++index;
                }
            });

            sb.Append("End FizzBuzz!\n");
            Complete = true;
        }
    }
}
