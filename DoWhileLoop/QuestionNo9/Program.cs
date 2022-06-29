using System;

namespace QuestionNo9
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            Console.Write("Enter numbers:");
            do{
            Console.WriteLine("");
            int n=int.Parse(Console.ReadLine());
            Console.Write($"{n}");
            count++;
            }while(count<=7);
        }
    }

}
   
