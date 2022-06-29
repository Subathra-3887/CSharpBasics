using System;

namespace QuestionNo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the date tme value in dd/MM/yyyy hh:mm:ss tt format");
            DateTime output = DateTime.Parse(Console.ReadLine());
            Console.WriteLine($"Complete date: {output}");
            Console.WriteLine($"Short date: {output.ToString("d")}");
            Console.WriteLine($"Short date: {output.ToString("F")}");
            Console.WriteLine(output.ToString("D"));
            Console.WriteLine(output.Date);
            Console.WriteLine(output.ToString("t"));


            
        }
    }

}
   
