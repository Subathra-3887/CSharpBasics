using System;

namespace QuestionNo8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the two numers:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Quotient= {num1/num2}");
            Console.WriteLine($"Remainder= {num1%num2}");
        }
    }

}
