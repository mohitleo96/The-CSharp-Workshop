using System;
namespace LamdaExpressions
{
    public delegate string DetailsDelegate(string Name);
    class Program
    {
        public static void Main()
        {
            DetailsDelegate obj = (Name) =>
            {
                return "Hi " + Name +" How are you?";
            };
            string str= obj.Invoke("Mohit");
            Console.WriteLine(str);
        }
    }
}

//output
//Hi Mohit How are you?