using System;

namespace QuestionNo3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the amount of Celsius:");
            float celsiusValue = float.Parse(Console.ReadLine());
            float fahrenheitValue = (celsiusValue * 9/5)+32;
            Console.WriteLine($"Kelvin: {celsiusValue + 273}");
            Console.WriteLine($"Fahrenheit: {fahrenheitValue}");
            
        }
    }

}
