using System;
namespace OperatorOverloading
{
    class Matrix : Object
    {
       // Sum and Subtraction of two matrix
       int a,b,c,d;
       public Matrix(int a, int b, int c, int d)
        {
            this.a=a;
            this.b=b;
            this.c=c;
            this.d=d;
        }
        public override string ToString()
        {
            return a+" "+b+" \n"+c+" "+d+" \n";
        }
        public static Matrix operator +(Matrix obj1 , Matrix obj2)
        {
            Matrix obj = new Matrix(obj1.a+obj2.a,obj1.b+obj2.b,obj1.c+obj2.c,obj1.d+obj2.d);
            return obj;
        }
        public static Matrix operator -(Matrix obj1,Matrix obj2)
        {
            Matrix obj= new Matrix(obj1.a-obj2.a,obj1.b-obj2.b,obj1.c-obj2.c,obj1.d-obj2.d);
            return obj;
        }
        public static void Main()
        {
            Matrix m1= new Matrix(20,30,40,50);
            Matrix m2= new Matrix(30,60,10,20);
            Matrix m3 = m1+m2;
            Matrix m4 = m1-m2;
             Console.WriteLine(m1); //bydefault .ToString() method called
             Console.WriteLine(m2);
             Console.WriteLine(m3);
             Console.WriteLine(m4);

        }

    }

}


//output

// 20 30
// 40 50

// 30 60
// 10 20

// 50 90
// 50 70

// -10 -30
// 30 30
