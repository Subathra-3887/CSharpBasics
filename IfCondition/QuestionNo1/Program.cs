using System;

namespace QuestionNo1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the number:");
            int number = int.Parse(Console.ReadLine());
            if (number%2==0)
            {
                Console.WriteLine($"{number} is an even number");
            }
            else
            {
                Console.WriteLine($"{number} is an odd number");                  
            }
        }
    }

}