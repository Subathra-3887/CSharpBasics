using System;

namespace HQuestionNo9
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum ,sum1,diff1;
            int count=0;
            int count1=0;
            int max=0;
            int [] diff = new int [250];
            int [] values =new int[250];
            Console.WriteLine("Enter the number of terms:");
            int terms = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the numbers");
            for(int i=0;i<terms;i++)
            {
                int num1=int.Parse(Console.ReadLine());
                int num2=int.Parse(Console.ReadLine());
                sum=num1+num2;
                count++;
                if((sum%2==0)||(sum%2==1))
                {
                    for(int j=0;j<count;j++)
                    {
                        values[i]=sum;
                    }
                }
            }
            for(int i=0;i<(terms*2);i++)
            {
                for(int j =i+1;j<(terms*2);j++)
                {
                    sum1 = values[i]+values[j];
                    count1++;

                    if((sum1%2==0)||(sum1%2==1))
                    {
                        for(int k=0;k<count1;k++)
                        {
                            diff[i]=sum1;
                        }
                    }
                }
            }
            for(int i=0;i<terms;i++)
            {
                for(int j=i+1;j<terms;j++)
                {
                    if(diff[i]==diff[j])
                    {
                        Console.WriteLine($"Yes,\nValue = {diff[i]}");
                    }
                    else if(diff[i]!= diff[j])
                    {
                        diff1 = diff[i]-diff[j];
                        if(diff1>max)
                        {
                        max = diff1;
                        }
                        Console.WriteLine($"No \nMax Difference = {max}");
                    }
                }
            }
            
            
        }
    }

}
   
