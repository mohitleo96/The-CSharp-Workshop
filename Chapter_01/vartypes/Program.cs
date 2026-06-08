using System;
namespace vartypes
{
    class Program
    {
        int x = 100; //non-static or instance variable
        int y; //non-static or instance variable

        static int staticnum1 = 200; //static variable
        static int staticnum2; //static variable

        const float pi = 3.14f; //constant variable

        readonly bool flag; //Readonly variable

        Program(bool flag)
        {
            this.flag = flag;
        }


        public static void Main()
        {
          Program p = new Program(true);
          Program p1 = new Program(false);
          Console.WriteLine(p.flag +" "+ p1.flag);
        //   p.flag=false; //Can't change the value of p instance after declaring once.
        //   Console.WriteLine(p.flag +" "+ p1.flag);
    }
}
}
//output
// True False