using System;

namespace QuestionNo11
{
    class Program
    {
        static void Main(string[] args)
        {   
            int sum=0;
            int remain,i ;
            int temp=0;
            Console.WriteLine("Input a number:");
            int r1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input a number:");
            int r2 = int.Parse(Console.ReadLine());
            for(i = r1;i<=r2;i++)
            {
                temp =i;
                sum=0;
            while(temp!=0)
            {
                remain = temp % 10;
                temp=temp/10;
                sum = sum + (remain*remain*remain);
            if (sum==i)
            {
                Console.WriteLine(sum);
            }  
            }
            }
        }
    }

}
   
