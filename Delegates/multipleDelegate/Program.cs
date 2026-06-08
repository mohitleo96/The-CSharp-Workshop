using System;
namespace multipleDelegate
{
    public delegate void RectangleDelegate(double width,double length);//SAME SIGNATURE
    class Program
    {
        public static void Main()
        {
            Rectangle rec = new Rectangle();
            RectangleDelegate obj = new RectangleDelegate(rec.GetArea);
            obj += rec.GetParameter;

            obj.Invoke(10,4);
        }
    }
    class Rectangle
    {
         public void GetArea(double width,double length) //multiple delegate should do with VOID return type.
        {
            Console.WriteLine("Area of Rectangle is "+ width * length);
        }
         public void GetParameter(double width,double length)//SAME SIGNATURE
        {
            Console.WriteLine("Parameter of Rectangle is "+ 2*(width + length));
        }
    }
}

//output
// Area of Rectangle is 40
// Parameter of Rectangle is 28