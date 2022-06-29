using System;

namespace QuestionNo9
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the degrees in celcius:");
            float celcius = float.Parse(Console.ReadLine());
            double fahren = celcius*(9/5)+32;
            Console.WriteLine($"The degrees in fahrenheit is {Math.Round(fahren,2)}°F");
        }
    }

}
   
