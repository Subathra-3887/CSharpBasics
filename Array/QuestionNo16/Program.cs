using System;

namespace QuestionNo16
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Input the number of elements :");
            int num = int.Parse(Console.ReadLine());
            int [] numbers = new int[num];
            int i,pos;
            Console.WriteLine("Input number of elements in the array :");
            for(i=0;i<num;i++)
            {
                Console.Write($"Element-{i} =");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Position with value to be deleted:");
            pos=int.Parse(Console.ReadLine());
           i=0;
           while(i!=pos-1)
           {
               i++;
           }
           num--;
           while(i<num)
           {
               numbers[i] = numbers[i+1];
               i++;
           }
           num--;
           Console.WriteLine("Updated array is:");
           for(i=0;i<num;i++)
           {
               Console.WriteLine($"{numbers[i]}");
           }

       }
    }

}