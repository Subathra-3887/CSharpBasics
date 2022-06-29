using System;

namespace QuestionNo14
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int i=1;
            Console.WriteLine("Enter the number of terms:");
            int num = int.Parse(Console.ReadLine());
            while(i<=num)
            {
                Console.Write($"{i*i*i}\t");
                i++;
            }
        }
    }

}
   
