using System;

//Check where the given number is prime or not?
//class - number
//method - checkPrime
namespace Exercise1_09
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter any number to check it is prime or not?");
            var num = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} number is Prime ? {1}", num, IsPrime(num));

        }
        public static bool IsPrime(int number)
        {
            if (number == 0 || number == 1)
            {
                return false;
            }
            bool prime = true;
            int counter = 2;
            while (counter <= Math.Sqrt(number))
            {
                if (number % counter == 0)
                {
                    prime = false;
                    goto isNotPrime;
                }
                counter++;
            }
            isNotPrime:
            return prime;
        }

    }


}
