using System;

namespace QuestionNo20
{
    class Program
    {
        static void Main(string[] args)
        {
            int p,q=0;
            Console.WriteLine("Input the bumber of rows:");
            int num = int.Parse(Console.ReadLine());
            for(int i=1;i<=num;i++)
            {
                if(i%2==0)
                {
                p=1;
                q=0;
                }
                else
                {
                p=0;
                q=1;
                }
                for(int j=1;j<=i;j++)
                {
                    if(j%2==0)
                    {
                        Console.Write($"{p} ");
                    }
                    else
                    {
                        Console.Write($"{q} ");
                    }
                }
                Console.Write("\n");
            }
        }
    }

}
   
