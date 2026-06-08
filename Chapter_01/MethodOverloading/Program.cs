    using System;
    using System.Security.Cryptography.X509Certificates;
    namespace MethodOverloading
    {
        public class Program
        {
        public void Test()
        {
            Console.WriteLine("1st Method");
        }
         public void Test(int i)
        {
            Console.WriteLine("2nd Method");
        }
         public void Test(string name)
        {
            Console.WriteLine("3rd Method");
        }
         public void Test(int i,string name)
        {
            Console.WriteLine("4th Method");
        }
         public void Test(string name,int i)
        {
            Console.WriteLine("5th Method");
        }


         public static void Main()
        {
            Program p = new Program();
            p.Test();
            p.Test(10);
            p.Test("Mohit");
            p.Test(10, "Mohit");
            p.Test("Mohit", 10);
        }
    }
}
// output
// 1st Method
// 2nd Method
// 3rd Method
// 4th Method
// 5th Method