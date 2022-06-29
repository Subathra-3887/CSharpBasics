using System;

namespace QuestionNo15
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 1;
            Console.WriteLine("Input the number:");
            int num = int.Parse(Console.ReadLine());
            for(int i =num;i>=1;--i)
            {
                total = total*i ;
            }
            Console.WriteLine($"The factorial is {total}");
        }
    }

}
   
