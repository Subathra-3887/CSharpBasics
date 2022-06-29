using System;

namespace QuestionNo2
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Input the number of elements to store in the array :");
            int num = int.Parse(Console.ReadLine());
            int [] numbers = new int[num];
            int element,i=0;
            Console.WriteLine("Input 3 number of elements in the array :");
            for(i=0;i<num;i++)
            {
                Console.Write($"Element-{i} =");
                element = int.Parse(Console.ReadLine());
                numbers[i] = element;
            }
            Console.WriteLine("The values stored into the array are: ");
            foreach(int num1 in numbers)
            {
                Console.WriteLine(num1);
            }
            Console.WriteLine("The values stored into the array in reverse order are: ");
            for(i=num-1;i>=0;i--)
            {
                Console.WriteLine($"{numbers[i]} ");
            }
            
            
        }
    }

}