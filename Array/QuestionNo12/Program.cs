using System;

namespace QuestionNo12
{
    class Program
    {
        static void Main(string[] args)
        {
           int i,j;
           int [,] matrix1 = new int [2,2];
           int [,] matrix2 = new int [2,2];
           int flag = 1;
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
                    if (matrix1[i,j]!=matrix2[i,j]){
                        flag = 0;
                        break;
                    }   
               }
           }
        if(flag==1){
            Console.WriteLine("These matrices are equal");
        }
        else
        {
            Console.WriteLine("These matrices are not equal");

        }
        }
    }

}
   
