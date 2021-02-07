using System;

namespace A3
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.Now;
            string thisMonth= date.ToString("MMMM");
            double pi = Math.PI;;
            
            Console.WriteLine($"{thisMonth} {date.Day}, {date.Year}");
            Console.WriteLine($"{date.Year}.{date.Month}.{date.Day}");
            Console.WriteLine($"Day {date.Day} of {thisMonth}, {date.Month}");
            Console.WriteLine($"Year: {date.Year}, Month: {date.Month}, Day: {date.Day}");
            Console.WriteLine($"          {date.DayOfWeek}");
            Console.WriteLine($"     {date.Hour}:{date.Minute}            {date.DayOfWeek}");
            Console.WriteLine($"h:{date.Hour}, m:{date.Minute}, s:{date.Second}");
            Console.WriteLine($"{date.Year}.{date.Month}.{date.Day}.{date.Hour}.{date.Minute}.{date.Second}");

            Console.WriteLine($"${Convert.ToDouble(string.Format("{0:0.00}",pi))}");
            Console.WriteLine($"          {Convert.ToDouble(string.Format("{0:0.000}",pi))}");
         
        }
    }
}
