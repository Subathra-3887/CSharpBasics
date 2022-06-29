using System;

namespace QuestionNo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0;
            Console.WriteLine("Enter the number of terms:");
            int terms = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the numbers");
            for(int i =1;i<=terms;i++)
            {
                Console.Write("");
                int number = int.Parse(Console.ReadLine());
                if(i==1)
                {
                    min = number;
                }
                if(number<min)
                {
                    min=number;
                }
            }
            Console.WriteLine($"The smallest number is {min}");
        }
    }

}
   
