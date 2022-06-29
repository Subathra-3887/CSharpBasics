using System;

namespace QuestionNo8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the date time value in yyyy/MM/dd hh:mm:ss tt format");
            DateTime day1 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter the date time value in yyyy/MM/dd hh:mm:ss tt format");
            DateTime day2 = DateTime.Parse(Console.ReadLine());
            if (day1>day2)
            {
                Console.WriteLine($"{day1} is earlier than {day2}");
            }
             else
            {
                Console.WriteLine($"{day2} is earlier than {day1}");
            }
            
        }
    }

}
   
