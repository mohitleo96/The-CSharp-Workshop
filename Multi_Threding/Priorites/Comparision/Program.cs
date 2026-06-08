using System;
using System.Threading;
using System.Diagnostics;
namespace Comparision
{
    class Program
    {

        static void Test1()
        {
            long count = 0;
            for(long i=1;i<=1000000;i++)
            {
                count = count + 1;
            }
            Console.WriteLine("Count1 is :"+count);

        }
        static void Test2()
        {
            long count = 0;
             for(long i=1;i<=1000000;i++)
            {
                count = count +1;
            }
             Console.WriteLine("Count2 is :"+count);

        }
        public static void Main()
        {
            Stopwatch s = new Stopwatch();
            Stopwatch s1 = new Stopwatch();
            s.Start();
            Test1();
            Test2();
            s.Stop();
            Console.WriteLine("Time taken to consume Single Theading is "+s.ElapsedMilliseconds);
            s1.Start();
            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            t1.Start();
            t2.Start();
            s1.Stop();
            t1.Join();
            t2.Join();
            Console.WriteLine("Time taken to consume Multiple Theading is "+s1.ElapsedMilliseconds);
        }
    }
}

//output
// Count1 is :1000000
// Count2 is :1000000
// Time taken to consume Single Theading is 23
// Count2 is :1000000
// Count1 is :1000000
// Time taken to consume Multiple Theading is 2 //Less time taken to complete the task.