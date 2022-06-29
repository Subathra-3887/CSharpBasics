using System;

namespace QuestionNo12
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the first number:");
            int number1= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int number2= int.Parse(Console.ReadLine());
            switch(number1>number2)
            {
                case true:
                {   
                    Console.WriteLine($"{number1} is the greatest number");
                    break;
                }
                case false:
                {   
                    Console.WriteLine($"{number2} is the greatest number");
                    break;
                }
            }
        }
    }

}
