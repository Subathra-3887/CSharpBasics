using System;

namespace QuestionNo17
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the 3 numbers:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            if(num1==num2 && num2==num3 && num3==num1)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }

}
   
