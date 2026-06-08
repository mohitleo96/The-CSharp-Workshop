using System;
using System.Security.Cryptography.X509Certificates;
namespace ConstructorExample
{
    class Program
    {
      public static void Main(String[] args)
      {
        //class employee = new callingConstructor().
        Employee employee = new Employee();
        Console.WriteLine(employee.EmpName);
        Console.WriteLine(employee.EmpID);
        Console.WriteLine(employee.EmpMarried);
      }
    }
    class Employee //Employee Class //Inside the Class Everything is Private.
    {
        //Fields (not properties) are declared here.
        public string EmpName;
        public int EmpID;
        public bool EmpMarried;

        //Defining Constructor
        public Employee()
        {
        EmpName = "Mohit";
        EmpID = 41;
        EmpMarried = true;
        }
        //Here we create Constructor Explicity and Set default Value as well for now.
        //Explicity Constructor are either parameterless or parameterized Constructor.
    }
}

//Output
//Mohit
//41
//True