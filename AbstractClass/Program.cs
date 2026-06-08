using System;
using System.Formats.Asn1;
namespace AbstractClass
{
    abstract class Figure
    {
        public double Length , Width , Height, Radius;
        public float pi= 3.14F;
        public abstract double GetArea(); //Can contains parameter as well for abstract method
    }
    //Get Rectangle Area
    class Rectangle : Figure
    {
        public Rectangle(double length, double width)
        {
            this.Length = length;
            this.Width = width;
        }
        public override double GetArea()
        {
            return Length * Width;
        }
    }
    //Get Circle Area
    class Circle : Figure
    {
        public Circle(double radius)
        {
            this.Radius = radius;
        }
          public override double GetArea()
        {
            return pi * Radius * Radius;
        }
    }
    //Get Triangle Area
    class Triangle : Figure
    {
        public Triangle(double length, double width , double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }
        public override double GetArea()
        {
           return  (Length * Width * Height)*1/2 ;
        }
    }
    //Get Square Area
    class Square : Figure
    {
        public Square(double length)
        {
            this.Length = length;
        }
        public override double GetArea()
        {
           return Length * Length;
        }
    }
    public class Program
    {
        public static void Main()
        {
            Rectangle rectangle = new Rectangle(12,34);
            Circle circle = new Circle(12);
            Triangle triangle= new Triangle(12,25,11);
            Square square= new Square(12);
           Console.WriteLine($"Area of Rectangle {rectangle.GetArea()}");
           Console.WriteLine($"Area of Circle {circle.GetArea()}");
           Console.WriteLine($"Area of Triangle {triangle.GetArea()}");
           Console.WriteLine($"Area of Square {square.GetArea()}");

        }
    }
}

//output
//Area of Rectangle 408
//Area of Circle 452.1600151062012
//Area of Triangle 1650
//Area of Square 144