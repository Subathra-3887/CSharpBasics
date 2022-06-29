using System;

namespace QuestionNo9
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the min range:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the max range:");
            int num2 = int.Parse(Console.ReadLine());
            int count = 0;
            int i,j;
            while(num1<=num2)
            {
            for(i =num1; i<=num1; i--)
            {
                for(j=2;j<=i/2;j++)
                {
                if (i % j == 0)
                {
                    count++;
                    break;
                }
                }
            }
            if (count == 0 && i !=0)
            {
                Console.WriteLine($"{num1} is a Prime Number");            
            }
            else
            {
                Console.WriteLine($"{num1} is not a Prime Number");                
            }
                num1++;
            }

        }
    }

}
   
