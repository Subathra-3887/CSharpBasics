using System;

namespace QuestionNo3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the number:");
            int num = int.Parse(Console.ReadLine());
            if(num%2==0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }

}
   
