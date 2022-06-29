using System;

namespace QuestionNo15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 1st Input:");
            string inputString1 = Console.ReadLine();
            int inputInt1 = int.Parse(inputString1);
            float inputFloat1 = float.Parse(inputString1);
            Console.WriteLine("Enter the 2nd Input:");
            string inputString2 = Console.ReadLine();
            int inputInt2 = int.Parse(inputString2);
            float inputFloat2 = float.Parse(inputString2);
            Console.WriteLine($"String: {inputString1+inputString2}");
            Console.WriteLine($"Integer: {inputInt1+inputInt2}");
            Console.WriteLine($"Float: {inputFloat1+inputFloat2}");
        }
    }

}
