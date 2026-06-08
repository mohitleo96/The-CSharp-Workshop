using System;
namespace MethodHiding
{
    class Parent
    {
        public void Test()
        {
            Console.WriteLine("Parent Test Method Called");
        }
    }
    class Child : Parent
    {
        public new void Test()
        {
            Console.WriteLine("Child Test Method Called");
        }
        public static void Main()
        {

            Child c= new Child();
            Parent p=c;
            c.Test();
            p.Test();

        }
    }

}
// Output
// Child Test Method Called
// Parent Test Method Called