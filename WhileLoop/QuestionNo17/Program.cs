using System;

namespace QuestionNo17
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=1;
            int total = 1;
            Console.WriteLine("Input the number:");
            int num = int.Parse(Console.ReadLine());
            while( i <=num)
            {
                total = total*i ;
                i++;
            }
            Console.WriteLine($"The factorial is {total}");
        }
    }

}
   
