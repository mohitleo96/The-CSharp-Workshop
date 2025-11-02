using System;
namespace Exercise1_04
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter First Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("So the Sum is {0}", Sum(num1, num2));
            multi(num1, num2);
            Console.WriteLine("So the Subtract is {0}", Sub(num1, num2));
            Console.WriteLine("So the division is {0}", divide(num1, num2));
        }
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static void multi(int a, int b)
        {
            Console.WriteLine("So the multiply is {0}",a * b);
        }
          public static int Sub(int a, int b)
        {
            return a - b;
        }
        public static float divide(int a, int b)
        {
            return (float)a / b;
        }
    }
}