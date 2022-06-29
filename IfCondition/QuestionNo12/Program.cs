using System;

namespace QuestionNo12
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the number:");
            int number = int.Parse(Console.ReadLine());
            if (number % 5 == 0 && number % 11 == 0)
            {
                Console.WriteLine("The given number is divisible by 5 and 11");
            }
            else
            {
                Console.WriteLine("The given number is not divisible by 5 and 11");
            }   
        }
    }

}