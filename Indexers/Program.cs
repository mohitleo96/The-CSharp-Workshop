using System;
namespace Indexers
{
    class Program
    {
        public static void Main()
        {
            Employee emp = new Employee(101,"Mohit","Delhi","HR",50000,true);
            Console.WriteLine("Get Employee ID "+emp["eid"]);
            Console.WriteLine("Get Employee Name "+emp["ename"]);
            Console.WriteLine("Get Employee Address "+emp["eadd"]);
            Console.WriteLine("Get Employee Position "+emp["dname"]);
            Console.WriteLine("Get Employee salary "+emp["salary"]);
            if ((bool)emp["status"] == true)
            {
            Console.WriteLine("Get Employee Status is active");
            }
            else
            {
            Console.WriteLine("Get Employee Status is InActive");
            }

            emp["eid"]=1011;
            emp["ename"]="Rohan";
            emp["eadd"]="Delhi";
            emp["dname"]="SD";
            emp["salary"]=19000.99;
            emp["status"]=false;
            Console.WriteLine("Set Employee ID "+emp["eid"]);
            Console.WriteLine("Set Employee Name "+emp["ename"]);
            Console.WriteLine("Set Employee Address "+emp["eadd"]);
            Console.WriteLine("Set Employee Position "+emp["dname"]);
            Console.WriteLine("Set Employee salary "+emp["salary"]);
            if ((bool)emp["status"] == true)
            {
            Console.WriteLine("Set Employee Stauts is active");
            }
            else
            {
            Console.WriteLine("Set Employee Stauts is InActive");
            }

        }
    }

    class Employee
    {
        int Eid;
        string Ename,EAdd,Dname;
        double salary;
        bool status;
        public Employee(int id,string name,string add,string dept,double salary,bool status)
        {
            this.Eid=id;
            this.Ename=name;
            this.EAdd=add;
            this.Dname=dept;
            this.salary=salary;
            this.status=status;
        }
        public object this[string name]
        {
            get
            {
                if(name.ToUpper() == "EID")
                {
                    return Eid;
                }
                 else if(name.ToUpper() == "ENAME")
                {
                    return Ename;
                }
                 else if(name.ToUpper() == "EADD")
                {
                    return EAdd;
                }
                 else if(name.ToUpper() == "DNAME")
                {
                    return Dname;
                }
                 else if(name.ToUpper() == "SALARY")
                {
                    return salary;
                }
                 else if(name.ToUpper() == "STATUS")
                {
                    return status;
                }
                return null;
            }
            set{
                if(name.ToUpper() == "EID")
                {
                   Eid = (int)value;
                }
                    else if(name.ToUpper() == "ENAME")
                {
                   Ename = (string)value;
                }
                   else if(name.ToUpper() == "EADD")
                {
                   EAdd = (string)value;
                }
                   else if(name.ToUpper() == "DNAME")
                {
                   Dname = (string)value;
                }
                  else if(name.ToUpper() == "SALARY")
                {
                   salary = (double)value;
                }
                   else if(name.ToUpper() == "STATUS")
                {
                   status = (bool)value;
                }


            }
        }
    }
}


//output
// Get Employee ID 101
// Get Employee Name Mohit
// Get Employee Address Delhi
// Get Employee Position HR
// Get Employee salary 50000
// Get Employee Staus is active
// Set Employee ID 1011
// Set Employee Name Rohan
// Set Employee Address Delhi
// Set Employee Position SD
// Set Employee salary 19000.99
// Set Employee Staus is InActive