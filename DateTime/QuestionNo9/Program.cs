using System;

namespace QuestionNo9
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the datetime in yyyy/MM/dd hh:mm:ss tt format");
            DateTime output =DateTime.Parse(Console.ReadLine());
            DateTime after = output.AddDays(365);
            DateTime before = output.AddDays(-365);

            Console.WriteLine($"{after.ToString("dd/MM/yyyy")} is later than {output.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"{before.ToString("dd/MM/yyyy")} is earlier than {output.ToString("dd/MM/yyyy")}");
        }
    }

}
   
