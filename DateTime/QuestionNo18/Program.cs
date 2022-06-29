using System;

namespace QuestionNo18
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DateTime output = new DateTime(2021,8,10,10,40,32);
            Console.WriteLine($"Year: {output.Year}");
            Console.WriteLine($"Month: {output.Month}");
            Console.WriteLine($"Day: {output.Day}");
            Console.WriteLine($"Hour: {output.Hour}");
            Console.WriteLine($"Minute: {output.Minute}");
            Console.WriteLine($"Second: {output.Second}");
            
            Console.WriteLine("After Splitting of the date Format:");
            Console.WriteLine("Enter the date time value in yyyy/MM/dd hh:mm:ss tt format");
            DateTime output1 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine($"Year: {output1.Year}");
            Console.WriteLine($"Month: {output1.Month}");
            Console.WriteLine($"Day: {output1.Day}");
            Console.WriteLine($"Hour: {output1.Hour}");
            Console.WriteLine($"Minute: {output1.Minute}");
            Console.WriteLine($"Second: {output1.Second}");
            Console.WriteLine($"{output1.ToString("tt")}");

            Console.WriteLine("Display of the date format in Reverse Order:");
            Console.WriteLine("Enter the date time value in yyyy/MM/dd hh:mm:ss tt format");
            DateTime output2 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine($"{output2.ToString("tt")}");
            Console.WriteLine($"Second: {output2.Second}");
            Console.WriteLine($"Minute: {output2.Minute}");
            Console.WriteLine($"Hour: {output2.Hour}");
            Console.WriteLine($"Year: {output2.Year}");
            Console.WriteLine($"Month: {output2.Month}");
            Console.WriteLine($"Day: {output2.Day}");
            
            
            
            
        }
    }

}
   
