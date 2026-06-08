using System;
namespace ThreadLocking
{
    class Program
    {
        public void Display()
        {
            lock(this)
            {
            Console.Write("[C sharp is an");
            Thread.Sleep(5000);
            Console.WriteLine(" OOPs Language]");
            }
        }
        public static void Main()
        {
            Program p =new Program();
            //Here the Same Resource calling by different Threads.
            Thread t = new Thread(p.Display);
            Thread t1 = new Thread(p.Display);
            Thread t2 = new Thread(p.Display);
            t.Start();
            t1.Start();
            t2.Start();

        }
    }
}