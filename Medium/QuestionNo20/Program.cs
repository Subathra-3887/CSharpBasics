using System;

namespace QuestionNo20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value:");
            int n = int.Parse(Console.ReadLine());
            for(int row =1;row<=n;row++)
            {
                for(int col =1;col<=n-row;col++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for(int col =1;col<row;col++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            for(int row =n;row>0;row--)
            {
                for(int col =1;col<=n-row;col++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for(int col =1;col<row;col++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }

}
   
