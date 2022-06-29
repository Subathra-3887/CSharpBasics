using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Input number of terms:");
            int count = int.Parse(Console.ReadLine());
            for(int i = 1 ;i<=count;i++)
            {
                double cube = Math.Pow(i,3);
                Console.WriteLine($"Number is {i}: and the cube of {i} is {cube}");
            }
        }
    }

}
   
