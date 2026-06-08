using System;
namespace VarInsRef
{
    class Program
    {
        int x = 100;
        public static void Main()
        {
            Program p; //Here P is Variable
            p = new Program(); //Here P is Instance , here p has its own memory.
            Program p1= new Program(); //Here P1 is Instance and P1 has its own different memory.
            Program p2= new Program();
            Console.WriteLine(p.x + " " + p1.x + " " + p2.x);

            Program p3 = p; //Here P3 is refrence , here P3 doesn't have its own memory.
            p3.x=200; //by changing the value of P3.x, we can update the value of p.x and vice-versa.
            Console.WriteLine(p.x + " " + p1.x + " " + p2.x + " " + p3.x);

            p.x=500;
            Console.WriteLine(p.x + " " + p1.x + " " + p2.x + " " + p3.x);

        }
    }
}

//output
// 100 100 100
// 200 100 100 200
// 500 100 100 500