using System;
using System.Threading;

namespace Prioities
{
    class Program
    {
        static long count1, count2;
        static bool stop = false;   // Flag to stop threads

        public static void Test1()
        {
            while (!stop)
            {
                count1++;
            }
        }

        public static void Test2()
        {
            while (!stop)
            {
                count2++;
            }
        }

        public static void Main()
        {
            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);

            t1.Start();
            t2.Start();
            t2.Priority = ThreadPriority.Highest;
            t1.Priority = ThreadPriority.Lowest;
            Console.WriteLine("Main Thread Sleep for 5 sec");
            Thread.Sleep(10000);

            Console.WriteLine("Main Thread wakeup after 5 sec");

            stop = true;  // Signal threads to stop

            t1.Join();
            t2.Join();

            Console.WriteLine("Count1 is " + count1);
            Console.WriteLine("Count2 is " + count2);
        }
    }
}

//output
// Main Thread Sleep for 5 sec
// Main Thread wakeup after 5 sec
// Count1 is 2007277736
// Count2 is 2789371449 // here because i given more priority to Count2 it shows more value.