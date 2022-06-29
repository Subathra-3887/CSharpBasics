using System;

namespace QuestionNo15
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Input the number of elements :");
            int num = int.Parse(Console.ReadLine());
            int [] numbers = new int[num];
            int [] occur = new int [num];
            int i,j;
            int count = 0;
            Console.WriteLine("Input number of elements in the array :");
            for(i=0;i<num;i++)
            {
                Console.Write($"Element-{i} =");
                numbers[i] = int.Parse(Console.ReadLine());
                occur[i]=-1;
            }
           for(i=0;i<num;i++)
           {
               count = 1;
               for(j=i+1;j<num;j++)
               {
                   if (numbers[i] == numbers[j])
                   {
                       count++;
                       occur[j]=0;
                   }
               }
               if(occur[i]!=0)
               {
                   occur[i]=count;
               }
           }
          Console.WriteLine("The frequency of all elements of the array:");
          for(i=0;i<num;i++)
          {
              if(occur[i]!=0)
              {
                  Console.WriteLine($"{numbers[i]} occurs {occur[i]}");
              }
          }
       }
    }

}