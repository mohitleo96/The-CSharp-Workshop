using System;
namespace Exercise1_05
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Are the local date and Uts date equal? {0}", DateTime.Now.Date == DateTime.UtcNow.Date);
            Console.WriteLine("If Dates are equal does it mean there is any difference in Dates? {0}", (DateTime.Now.Date - DateTime.UtcNow.Date) == TimeSpan.Zero);
            DateTime localtime = DateTime.Now;
            DateTime UTCtime = DateTime.UtcNow;
            //timaspan use to calculate timeinterval between days,time etc
            TimeSpan interval = (localtime - UTCtime);
            Console.WriteLine("Difference betwenn the {0} and {1} is {2}:{3}", localtime.Kind.ToString(), UTCtime.Kind.ToString(), interval.Hours, interval.Minutes);
            Console.WriteLine("If we jump two days in future on {0} what date it will be? {1}", new DateTime(2025, 10, 30).ToShortDateString(), new DateTime(2025, 10, 30).AddDays(2).ToShortDateString());
        }
    }
}