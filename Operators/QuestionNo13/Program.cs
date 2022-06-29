using System;

namespace QuestionNo13
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter number of days:");
            int totalDays = int.Parse(Console.ReadLine());
            int years = totalDays/365;
            Console.WriteLine($"Years: {years}");
            int remainDays = totalDays- (years*365);
            int weeks = remainDays/7;
            Console.WriteLine($"Weeks: {weeks}");
            int days = remainDays-(weeks*7);
            Console.WriteLine($"Days : {days}");        
        }
    }

}
