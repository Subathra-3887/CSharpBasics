using System;

namespace QuestionNo2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Input the first number:");
            float number1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Input the second number:");
            float number2 = float.Parse(Console.ReadLine());
            Console.WriteLine($"Addion: {number1+number2}");
            Console.WriteLine($"Subraction: {number1-number2}");
            Console.WriteLine($"Multiplication: {number1*number2}");
            Console.WriteLine($"Division: {number1/number2}");
            Console.WriteLine($"Modulo: {number1%number2}");

        }
    }

}
