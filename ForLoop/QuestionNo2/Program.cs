using System;

namespace QuestionNo2
{
    class Program
    {
        static void Main(string[] args)
        {   
            int sum = 0;
            Console.WriteLine("Input:");
            for(int i=1;i<=10;i++)
            {
                Console.Write("");
                int num = int.Parse(Console.ReadLine());
                sum = sum+num;
            }
            Console.WriteLine($"Output: {sum}");
            Console.WriteLine($"Average: {sum/10}");
            
        }
    }

}
   
