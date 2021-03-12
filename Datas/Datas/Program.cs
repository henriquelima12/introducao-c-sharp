using System;

namespace Datas
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2020, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            var tomorrow = now.AddDays(1);
            var yersterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));

            Console.WriteLine("-----------------------------------");

            var timeSpan = new TimeSpan(1, 2, 3);

            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: " +duration);

            Console.WriteLine("Minutes: " +timeSpan.Minutes);
            Console.WriteLine("Total Minutes: " +timeSpan.TotalMinutes);

            Console.WriteLine("Add Example: " +timeSpan.Add(TimeSpan.FromMinutes(8)));


        }
    }
}
