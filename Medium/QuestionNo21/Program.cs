using System;

namespace QuestionNo21
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the value of n:");
            int n=int.Parse(Console.ReadLine());
            for(int i=0;i<=n;i++)
            {
                string stars = new string('*',i);
                string spaces = new string(' ',n-i);
                Console.Write(spaces);
                Console.Write(stars);
                Console.Write(" | ");
                Console.Write(stars);
                Console.Write(spaces);
                Console.WriteLine();
            }
        }
    }

}
   
