using System;
namespace Exceptionhandling
{
    public class DivideByOddNumber : ApplicationException
    {
        public override string Message
        {
            get
            {
                return "Divided by Odd number is not possible";
            }
        }
    }
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter the First Number?");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number?");
            int b = Convert.ToInt32(Console.ReadLine());
            int c= a/b;
            if(b%2 != 0)
                {
                    throw new DivideByOddNumber();
                }
            Console.WriteLine("Divide of Two Numbers are "+c);
        }
    }

}

//output
// Enter the First Number?
// 100
// Enter the Second Number?
// 5
// Unhandled exception. Exceptionhandling.DivideByOddNumber: Divided by Odd number is not possible
//    at Exceptionhandling.Program.Main() in C:\Users\tmorao\Desktop\C-Sharp-Workshop\ExceptionHandling\Program.cs:line 25