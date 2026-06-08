using System;
namespace needofconstructor
{

    class Program
    {
        static int x;
        public static void Main()
        {
            Console.WriteLine(x); // here x is implicity called using static constructor.
                                   // A static variable "x" is directly called inside static method.
        }
    }

}

//Example of Static Constructor
//output
// 0