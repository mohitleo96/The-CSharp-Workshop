using System;
using System.Collections.Generic;
namespace Dicionary_Collection
{
    class Program
    {
       public static void Main()
        {
            //Storing in Key and Value Pair and we can define the Type as well.
            Dictionary<string,object> dt = new Dictionary<string, object>();
            dt.Add("EName","Mohit");
            dt.Add("EAdd","Mumabi");
            dt.Add("EPhone",7898798);
            dt.Add("EAge",21);
            dt.Add("EGender","Male");
            dt.Add("EHealth",true);
            dt.Add("EJoiningDate","12/08/2026");
            dt.Add("Date","12/08/2026");
            dt.Add("EDept","HR");
            dt.Add("ESalary",290000);

            Console.WriteLine(dt["EDept"]);
            Console.WriteLine();
            //GetHashCode of any String
            Console.WriteLine("Hello".GetHashCode());

            Console.WriteLine();

            //To get all Keys
            foreach(string Keys in dt.Keys)
            {
                Console.WriteLine(Keys);
            }
            Console.WriteLine();
            
            //To get keys and Value in Array format
            foreach(object obj in dt)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
            //To get keys and Value in custom format
            foreach(string Key in dt.Keys)
            {
                Console.WriteLine(Key +" - "+dt[Key]);
            }
        }
    }
}

//Output :- The Difference between HashTables and Dictionary is the output of Hastable is not the correct order as Input but in Dictionary it is on Same order as Input.

// HR

// 79262448

// EName
// EAdd
// EPhone
// EAge
// EGender
// EHealth
// EJoiningDate
// Date
// EDept
// ESalary

// [EName, Mohit]
// [EAdd, Mumabi]
// [EPhone, 7898798]
// [EAge, 21]
// [EGender, Male]
// [EHealth, True]
// [EJoiningDate, 12/08/2026]
// [Date, 12/08/2026]
// [EDept, HR]
// [ESalary, 290000]

// EName - Mohit
// EAdd - Mumabi
// EPhone - 7898798
// EAge - 21
// EGender - Male
// EHealth - True
// EJoiningDate - 12/08/2026
// Date - 12/08/2026
// EDept - HR
// ESalary - 290000