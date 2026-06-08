    using System;
    namespace ExtensionMethod
    {
        public class Program
        {
            public void Method1()
            {
                Console.WriteLine("Method 1");
            }
            public void Method2()
            {
                Console.WriteLine("Method 2");
            }
        }

        public static class ExtensionMethodClass
        {
            //"this" keyword is compulsory for make method3 as part of Program Class
            public static void Method3(this Program po)
        {
            Console.WriteLine("Method 3");
        }
            public static long Factorial(this Int32 n)
            {
                if(n==1)
                {
                    return 1;
                }
                if(n==2)
                {
                    return 2;
                }
                return n*Factorial(n-1);

            }
            public static string ProperCase(this String oldString)
            {
                if(oldString.Length>0)
                {
                    string NewString =null;
                    oldString=oldString.ToLower();
                    string[] Strr = oldString.Split(' ');
                    foreach(string str in Strr)
                    {
                        Char[] carr = str.ToCharArray();
                        carr[0]=Char.ToUpper(carr[0]);
                        if(NewString == null)
                        {
                            NewString = new string(carr);
                        }else
                        {
                            NewString += " " + new string(carr);
                        }
                    }
                    return NewString;
                }
                return oldString;
            }
        }
        class TestExtensionMethod
        {
            public static void Main()
            {
                Program p = new Program();
                p.Method1();
                p.Method2();
                p.Method3();
                int i=5;
                long result=i.Factorial();
                Console.WriteLine("The Factorial is "+ result );

                string s = "HEellO MoHIt Fine";
                Console.WriteLine(s.ProperCase());
            }
        }

    }


    //output
    //we can achieve this by using Inheritence also but inheritence not possible in Sealed class and structure.
// Method 1
// Method 2
// Method 3
// The Factorial is 120
// Heello Mohit Fine