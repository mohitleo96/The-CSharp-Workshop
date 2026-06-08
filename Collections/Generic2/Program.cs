using System;
using System.Collections;
namespace Generic2
{
    class Calculations<T>
    {

        public void Add(T a, T b)
        {
            //Here we use Dyanmic DataType which introduced in c# 4.0, here we use this because
            //we didn't perform any Arthemtic oprations without declearing the data type.
            //Suppose if a and b are String values that leds to compile-time error.

            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 + d2);
        }

        public void Sub(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 - d2);
        }

        public void Mul(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 * d2);
        }
       public void Div(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 / d2);
        }
    }
        class Program
        {
            public static void Main()
            {
                Calculations<int> c = new Calculations<int>();
                c.Add(12, 13);
                c.Sub(12, 16);
                c.Mul(12, 10);
                c.Div(12, 5);
            }
        }
    }


//output :-
// 25
// -4
// 120
// 2