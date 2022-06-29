using System;

namespace QuestionNo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int max =0;
            Console.WriteLine("Enter the number of terms:");
            int terms = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the numbers");
            for(int i =1;i<=terms;i++)
            {
                Console.Write("");
                int number = int.Parse(Console.ReadLine());
                if(number>max)
                {
                    max=number;
                }
            }
            Console.WriteLine($"The largest number is {max}");
        }
    }

}
   
