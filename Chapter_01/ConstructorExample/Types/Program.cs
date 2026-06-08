using System;
namespace Types
{
    class Program
    {
        public static void Main(String[] args)
        {
          Employee emp1 = new Employee("Mohit","Mumbai",23);
          Employee emp2 = new Employee(emp1);
          Employee emp3 = new Employee(emp1);
          emp1.PrintValues();
          emp2.PrintValues();
          emp3.PrintValues();
        }
    }
    class Employee
    {

        public string EmpName;
        public string EmpAdd;
        public int EmpAge;

      //Static Constructor
       static Employee()
        {
            Console.WriteLine("Below are the Employee Details");
        }
        public Employee(string name, string add, int age)
        {
            EmpName=name;
            EmpAdd=add;
            EmpAge=age;
        }
        //copy constructor
        public Employee(Employee obj)
        {
          EmpName=obj.EmpName; //here obj.EmpName indicates the object we used in emp1
          EmpAdd=obj.EmpAdd;
          EmpAge=obj.EmpAge;
        }
        public void PrintValues()
        {
            Console.WriteLine(EmpName);
            Console.WriteLine(EmpAdd);
            Console.WriteLine(EmpAge);
        }
    }
}

//Example of Static Constructor
//output
// Below are the Employee Details
// Mohit
// Mumbai
// 23
// Mohit
// Mumbai
// 23
// Mohit
// Mumbai
// 23