using System;

namespace QuestionNo5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Input the number of terms");
            int terms = int.Parse(Console.ReadLine());
            int num = terms*2;
            int sum = 0;
            Console.WriteLine("Odd numbers:");
            for(int i =0 ;i<=num ;i++)
            {
                if (i%2==1)
                {
                    Console.Write($"{i}\t");
                    sum = sum+i;
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine($"The Sum of odd Natural Number upto {terms} terms : {sum}");
        }
    }

}
   
