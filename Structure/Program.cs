using System;
namespace Structure
{
    struct Program
    {
        int i;
        public Program(int i)
        {
            this.i=i;
        }
        public void Display()
        {
            Console.WriteLine("Method of structure = "+i);
        }
        public static void Main()
        {
            //1st approch
            Program p;
            p.i=10;
            p.Display();

            //2nd approch :- By default implicit constructor is there
            Program p1=new Program();
            p1.Display();

            //3rd approch :- Define explicit constructor
            Program p2=new Program(30);
            p2.Display();


        }

    }

}

//output
//Method of structure = 10
//Method of structure = 0
//Method of structure = 30