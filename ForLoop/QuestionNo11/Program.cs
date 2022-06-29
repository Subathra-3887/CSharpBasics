using System;

namespace QuestionNo11
{
    class Program
    {
        static void Main(string[] args)
        {   
            int sum = 0;
            int remain = 0;
            int temp = 0;
            Console.WriteLine("Input a number:");
            int num = int.Parse(Console.ReadLine());
            temp = num ;
            for(int i=num ; num!=0 ;num=num/10)
            {
                remain = num % 10;
                sum = sum + (remain*remain*remain);
            }
            if (temp==sum)
            {
                Console.WriteLine($"{temp} is an Amstrong number");
            }
            else
            {
                Console.WriteLine($"{temp} is not an Amstrong number");
            }   
        }
    }

}
   
