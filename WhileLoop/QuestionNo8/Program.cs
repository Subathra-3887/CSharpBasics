using System;

namespace QuestionNo8
{
    class Program
    {
        static void Main(string[] args)
        {
            int i =1;
            Console.WriteLine("Input the number (Table to be calculated) : ");
            int num = int.Parse(Console.ReadLine());
            while(i <= 10)
            {
                Console.WriteLine($"{num} X {i} = {num*i}");
                i++;
            }
        }
    }

}
   
