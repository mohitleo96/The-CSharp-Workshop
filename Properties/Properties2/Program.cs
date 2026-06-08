using System;
namespace Properties2
{
    class Program
    {
        public static void Main()
        {
            Customer c = new Customer(101,"Mohit",true,15000.45,Cities.Delhi,"Maharastra","India");
            Console.WriteLine("Customer ID " + c.CustID);
            Console.WriteLine("Current Customer Name " + c.CName);
            Console.WriteLine("Current Customer Status " + c.Status);
            Console.WriteLine("Current Customer Salary "+ c.Salary);
            Console.WriteLine("Current City "+ c.City);
            Console.WriteLine("Current State "+ c.State);
            Console.WriteLine("Current Country "+ c.Country);

            //All will be modified if Status = True only.
            c.CName += " Rao";
            c.Status = true;
            c.CName += " Reddy";
            c.Salary = 19000;
            c.City=Cities.Mumbai;
            c.Country="UK"; //Here we can't put condition in Property bcs we didn't create any variable/Field.
            //c.State="UP";//Here we get error because State Set Property is accessable only to child class.
            Console.BackgroundColor= ConsoleColor.Blue;
            Console.WriteLine("Modified Customer Name " + c.CName);
            Console.WriteLine("Modified Customer Status " + c.Status);
            Console.WriteLine("Modified Customer Salary "+ c.Salary);
            Console.WriteLine("Modified City "+ c.City);
            Console.WriteLine("Modified state "+ c.State);
            Console.WriteLine("Modified Country "+ c.Country); //Modified Country UK
             Console.BackgroundColor= ConsoleColor.Black;


        }

    }
    class Customer
    {
        int _CustID;
        string _CName;
        bool _Status;
        double _Salary;

        Cities _City; //Here City is also a UserDefiend Type

        string _State; //Here i have one scenario State should be edited/Set by Child Class Only.
                       //but it Get By Everyone.

        public Customer(int custID, string cname, bool status, double salary, Cities city,string state,string country)
        {
            _CustID = custID;
            _CName = cname;
            _Status = status;
            _Salary = salary;
            _City = city;
            _State = state;
            Country = country; //Here directly map the parameter to property.


        }
        public int CustID
        {
            get{return _CustID;}
        }
        public string CName
        {
            get{return _CName;}
            set{
                if (Status == true)
                {
                _CName = value;
                }
                }
        }
        public bool Status
        {
            get{return _Status;}
            set{_Status = value;}
        }
        public double Salary
        {
            get{return _Salary;}

            set
            {
                if (Status == true)
                {
                _Salary = value;
                }
            }
        }
          public Cities City
        {
            get{return _City;}

            set
            {
                if (Status == true)
                {
                _City = value;
                }
            }
        }
          public string State
        {
            get{return _State;}

           protected set //This is new update on C# :- Here we can directly Set the Access Modifier Directly
                         //So it is  only editable for Child Class.
            {
                if (Status == true)
                {
                _State = value;
                }
            }
        }
        public string Country //This is new update on C# :- Without creating any variable/Field directly we create
                              //Property and assign value to it.
                              //But if any conditions need to provide in SET PROPERTY, then need to create a variable/Field
                              //and follow the previous process.
        {
            get;
            set;
        }

    }

    //Need to create an Enum for City Selection
    public enum Cities
    {
        Mumbai ,Delhi, Banglore , Pune
    }
}

//output(if status == False)
// Customer ID 101
// Current Customer Name Mohit
// Current Customer Status True
// Current Customer Salary 15000.45
// Current City Delhi
// Current State Maharastra
// Current Country India
// Modified Customer Name Mohit Rao
// Modified Customer Status False
// Modified Customer Salary 15000.45
// Modified City Delhi
// Modified state Maharastra
// Modified Country UK

//output(if status == true)
// Customer ID 101
// Current Customer Name Mohit
// Current Customer Status True
// Current Customer Salary 15000.45
// Current City Delhi
// Current State Maharastra
// Current Country India
// Modified Customer Name Mohit Rao Reddy
// Modified Customer Status True
// Modified Customer Salary 19000
// Modified City Mumbai
// Modified state Maharastra
// Modified Country UK