using System;

namespace QuestionNo2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the count:");
            int count = int.Parse(Console.ReadLine());
            int sum =0;
            Console.WriteLine("Numbers");
            while(0<count)
            {
                Console.Write("");
                int num = int.Parse(Console.ReadLine());
                sum = sum+(num*num);
                count--;
            }
            Console.WriteLine($"Output:{sum}");
            
        }
    }

}
   
