using System;

namespace QuestionNo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=0;
            Console.Write("Enter the number of terms:");
            int terms = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter the {terms} numbers:");
            for(int i=1;i<=terms;i++)
            {
                Console.Write("");
                int number = int.Parse(Console.ReadLine());
                sum = sum+number;
            }
            Console.WriteLine($"The sum of all integers is {sum}");
        }
    }

}
   
