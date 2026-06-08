using System;
namespace multipleinheritence
{
    class Program : IInterface1,IInterface2
    {
        public static void Main()
        {
           Program p = new Program();
           p.Test(); //Here Test is coming from both Interfaces 1 and 2
           IInterface1 i1=p; //for seperate calling need to create refrence.
           i1.Show();
           IInterface2 i2=p;
           i2.Show();
        }
        void Test()
        {
            Console.WriteLine("IInterface1 and IInterface2 Test methods called multiple inheritance");
        }
        void IInterface1.Show()
        {
            Console.WriteLine("IInterface1 Show methods called multiple inheritance");
        }
        void IInterface2.Show()
        {
            Console.WriteLine("IInterface2 Show methods called multiple inheritance");
        }
    }
    interface IInterface1
    {
       void Test();
       void Show();
    }
    interface IInterface2
    {
       void Test();
       void Show();
    }
}

//output
//IInterface1 and IInterface2 Test methods called multiple inheritance
//IInterface1 Show methods called multiple inheritance
//IInterface2 Show methods called multiple inheritance