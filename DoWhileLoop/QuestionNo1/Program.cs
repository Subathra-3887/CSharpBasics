using System;

namespace QuestionNo1
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "";
            do
            {
                Console.WriteLine("Enter the number:");
                int num = int.Parse(Console.ReadLine());
                if (num%4==0 && num%6==0)
                {
                    Console.WriteLine("The number is divisible by 4 and 6");
                }
                else
                {
                    Console.WriteLine("The number is not divisible by 4 and 6");
                }
                Console.WriteLine("Do you want to continue?");
                value = Console.ReadLine().ToLower();
            }while(value =="yes");
        }
    }

}
   
