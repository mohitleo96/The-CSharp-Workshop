    using System;
    using System.Security.Cryptography.X509Certificates;
    namespace Inheritance
    {
        public class parentClass
        {
            public int empID;
            public String empName;
            public parentClass(int id,String name)
            {
                empID=id;
                empName=name;
            }

        }

        public class childClass : parentClass
        {
            public int empAge;
            public String empAdd;
            public childClass(int age, String add) : base(101,"Mohit")
            {
                empAge=age;
                empAdd=add;
            }
            public static void Main()
            {
                childClass p = new childClass(23,"Mumbai");
                Console.WriteLine(p.empAge + " " + p.empAdd);
                Console.WriteLine(p.empID + " " + p.empName);
            }
        }
    }

    // output //Here ChildClass constructor explicity called the parentclass constructor parameters using base keyword.
    // 23 Mumbai
    // 101 Mohit