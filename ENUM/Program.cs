using System;
namespace ENUM
{
    public enum Days
    {
        Monday=12,
        Tuesday,
        Webnesday,
        Thursday,
        Friday
    }
    public class Program
    {
        public static void Main()
        {
            Days d= (Days)13;
            Console.WriteLine(d);
            foreach(string day in Enum.GetNames(typeof(Days)))
            {
                Console.WriteLine(day);
            }
              foreach(int day in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine(day);
            }
        }
    }
}

//output
// Tuesday
// Monday
// Tuesday
// Webnesday
// Thursday
// Friday
// 12
// 13
// 14
// 15
// 16