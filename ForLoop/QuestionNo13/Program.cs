using System;

namespace QuestionNo13
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Enter the number of terms:");
           int count = int.Parse(Console.ReadLine());
           int a=0;
           for(int i = 1; i<=count;i++)
           {
               Console.WriteLine(" ");
               for (int j=1;j<=i;j++)
               {
                    Console.Write($"{a+j} ");
               }
           }
        }
    }

}