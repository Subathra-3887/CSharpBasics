using System;

namespace QuestionNo12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the two numbers a and b:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int temp = a;
            a=b;
            b=temp;
            Console.WriteLine($"Swapping with third variable");
            Console.WriteLine($"After Swapping: a = {a}, b = {b}");
            
            a=a+b;
			b=a-b;
			a=a-b;
            Console.WriteLine($"Swapping without third variable");
            Console.WriteLine($"After Swapping: a = {a}, b = {b}");
        }
    }

}
