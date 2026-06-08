using System;
using System.Collections.Generic;
namespace Generic
{
    class Program
    {
        static void Main()
        {
            List <int> li = new List<int>();
            li.Add(12);
            //li.Add("Mohit"); //Argument 1: cannot convert from 'string' to 'int'
            li.Add(29);

            //All operations are Same as ArrayList.
            li.Insert(1,45);
            li.Remove(12);
            foreach(object items in li)
            {
                Console.WriteLine(items);
            }
        }
    }
}

//output
// 45
// 29