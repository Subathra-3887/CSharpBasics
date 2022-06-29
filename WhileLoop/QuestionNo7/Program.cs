using System;

namespace QuestionNo9
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num1 = 1;
            int num 3 = 1;
            int num2 = 100;
            int num 4  = 100;
            Console.WriteLine("Even numbers:");
            while(num1<=num2)
            {
                
                if (num1 % 2 == 0)
                {
                    Console.Write($"{num1}\t");
                }
                num1++;
            }
            Console.WriteLine("\n");
            Console.WriteLine("Odd numbers:");
            while(num3<=num4)
            {
                
                if (num3 % 2 == 1)
                {
                    Console.Write($"{num3 }");
                }
                num1++;
            }

        }
    }

}
   
