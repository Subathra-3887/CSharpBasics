using System;

namespace QuestionNo18
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the price amount:");
            int priceValue = int.Parse(Console.ReadLine());
            double total = priceValue+ priceValue* 0.18;
            Console.WriteLine($"Total: {total}");
        }
    }

}