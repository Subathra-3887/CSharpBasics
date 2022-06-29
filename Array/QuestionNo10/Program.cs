using System;

namespace QuestionNo10
{
    class Program
    {
        static void Main(string[] args)
        {
           int i,j;
           int [,] matrix = new int [2,2];
           
           Console.WriteLine("Input the elements in the matrix:");
           for(i =0;i<2;i++)
           {
               for( j=0;j<2;j++)
               {
                   Console.Write("Element - [{0},{1}]:",i,j);
                   matrix[i,j] = Convert.ToInt16(Console.ReadLine());                
               }
           }
            Console.Write("The matrix is :");
           for(i =0;i<2;i++)
           {
               Console.Write("\n");
               for( j=0;j<2;j++)
               {
                   Console.Write(matrix[i,j]+"   ");        
               }
               Console.Write("\n");
           }
            Console.Write("The transpose of matrix is :");
           for(i =0;i<2;i++)
           {
               Console.Write("\n");
               for( j=0;j<2;j++)
               {
                   Console.Write(matrix[j,i]+"   ");        
               }
               Console.Write("\n");
           }        
           
        }
    }

}
   
