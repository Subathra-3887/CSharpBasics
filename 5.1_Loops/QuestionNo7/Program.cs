using System;

namespace QuestionNo7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the number of terms:");
            int terms = int.Parse(Console.ReadLine());
            int[]arr=new int[250];
            int max=0;
            int sum =0;

            Console.WriteLine("Enter the numbers:");
            for(int i = 0;i<terms;i++)
            {
                int number=int.Parse(Console.ReadLine());
                arr[i]=number;
            }
            for(int i=0;i<terms;i++)
            {
              if(i==0)
              {
                  max=arr[i];
              }  
              if (arr[i]>max)
              {
                  max=arr[i];
              }
            }
            
            for(int k=0;k<terms;k++)
            {
             if(arr[k]!=max)
                {
                    sum=sum+arr[k];
                }
            }
            if(sum==max)
            {
                Console.WriteLine($"Yes\nSum = {sum}");
            }
            else
            {   
                int diff = Math.Abs(max-sum);
                Console.WriteLine($"No\nDiff = {diff}");
            }
        }
    }
}

   
