using System;
using System.Security.Cryptography.X509Certificates;
namespace ConstructorExample
{
    class Program
    {
        public static void Main(String[] args)
        {
            //Without constructor
            Employee Emp1 = new Employee();
            Emp1.SetEmployee(12233, 24, "Mohit");
            Emp1.GetEmployee();

            Employee Emp2 = new Employee();
            Emp2.SetEmployee(12133, 24, "Rohit");
             Emp2.GetEmployee();

            Employee Emp3 = new Employee();
            Emp3.SetEmployee(12233, 34, "Lohit");
            Emp3.GetEmployee();

            //with constructor
            Employee1 emp1 = new Employee1(12122, 23, "Mohit");
            emp1.GetEmployee();

            Employee1 emp2 = new Employee1(112122, 23, "Pohit");
            emp2.GetEmployee();

            Employee1 emp3 = new Employee1(112122, 23, "Lohit");
            emp3.GetEmployee();

        }

    }

    //Without Constructor
    class Employee
    {
        int EmpID;
        int Age;
        String Name;

        public void SetEmployee(int empId, int age, String name)
        {
            EmpID = empId;
            Age = age;
            Name = name;
        }

        public void GetEmployee()
        {
            Console.WriteLine(EmpID);
            Console.WriteLine(Age);
            Console.WriteLine(Name);
        }
    }

    //With Construtor
    class Employee1
    {
        int EmpID;
        int Age;
        String Name;

        public Employee1(int empId, int age, String name)
        {
            EmpID = empId;
            Age = age;
            Name = name;
        }

        public void GetEmployee()
        {
            Console.WriteLine(EmpID);
            Console.WriteLine(Age);
            Console.WriteLine(Name);
        }
    }
}