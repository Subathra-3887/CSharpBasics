using System;

namespace QuestionNo10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            int result = Factorial(n);
            Console.WriteLine($"The factorial of the number is:{result}");

            int Factorial(int numbers)
            {
                if (numbers!=1)
                {
                    return numbers * Factorial(numbers-1);
                }
                else
                {
                    return numbers;
                }
            }
            
        }
    }

}
   
