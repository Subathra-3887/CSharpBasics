using System;

namespace QuestionNo2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());
            if(age>18)
            {
                Console.WriteLine($"Congradulations! \nYou are eligible for casting your vote.");
            }
            else
            {
                Console.WriteLine($"Sorry! \nYou are not eligible for casting your vote.");
            }
        }
    }

}
