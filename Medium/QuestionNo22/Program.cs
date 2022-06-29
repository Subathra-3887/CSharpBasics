using System;

namespace QuestionNo22
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the value of n:");
            int n = int.Parse(Console.ReadLine());
            Console.Write(new string('*',2*n));
            Console.Write(new string(' ',n));
            Console.Write(new string('*',2*n));
            Console.WriteLine();
            for(int i =0;i<=n-2;i++)
            {
                if(i==(n-1)/2-1)
                {
                    Console.Write(new string('|',n));
                }
                else
                {
                    Console.Write(new string(' ',n));
                }
                Console.WriteLine();
            }          
            Console.Write(new string('*',2*n));
            Console.Write(new string(' ',n));
            Console.Write(new string('*',2*n));  
        }
    }

}
   
