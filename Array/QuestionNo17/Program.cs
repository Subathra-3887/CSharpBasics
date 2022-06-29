using System;

namespace QuestionNo17
{
    class Program
    {
        static void Main(string[] args)
        {
           int i,j,num;
           int sum= 0;
           int [,] matrix = new int [5,5];
           
           Console.WriteLine("Input the order of matrix:");
           num =int.Parse(Console.ReadLine());

           Console.WriteLine("Enter the elements of the matrix:");
           for(i =0;i<num;i++)
           {
               for( j=0;j<num;j++)
               {
                   Console.Write("Element - [{0},{1}]:",i,j);
                   matrix[i,j] = Convert.ToInt16(Console.ReadLine());   
                   if(i==j)
                   {
                       sum = sum+ matrix[i,j];
                   }             
               }
           }
            Console.Write("The matrix is :");
           for(i =0;i<num;i++)
           {
               Console.Write("\n");
               for( j=0;j<num;++j)
               {
                   Console.Write(matrix[i,j]+"   ");        
               }
               Console.Write("\n");
           }
          
        Console.WriteLine($"Addition of the right diagonal elements: {sum}");  
           
        }
    }

}
   
