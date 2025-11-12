using System;
namespace Exercise1_08
{
    class Program
    {
        public static void Main(String[] args)
        {
            var menuBuilder = new System.Text.StringBuilder();
            menuBuilder.Append("Welcome to my shop. What you like to order");
            menuBuilder.AppendLine(String.Empty);
            menuBuilder.AppendLine("Select any one option");
            menuBuilder.AppendLine("1) Pizza");
            menuBuilder.AppendLine("2) Burger");
            menuBuilder.AppendLine("3) Coke");
            menuBuilder.AppendLine("4) Fries");
            Console.WriteLine(menuBuilder.ToString());
            var option = int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1 :
                    {
                        Console.WriteLine("Pizza will be ready");
                        break;
                    }
                    case 2 :
                    {
                        Console.WriteLine("burger will be ready");
                        break;
                    }
                    case 3 :
                    {
                        Console.WriteLine("coke will be ready");
                        break;
                    }
                    case 4 :
                    {
                        Console.WriteLine("fries will be ready");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Wrong selection");
                        break;
                    }
            }

        }

    }
}