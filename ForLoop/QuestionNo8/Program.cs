using System;

namespace QuestionNo8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows:");
            int rows = int.Parse(Console.ReadLine());
            for(int i =1; i<= rows;i++)
            {
                for(int j=1;j<=(rows-i);j++)
                {
                    Console.Write(" ");
                }
                for(int k=1;k<=i;k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine(" ");
            }
        }
    }

}
   
