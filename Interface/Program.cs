using System;
namespace Interface
{
    interface IExpression
    {
        //int i;  X
        //Interfaces cannot contain instance fields
        int Add(int a,int b);
        int Sub(int a,int b);
    }
    public class Calculation : IExpression
    {
        public int Mul(int a,int b)
        {
            return a*b;
        }
        public int Div(int a,int b)
        {
            return a/b;
        }
        public int Add(int a,int b) //compulsory declear
        {
            return a+b;
        }
         public int Sub(int a,int b)//compulsory declear
        {
            return a-b;
        }
    }
    class Program
    {
        public static void Main()
        {
            Calculation c= new Calculation();
        //  IExpression expression1 = new IExpression(); //Cannot create an instance of the abstract type or interface 'IExpression'
            IExpression expression=c; //Can Create a refrence from a child class intsance
            Console.WriteLine(c.Div(4,2));
            Console.WriteLine(c.Mul(4,2));
            Console.WriteLine(c.Add(4,2));
            Console.WriteLine(expression.Sub(4,2));
        }
    }
}

// output
// 2
// 8
// 6
// 2