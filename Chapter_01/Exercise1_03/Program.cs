using System;
namespace Exercise1_03
{
    class Program
    {
        public static void Main(String[] args)
        {
            var message = "Hello World";
            FormatString(message);
            Console.WriteLine(message);
            var anotherMessage = "Welcome to World";
            Console.WriteLine(FormatReturnString(anotherMessage));
        }
        public static void FormatString(String StringToFormat)
        {
            StringToFormat.Replace("World", "Mars");
        }
        public static String FormatReturnString(String StringToFormat)
        {
            return StringToFormat.Replace("World", "Mars");
        }
    }
}
//In C# String is immutable i.e we cannot change the value of string after its creation.
//Because in C# string is treated like a arrays of characters. And Array having a Fixed Length to it.
// thats why for "FormatString" it is not replacing "world" to "mars" but because of returning Void it is not able to replace.
//Meanwhile "FormatReturnString" return a new value to a string.


//output
//Hello World
//Welcome to Mars