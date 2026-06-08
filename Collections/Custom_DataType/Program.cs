using System;
namespace Custom_DataType
{
    class Customer
    {
        public int custID{get;set;}
        public string custName{get;set;}
        public int custAge{get;set;}
    }
    class Program
    {
        public static void Main()
        {
            Customer c = new Customer();
            c.custID=12;
            c.custName="Mohit";
            c.custAge=24;
            Customer c1 = new Customer(){custID = 13, custName ="Rohit", custAge= 34};
            Customer c2 = new Customer(){custID = 33, custName ="Rohan", custAge= 34};

            //Here we can define any custom class as DataType as well.
            List<Customer> customers = new List<Customer>();
            customers.Add(c);
            customers.Add(c1);
            customers.Add(c2);

            foreach(Customer obj in customers)
            {
                Console.WriteLine(obj.custID+ " " + obj.custName+ " " +obj.custAge);
            }

        }
    }
}

//Output
//12 Mohit 24
// 13 Rohit 34
// 33 Rohan 34