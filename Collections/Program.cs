using System;
using System.Collections;
namespace Collections
{
    class Program
    {
        public static void Main()
        {
            ArrayList al = new ArrayList();
            //No fixed length
            al.Add(100);
            Console.WriteLine(al.Capacity);
            al.Add(200);
            al.Add(300);
            al.Add(400);
            al.Add(500);
            Console.WriteLine(al.Capacity);

            //middle insertion/deletion possible
            al.Insert(2,250);
            al.RemoveAt(3); //using Indexof
            al.Remove(400); //using Value


            //To Print all the values of Array/Array list
            foreach(int obj in al)
            {
                Console.Write(obj + " ");
            }
        }
    }
}

//output
// 4
// 8
// 100 200 250 500