using System;

namespace QuestionNo5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the number of terms:");
            int terms = int.Parse(Console.ReadLine());
            int sum1=0;
            int sum2=0;
            Console.WriteLine("Enter the numbers:");
            for(int i =1;i<=terms;i++)
            {
                Console.Write("");
                int number=int.Parse(Console.ReadLine());
                if(i%2==0)
                {
                    sum1=sum1+number;
                }
                else
                {
                    sum2=sum2+number;
                }
            }
            if(sum1==sum2)
            {
                Console.WriteLine($"Yes\nSum = {sum1}");
            }
            else
            {   
                int diff = Math.Abs(sum1-sum2);
                Console.WriteLine($"No\nDiff = {diff}");
            }
        }
    }

}
   
