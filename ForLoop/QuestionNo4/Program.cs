using System;

namespace QuestionNo4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Even numbers:");
            for(int i=1;i<=25;i++)
            {
                if (i%2==0)
                {
                    Console.Write($"{i}\t");
                }
            }
        }
    }

}
   
