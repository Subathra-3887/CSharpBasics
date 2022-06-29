using System;

namespace QuestionNo4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the number of terms:");
            int terms = int.Parse(Console.ReadLine());
            terms=terms*2;
            int sum1=0;
            int sum2=0;
            for(int i =1;i<=terms;i++)
            {
                Console.Write("");
                int number= int.Parse(Console.ReadLine());
                if(i<=terms/2)
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
                    Console.WriteLine($"Yes, sum = {sum1}");
                }
                else
                {   
                    int diff = sum1-sum2;
                    Console.WriteLine($"No,diff = {Math.Abs(diff)}");
                }
        }
    }

}
   
