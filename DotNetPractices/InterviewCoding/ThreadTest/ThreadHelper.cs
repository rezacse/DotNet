using System;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InterviewCoding.ThreadTest
{
    public class ThreadHelper
    {

        private int _counter = 0; // A shared variable

        public void DoTask()
        {
            Thread[] threads = new Thread[5];

            // Create and start multiple threads that increment the counter
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(IncrementCounter);
                threads[i].Start();
            }

            // Wait for all threads to complete
            foreach (Thread thread in threads)
            {
                thread.Join();
            }

            Console.WriteLine($"Final counter value: {_counter}");
        }

        private void IncrementCounter()
        {
            for (int i = 0; i < 100000; i++)
            {
                // Atomically increment the counter
                //_counter++;
                Interlocked.Increment(ref _counter);
            }
        }
    }

}
