using System;

namespace QuestionNo1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if(a>b)
            {
                Console.WriteLine(a);
            }
            else
            {

                Console.WriteLine(b);
            }
        }
    }

}
   
