using System;

namespace QuestionNo7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the value of a:");
            float aValue = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of b:");
            float bValue = float.Parse(Console.ReadLine());
            double outputValue = Math.Pow(aValue,2)+ 2*aValue*bValue + Math.Pow(bValue,2);
            Console.WriteLine($"Output: {outputValue}");
        }
    }

}