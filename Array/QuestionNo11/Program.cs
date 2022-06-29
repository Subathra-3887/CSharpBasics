using System;

namespace QuestionNo11
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Input the number of elements to store in the array :");
            int num = int.Parse(Console.ReadLine());
            int [] numbers = new int[num];
            int elements,i,j;
            int count = 0;
            Console.WriteLine("Input 3 number of elements in the array :");
            for(i=0;i<num;i++)
            {
                Console.Write($"Element-{i} =");
                elements = int.Parse(Console.ReadLine());
                elements=numbers[i] ;
            }
           for(i=0;i<num;i++)
           {
               for(j=i+1;j<num;j++)
               {
                   if (numbers[i] == numbers[j])
                   {
                       count++;
                       break;
                   }
               }
           }
               Console.WriteLine($"Total number of duplicate elements found in array: {count}");
            
       }
    }

}