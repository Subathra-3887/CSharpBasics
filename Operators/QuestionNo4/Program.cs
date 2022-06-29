using System;

namespace QuestionNo4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Input Radius:");
            float radius = float.Parse(Console.ReadLine());
            Console.WriteLine("Input Height:");
            float height = float.Parse(Console.ReadLine());
            double volume = 3.14 * Math.Pow(radius,2) * height;
            Console.WriteLine($"Volume: {volume}");
        }
    }

}

