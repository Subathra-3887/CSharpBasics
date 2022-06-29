using System;

namespace QuestionNo17
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int i,j;
            Console.WriteLine("Enter the height of the diamond:");
            int height = int.Parse(Console.ReadLine());

            for(i=0;i<=height;i++)
            {
                for(j=1;j<=height-1;j++)
                Console.Write(" ");
                for(j=1;j<=2*i-1;j++)
                Console.Write("*");
                Console.Write("\n");               
            }            
            for(i=height-1;i>=1;i--)
            {
                for(j=1;j<=height-1;j++)
                Console.Write(" ");
                for(j=1;j<=2*i-1;j++)
                Console.Write("*");
                Console.Write("\n");
                
            }
        }
    }

}
   
