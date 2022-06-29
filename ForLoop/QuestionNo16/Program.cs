using System;

namespace QuestionNo16
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter the initial value: ");
            int value1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the initial value: ");
            int value2 = int.Parse(Console.ReadLine());
            for(int i =value1;i<=value2;i++)
            {
                sum = sum+(i*i);
            }
            Console.WriteLine($"The sum of the squares are: {sum}");
        }
    }

}
   
