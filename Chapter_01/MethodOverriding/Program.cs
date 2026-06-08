using System;
namespace MethodOverriding
{
    class Parent
    {
        public virtual void Test()
        {
            Console.WriteLine("Parent Test Method Called");
        }
    }
    class Child : Parent
    {
        int a;
        public void Test(int a)
        {
            this.a = a;
            Console.WriteLine("Child Test Method Called : {0}",a);
        }
        public static void Main()
        {
            Child c= new Child();
            c.Test(20);
            c.Test();
        }
    }

}


//output

// Child Test Method Called : 20
//Parent Test Method Called