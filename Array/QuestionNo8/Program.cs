using System;

namespace QuestionNo8
{
    class Program
    {
        static void Main(string[] args)
        {
           int i,j;
           int [,] matrix1 = new int [2,2];
           int [,] matrix2 = new int [2,2];
           int [,] matrix3 = new int [2,2];
           Console.WriteLine("Input the elements in the 1st matrix:");
           for(i =0;i<2;i++)
           {
               for( j=0;j<2;j++)
               {
                   Console.Write("Element - [{0},{1}]:",i,j);
                   matrix1[i,j] = Convert.ToInt16(Console.ReadLine());                
               }
           }
           Console.WriteLine("Input the elements in the 2nd matrix:");
           for(i =0;i<2;i++)
           {
               for( j=0;j<2;j++)
               {
                   Console.Write("Element - [{0},{1}]:",i,j);
                   matrix2[i,j] = Convert.ToInt16(Console.ReadLine());                
               }
           }
            for(i =0;i<2;i++)
           {
               for( j=0;j<2;j++)
               {
                   matrix3[i,j] = matrix1[i,j]+matrix2[i,j];       
               }     
            }
            Console.Write("The matrix 1 is :");
           for(i =0;i<2;i++)
           {
               Console.Write("\n");
               for( j=0;j<2;j++)
               {
                   Console.Write(matrix1[i,j]+"   ");        
               }
               Console.Write("\n");
           }

             Console.Write("The matrix 2 is :");
           for(i =0;i<2;i++)
           {
               Console.Write("\n");
               for( j=0;j<2;j++)
               {
                   Console.Write(matrix2[i,j]+"   ");        
               }
               Console.Write("\n");
           }
           Console.Write("The added matrix is :");
            for(i =0;i<2;i++)
           {
               Console.Write("\n");
               for( j=0;j<2;j++)
               {
                   Console.Write(matrix3[i,j]+"   ");        
               }
               Console.Write("\n");
           }   
             
          
           
        }
    }

}
   
