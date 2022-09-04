using System;

namespace Module_3_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.Now;

            Console.WriteLine($"{date,40:MMMM d, yyyy}");
            Console.WriteLine($"{date:yyyy.MM.dd}");
            Console.WriteLine($"Day {date:dd} of {date:MMMM}, {date:yyyy}");
            //Year: 2019, Month: 01, Day: 22
            Console.WriteLine($"Year: {date:yyyy}, Month: {date:M}, Day: {date:dd}");
            //            Tuesday (10 spaces total, right aligned)
            Console.WriteLine($"{date,10:dddd}");
            //11:01 PM             Tuesday (10 spaces total for each including the day-of-week, both right-aligned)
            Console.WriteLine($"{date,10:t} {date,10:dddd}");
            //h:11, m:01, s:27
            Console.WriteLine($"h:{date:HH}, m:{date:mm}, s:{date:ss}");
            //.2019.01.22.11.01.27
            Console.WriteLine($"{date:yyyy}.{date:MM}.{date:dd}.{date:mm}.{date:hh}.{date:ss}");

            // Currency
            double pie = Math.PI;
            Console.WriteLine($"{pie:c2}");
            Console.WriteLine($"{pie,10:f3}");
        }
    }
}
