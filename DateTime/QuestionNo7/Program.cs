using System;

namespace QuestionNo7
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            DateTime new1 = today.AddDays(40);
            Console.WriteLine(new1);
            Console.WriteLine($"Today: {today}");
            Console.WriteLine(new1.DayOfWeek);
          
        }
    }

}
   
