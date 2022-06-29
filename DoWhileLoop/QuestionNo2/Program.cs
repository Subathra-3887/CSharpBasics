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
            do{
                Console.WriteLine("Enter the Number:");
                Console.Write("");
                int num = int.Parse(Console.ReadLine());
                if (num>0)
                {
                sum = sum+num; 
                }
                count--;
            }while(0<count);
            Console.WriteLine($"Output:{sum}");
        }
    }

}
   
