using System;

namespace QuestionNo1
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Enter the number of elements:");
            int num = int.Parse(Console.ReadLine());
            int [] numbers = new int[num];
            int element,i=0;
            for(i=0;i<num;i++)
            {
                Console.Write($"Element-{i} =");
                element = int.Parse(Console.ReadLine());
                numbers[i] = element;
            }
            Console.WriteLine("Elements in array are:");
            foreach(int num1 in numbers)
            {
                Console.WriteLine(num1);
            }
        }
    }

}
   
