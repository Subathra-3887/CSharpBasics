using System;

namespace QuestionNo5
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Input the number of elements to be stored in the array :");
            int num = int.Parse(Console.ReadLine());
            int [] numbers= new int[num];
            int element,i=0;
            for(i=0;i<num;i++)
            {
                Console.Write($"Element-{i} =");
                element = int.Parse(Console.ReadLine());
                numbers[i] = element;
            }
            Console.WriteLine("Even elements in array are:");
            foreach(int num1 in numbers)
            {
                if(num1%2==0)
                {
                    Console.WriteLine($"{num1}\t");
                }
            }
            Console.WriteLine("Odd elements in array are:");
            foreach(int num1 in numbers)
            {
                if(num1%2==1)
                {
                    Console.WriteLine($"{num1}\t");
                }
            }
        }
    }

}
   
