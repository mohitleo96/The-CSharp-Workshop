    using System;
    namespace funcActionPredicate
    {

        //No need to create any delegate
    class Program
        {
            static void Main()
            {
                //create instance using FUNC<> delegate
                //Used for methods that return a value.
                // approach using lamda expression
                Func<int, float, double, double> obj1 = (a,b,c) =>
                {
                    return a+b+c;
                };

                //calling or Invoking the Func Method
                double d = obj1.Invoke(12,149.4f,87.999);
                Console.WriteLine(d);


                //create instance using Action<> delegate
                //Used for methods that return void (do not return a value).
                // approach using lamda expression
                Action<int,float,double,int> obj2 = (a,b,c,d) =>
                {
                    Console.WriteLine(a+b+c+d);
                };
                obj2.Invoke(15,111.4f,87.79,34);


                //create instance using Predicate<> delegate
                //Used for methods that take one input and always return a Boolean (true or false).
                // approach using lamda expression
                Predicate<string> obj3= (name) =>
                {
                if(name.Length>5)
                return true;
                return false;
                };
                bool b=obj3.Invoke("Rao");
                Console.WriteLine(b);
            }
        }
    }

    //output
    // 249.39899389648437
    // 248.19000152587893
    // False