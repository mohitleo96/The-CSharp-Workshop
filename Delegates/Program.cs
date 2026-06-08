using System;
namespace Delegates
{
    // 1.Defining Delegate
    public delegate void AddDelegate(int x,int y);
    public delegate void MulDelegate(int x, int y);

    public class Program
    {
        public static void AddNumber(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        public void MulNumber(int a, int b)
        {
             Console.WriteLine(a*b);
        }
        public static void Main()
        {
            //Instance of Delegates of a Static method
            AddDelegate add = new AddDelegate(Program.AddNumber);

            //Instance of Delegates of a non-static method which class doesn't having a constructor.
            Program p=new Program();
            MulDelegate mul = new MulDelegate(p.MulNumber);

            //Invoke the Delegate
            //add(12,34); or
            add.Invoke(12,34);
            mul.Invoke(12,11);
        }
    }

}

//output
// 46
// 132