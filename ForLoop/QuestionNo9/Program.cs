using System;

namespace QuestionNo9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows:");
            int rows = int.Parse(Console.ReadLine());
            int t=1;
            for(int i =1; i<= rows;i++)
            {
                for(int j=1;j<=(rows-i);j++)
                {
                    Console.Write(" ");
                }
                for(int k=1;k<=i;k++)
                {
                    Console.Write($"{t++} ");
                }
                Console.WriteLine(" ");
            }
        }
    }

}
   
