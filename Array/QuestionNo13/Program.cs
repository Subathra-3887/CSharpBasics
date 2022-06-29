using System;

namespace QuestionNo13
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Enter the number of elements:");
            int num = int.Parse(Console.ReadLine());
            int [] numbers = new int[num];
            int maxDiff = numbers[1]-numbers[0];
            int element,i,j;
            for(i=0;i<num;i++)
            {
                Console.Write($"Element-{i} =");
                element = int.Parse(Console.ReadLine());
                numbers[i] = element;
            }
            for(i=0;i<num;i++)
            {
                for(j=i+1;j<num;j++)
                    {
                        if(numbers[j]-numbers[i]>maxDiff)
                        {
                            maxDiff=numbers[j]-numbers[i];
                        }
                    }
            }

            Console.WriteLine($"Maximum difference is: {maxDiff}");
        }
    }

}
   
