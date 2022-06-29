using System;

namespace QuestionNo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Method using recursive function");
            Console.WriteLine("Enter the number of terms:");
            int n = int.Parse(Console.ReadLine());
            int result = Sum(n);
            Console.WriteLine($"The sum of natural numbers:{result}");

            int Sum(int numbers)
            {
                if (numbers!=0)
                {
                    return numbers + Sum(numbers-1);
                }
                else
                {
                    return numbers;
                }
            }
            Console.WriteLine("Method without using recursive method");
            int sum = 0;
            Console.WriteLine("Input:");
            int input = int.Parse(Console.ReadLine());

            Sum (input);
            {
            for(int i=1;i<=input;i++)
            {
            
                sum = sum+i;
            }
            Console.WriteLine($"Output: {sum}");
            }
        }
    }

}
   
