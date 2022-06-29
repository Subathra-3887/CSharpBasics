using System;

namespace QuestionNo6
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=0;
            int i=1;
            Console.WriteLine("Enter the number:");
            int num = int.Parse(Console.ReadLine());
            do{
                    sum = sum+i;
                    i++;
            }while(i<=num);
            Console.WriteLine($"The sum of numbers is:{sum}");
        }
    }

}
   

