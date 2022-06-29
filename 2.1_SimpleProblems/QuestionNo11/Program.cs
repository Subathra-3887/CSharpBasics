using System;

namespace QuestionNo11
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the money in USD:");
            float usd = float.Parse(Console.ReadLine());
            double bgn = usd* 1.79549;
            Console.WriteLine($"The vale of money in BGN is {Math.Round(bgn,2)}");
        }
    }

}
   
