using System;

namespace QuestionNo19
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the number:");
            int number = int.Parse(Console.ReadLine());
            switch(number%5==0 && number%11 == 0)
            {
                case true:
                {   
                    Console.WriteLine($"{number} is divisible by 5 and 11");
                    break;
                }
                case false:
                {   
                    Console.WriteLine($"{number} is not divisible by 5 and 11");
                    break;
                }
            }
        }
    }

}
   
