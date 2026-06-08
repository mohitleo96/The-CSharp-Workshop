
using System;
using System.Linq;

namespace Linq
{
    class Program
    {
        public static void Main()
        {
            int[] array = { 12, 30, 56, 39, 40, 29 };

            // LINQ query
            var filter = from i in array
                         where i > 20
                         orderby i descending
                         select i;

            // Print values
            foreach (var item in filter)
            {
                Console.WriteLine(item);
            }
        }
    }
}

//output
// 56
// 40
// 39
// 30
// 29
