using System;
namespace Exercise1_06
{
    class Program
    {
        public static void Main(String[] args)
        {
            //If-Else statement
            Console.WriteLine("Enter the Username.");
            var username = Console.ReadLine();
            if(username.Length<6)
            {
                Console.WriteLine("Username should be more than 6 digits");
            }
            else
            {
                Console.WriteLine("Enter Password");
                var password = Console.ReadLine();
                if (password.Length < 6)
                {
                    Console.WriteLine("Password should be more than 6 digits");
                }
                else if (!password.Any(c => Char.IsDigit(c)))
                {
                    Console.WriteLine("Password should contains alteast one number");
                }
                else
                {
                     Console.WriteLine("User Successfully Registered");
                }
            }
        }
    }
}