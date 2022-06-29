using System;

namespace QuestionNo16
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the time in hours and minutes:");
            int hours =int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            hours=hours*60;
            int total = hours+min+15;
            TimeSpan secTime = TimeSpan.FromMinutes(total);
            DateTime dateTime = DateTime.Today.Add(secTime);
            string min1 = dateTime.ToString("hh:mm");
            Console.WriteLine(min1);
        }
    }

}
   
