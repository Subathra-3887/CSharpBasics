using System;

namespace QuestionNo3
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Enter the number of elements:");
            int num = int.Parse(Console.ReadLine());
            int [] numbers = new int[num];
            int element,i,sum=0;
            for(i=0;i<num;i++)
            {
                Console.Write($"Element-{i} =");
                element = int.Parse(Console.ReadLine());
                numbers[i] = element;
            }
            foreach(int num1 in numbers)
            {
               sum=sum+num1;
            }
            Console.WriteLine($"Sum of all elements stored in the array is {sum}");
        }
    }

}
   
