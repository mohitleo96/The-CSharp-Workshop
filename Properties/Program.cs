using System;
namespace Properties
{
    class Area
    {
        double _Radius = 12.98;
        public double Radius
        {
            get {return _Radius;}
            set {
                if(value > _Radius)
                {
                _Radius = value;
                }
                else
                {
                _Radius = 0;
                }
                }
        }
    }
    class Program
    {
        public static void Main()
        {
            //To get the value of Area->Radius need to create instance of class
            Area a = new Area();
            double rad = a.Radius; //Calling get method
            a.Radius = 11.88;      //Calling Set Method
            Console.WriteLine(rad);
            Console.WriteLine(a.Radius);



        }
    }
}
//Without using Properties we can't put conditions/Validation on Fields.
//output
// 12.98
// 0