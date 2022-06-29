using System;

namespace QuestionNo18
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Input the number (Table to be calculated) : ");
            int num = int.Parse(Console.ReadLine());
            for(int i = 1 ; i<=10 ; i++)
            {
                Console.WriteLine($"{num} X {i} = {num*i}");
            }
        }
    }

}
   
