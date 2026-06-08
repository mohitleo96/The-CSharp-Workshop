using System;
namespace AnonymusDelegate
{
    public delegate string DetailsDelegate(string name);
    class Program
    {
        public static void Main()
        {
            DetailsDelegate obj = delegate(string name)
            {
                return "Hello " + name + " I hope you Fine";
            };
            string getDetails = obj.Invoke("Mohit");
            Console.WriteLine(getDetails);
        }
    }

}

//output
//Hello Mohit I hope you Fine