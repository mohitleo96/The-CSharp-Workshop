using System;

namespace Exercise1_13
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool divisionExecuted = false;

            while (!divisionExecuted)
            {
                try
                {
                    Console.WriteLine("Please input a number:");
                    int a = int.Parse(Console.ReadLine());

                    Console.WriteLine("Please input another number:");
                    int b = int.Parse(Console.ReadLine());

                    int result = Divide(a, b);
                    Console.WriteLine($"Result: {result}");
                    divisionExecuted = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("You did not input a valid number. Let's start again...\n");
                    continue;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Tried to divide by zero. Let's start again...\n");
                    continue;
                }
            }
        }

        static int Divide(int x, int y)
        {
            return x / y;
        }
    }
}