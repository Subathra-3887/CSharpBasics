using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int a=9;
            Console.Write("Input the number of terms:");
            int num = int.Parse(Console.ReadLine());
            for(int i = 1; i<=num;i++)
            {
                sum= sum+a;
                Console.Write($"{a}\t");
                a =a*10+9;
            }
            Console.WriteLine("\n");
            Console.WriteLine($"The sum of the series is:{sum}");
        }
    }

}
   

