using System;

namespace QuestionNo7
{
    class Program
    {
        static void Main(string[] args)
        {
           int i,j;
           int [,] matrix = new int [3,3];
           
           Console.WriteLine("Input the elements in the matrix:");
           for(i =0;i<3;i++)
           {
               for( j=0;j<3;j++)
               {
                   Console.Write("Element - [{0},{1}]:",i,j);
                   matrix[i,j] = Convert.ToInt16(Console.ReadLine());                
               }
           }
            Console.Write("The matrix is :");
           for(i =0;i<3;i++)
           {
               Console.Write("\n");
               for( j=0;j<3;j++)
               {
                   Console.Write(matrix[i,j]+"   ");        
               }
               Console.Write("\n");
           }
                    
           
        }
    }

}
   
