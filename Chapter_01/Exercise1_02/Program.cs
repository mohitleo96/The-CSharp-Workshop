using System;
namespace Exercise1_02
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Hi There , What is your Name?");
            var name = Console.ReadLine();
            Console.WriteLine("Hi {0} , Nice to meet You",name);
        }
    }
}