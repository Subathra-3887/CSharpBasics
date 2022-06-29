using System;

namespace QuestionNo6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DateTime today = DateTime.Today;
            for(int i=0;i<=10;i++)
            {
                DateTime days = today.AddYears(i);
                string leap = DateTime.IsLeapYear(today.Year) ? "(Leap Year)" : "";
                Console.WriteLine($"{today}: day {today.DayOfYear} of {today.Year} {leap}");
            }
        }
    }

}
   
