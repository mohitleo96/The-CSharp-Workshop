using System;
using System.Collections;
namespace Hashtables
{
    class Program
    {
       public static void Main()
        {
            Hashtable ht = new Hashtable();
            ht.Add("EName","Mohit");
            ht.Add("EAdd","Mumabi");
            ht.Add("EPhone",7898798);
            ht.Add("EAge",21);
            ht.Add("EGender","Male");
            ht.Add("EHealth",true);
            ht.Add("EJoiningDate","12/08/2026");
            ht.Add("Date","12/08/2026");
            ht.Add("EDept","HR");
            ht.Add("ESalary",290000);

            Console.WriteLine(ht["EDept"]); //Getting Values using Key
            Console.WriteLine();
            //GetHashCode of any String
            Console.WriteLine("Hello".GetHashCode());

            Console.WriteLine();

            //To get all Keys
            foreach(object Keys in ht.Keys)
            {
                Console.WriteLine(Keys);
            }
            Console.WriteLine();
            //To get keys and Value in Array format
            foreach(object obj in ht)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
            //To get keys and Value in custom format
            foreach(object Key in ht.Keys)
            {
                Console.WriteLine(Key +" - "+ht[Key]);
            }
        }
    }
}

//Output
// HR

// 2130539644

// EPhone
// Date
// EName
// EGender
// EAdd
// EHealth
// EAge
// ESalary
// EDept
// EJoiningDate

// [EPhone, 7898798]
// [Date, 12/08/2026]
// [EName, Mohit]
// [EGender, Male]
// [EAdd, Mumabi]
// [EHealth, True]
// [EAge, 21]
// [ESalary, 290000]
// [EDept, HR]
// [EJoiningDate, 12/08/2026]

// EPhone - 7898798
// Date - 12/08/2026
// EName - Mohit
// EGender - Male
// EAdd - Mumabi
// EHealth - True
// EAge - 21
// ESalary - 290000
// EDept - HR
// EJoiningDate - 12/08/2026