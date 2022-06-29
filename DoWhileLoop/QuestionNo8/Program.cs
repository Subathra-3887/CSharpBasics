using System;

namespace QuestionNo8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,sum = 0;
            do{
                Console.Write("Enter a number:");
                num = int.Parse(Console.ReadLine());
                sum = sum+num;
            }while(num!=0);
            Console.WriteLine($"The sum is: {sum}");
        }
    }

}
   
