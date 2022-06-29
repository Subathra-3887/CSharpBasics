using System;

namespace QuestionNo13
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the datetime in yyyy/MM/dd hh:mm:ss tt format");
            DateTime output =DateTime.Parse(Console.ReadLine());
            DateTime after = output.AddDays(1);
            DateTime before = output.AddDays(-1);

            Console.WriteLine($"Yesterday: {before.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Tomorrow: {after.ToString("dd/MM/yyyy")}");
        }
    }

}
   
