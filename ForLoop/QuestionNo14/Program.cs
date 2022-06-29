using System;

namespace QuestionNo14
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Input the number:");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int temp = num;
            for(int i =1 ;i<num ;i++)
            {
                if (num%i==0)
                {
                    sum = sum+i;
                }
            }
            if(sum==temp)
            {
                Console.WriteLine($"{temp} is a perfect number");
            }
            else
            {
                Console.WriteLine($"{temp} is not a perfect number");
            }
        }
    }

}
   
