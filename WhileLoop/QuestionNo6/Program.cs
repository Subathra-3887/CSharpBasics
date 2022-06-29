using System;

namespace QuestionNo6
{
    class Program
    {
        static void Main(string[] args)
        {
            
           Console.Write("Enter the number of terms:");
           int count = int.Parse(Console.ReadLine());
           int sum = 0;
           while(0<count)
           {
               Console.Write("Enter the number:");
               int num = int.Parse(Console.ReadLine());
               sum =sum+num;
               count--;
           }
           Console.WriteLine($"Sum of given digits: {sum}");
        }
    }

}
   
