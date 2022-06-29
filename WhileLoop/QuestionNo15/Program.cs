using System;

namespace QuestionNo15
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter any number:");
            int num = int.Parse(Console.ReadLine());

            int d2 = num%10;
            int d1 = num;
            while(d1>=10)
            {
                d1=d1/10;
            }
            Console.Write($"First digit: {d1}\nLast Digit:{d2}");
        }
    }

}
   
