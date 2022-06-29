using System;

namespace QuestionNo4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the string:");
            string sample = Console.ReadLine();
             for(int i = sample.Length-1;i>=0;i--)
            {
             Console.Write(sample[i]);
            }
            
            
           
           
        }
    }

}
   
