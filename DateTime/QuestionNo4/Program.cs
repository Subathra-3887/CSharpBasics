using System;

namespace QuestionNo4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the date time value in yyyy/MM/dd hh:mm:ss tt format");
            DateTime output = DateTime.Parse(Console.ReadLine());
            Console.WriteLine($"Year: {output.Year}");
            Console.WriteLine($"Month: {output.Month}");
            Console.WriteLine($"Day: {output.Day}");
            Console.WriteLine($"Hour: {output.Hour}");
            Console.WriteLine($"Minute: {output.Minute}");
            Console.WriteLine($"Second: {output.Second}");
            Console.WriteLine($"Milliseconds: {output.Millisecond}");
        }
    }

}
   
