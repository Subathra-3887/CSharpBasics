using System;

namespace QuestionNo14
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Input the number of elements :");
            int num = int.Parse(Console.ReadLine());
            int [] numbers = new int[num];
            int elements,i,j,k;
            int count = 0;
            Console.WriteLine("Input number of elements in the array :");
            for(i=0;i<num;i++)
            {
                Console.Write($"Element-{i} =");
                elements = int.Parse(Console.ReadLine());
                elements=numbers[i] ;
            }
            Console.WriteLine("The unique elements in the array are:");
           for(i=0;i<num;i++)
           {
               count = 0;
               for(j=0;j<i-1;j++)
               {
                   if (numbers[i] == numbers[j])
                   {
                       count++;
                   }
               }
           }
           for(k=i+1;k<num;k++)
           {
               if (numbers[i]==numbers[k])
               {
                   count++;
               }
               if(numbers[i]==numbers[i+1])
               {
                   i++;
               }
           }
           if(count==0){
               Console.Write($"{numbers[i]} ");
           }
       }
    }

}