using System;

namespace QuestionNo4
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Input the number of elements to be stored in the array :");
            int num = int.Parse(Console.ReadLine());
            int [] numbers = new int[num];
            int element,i,j=0;
            int max= 0;
            int min= 0;
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
                if(numbers[i]>numbers[j])
                {
                    max = numbers[i];
                }
                else
                {
                    max = numbers[j];
                }
            }
            for(i=0;i<num;i++)
            {
                for(j=i+1;j<num;j++)
                {
                if(numbers[i]<numbers[j])
                {
                    min = numbers[i];
                }
                else
                {
                    min = numbers[j];
                }
            }
            }
            Console.WriteLine($"Maximum element is: {max}");
            Console.WriteLine($"Minimum element is: {min}");
        }
    }

    }
}
   
