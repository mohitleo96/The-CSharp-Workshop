using System;
using System.Text;
using System.Diagnostics;
namespace StringVsStringBuilder
{
    class Program
    {
        public static void Main()
        {
        string s="";
        Stopwatch sw1=new Stopwatch();
        Stopwatch sw2=new Stopwatch();
        sw1.Start();
        for(int i=0;i<=10000;i++)
        {
            s= s+i;
        }
        sw1.Stop();

        StringBuilder stringBuilder= new StringBuilder(10000);//Here we can provide the size also(optional)
        for(int i=0;i<=10000;i++)
        {
            stringBuilder.Append(i);
        }
        sw2.Stop();
        Console.WriteLine("TimeTaken for String is {0}",sw1.ElapsedMilliseconds);
        Console.WriteLine("TimeTaken for StringBuilder is {0}",sw2.ElapsedMilliseconds);

        }


    }
}

//output
// TimeTaken for String is 281
// TimeTaken for StringBuilder is 0