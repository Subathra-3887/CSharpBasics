using System;

namespace QuestionNo7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SwapNumbers();

            void SwapNumbers()
            {
                Console.WriteLine("Enter a number");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter another number");
                int y = int.Parse(Console.ReadLine());
                x=x+y;
                y=x-y;
                x=x-y;
                Console.WriteLine($"After swapping the 1st number is {x} and second number is {y}");
            }
        }
    }

}
   
