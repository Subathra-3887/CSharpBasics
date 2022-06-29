using System;

namespace QuestionNo6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the number:");
            int number = int.Parse(Console.ReadLine());
            string value = (number % 2 == 0)? "EVEN NUMBER" :"ODD NUMBER";
            Console.WriteLine($"It is {value}");
        }
    }

}