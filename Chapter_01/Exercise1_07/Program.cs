using System;
namespace Exercise1_07
{
    class Program
    {
        public static void Main(String[] args)
        {

            var i = new iphone() { model = "new" };
            var another_i = new iphone() { model = "new" };
            var n = new nothing() { model = "new" };
            var another_n = new nothing() { model = "new" };
            var s = new samsung() { model = "new" };
            var another_s = new samsung() { model = "new" };

            var iphoneComparision = i.Equals(another_i) ? "Both are same" : "Both are differenet";
            var nothingComparision = n.Equals(another_n) ? "Both are same" : "Both are differenet";
            var samsungComparision = s.Equals(another_s) ? "Both are same" : "Both are differenet";

            Console.WriteLine(iphoneComparision);
            Console.WriteLine(nothingComparision);
            Console.WriteLine(samsungComparision);

        }

    }
    struct iphone
    {
        public string model { get; set; }
    }
    class nothing
    {
        public string model { get; set; }
    }
    class samsung
    {
        public string model { get; set; }
        public override bool Equals(Object obj)
        {
            if (obj is samsung s && obj != null)
            {
                return this.model == s.model;
            }
            return false;
        }
    }
}

//Both are same
//Both are differenet
//Both are same