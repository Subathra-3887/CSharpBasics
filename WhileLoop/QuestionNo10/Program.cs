using System;

namespace QuestionNo10
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int count = 1;
            int num =0;
            Console.WriteLine("Input the number:");
            num = int.Parse(Console.ReadLine());
            while(count<num)
            {
                if (num%count==0)
                {
                    sum = sum+count;
                }
                count++;
            }
            if(sum==num)
            {
                Console.WriteLine($"{num} is a perfect number");
            }
            else
            {
                Console.WriteLine($"{num} is not a perfect number");
            }
        }
    }

}
   
