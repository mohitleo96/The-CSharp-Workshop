using System;
using System.Threading;
namespace Multi_Threding
{
    class Program
    {
      static void Test1(object num)
        {
            int a = Convert.ToInt32(num);
            for(int i=1; i<=a;i++)
            {
                Console.WriteLine("Test1: {0}",i);

            }
              Console.WriteLine("Test1 Thread Completed");
        }
        static void Test2()
        {
            for (int i=1;i<=10;i++)
            {
                Console.WriteLine("Test2: {0}",i);
                if(i==5)
                {
                    Thread.Sleep(5000);
                }

            }
             Console.WriteLine("Test2 Thread Completed");
        }
        static void Test3()
        {
            for (int i=1;i<=10;i++)
            {
                Console.WriteLine("Test3: {0}",i);

            }
             Console.WriteLine("Test3 Thread Completed");
        }
      static void Main()
        {

            Thread t1 = new Thread(Test1);
             Thread t2 = new Thread(Test2);
             Thread t3= new Thread(Test3);
             t1.Start(15); t2.Start();t3.Start();
             t1.Join();
             t2.Join();
             t3.Join(5000);//Here we can set millisecond time span as well.
            Console.WriteLine("Main Thread Completed");

        }
    }
}

//output //here because we use join Main method thread waits for all the methods to complete then it stops.
// Test1: 1
// Test1: 2
// Test1: 3
// Test1: 4
// Test1: 5
// Test1: 6
// Test3: 1
// Test3: 2
// Test3: 3
// Test3: 4
// Test2: 1
// Test2: 2
// Test2: 3
// Test2: 4
// Test2: 5
// Test1: 7
// Test1: 8
// Test1: 9
// Test1: 10
// Test1: 11
// Test1: 12
// Test1: 13
// Test1: 14
// Test1: 15
// Test3: 5
// Test3: 6
// Test3: 7
// Test3: 8
// Test3: 9
// Test3: 10
// Test3 Thread Completed
// Test1 Thread Completed
// Test2: 6
// Test2: 7
// Test2: 8
// Test2: 9
// Test2: 10
// Test2 Thread Completed
// Main Thread Completed