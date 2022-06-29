using System;

namespace QuestionNo5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the date tme value in yyyy/MM/dd hh:mm:ss tt format");
            DateTime output = DateTime.Parse(Console.ReadLine());
            Console.WriteLine($"The day of the week for {output.Date} is {output.DayOfWeek}");
            
        }
    }

}
   
