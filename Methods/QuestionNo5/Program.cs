using System;

namespace QuestionNo5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Leapyear();

            void Leapyear()
            {
                Console.WriteLine("Enter the year:");
                int year = int.Parse(Console.ReadLine());
                if(year%4==0 && year%100!=0)
                {
                    Console.WriteLine("It is a leap year");
                }
                if (year%100 == 0 && year%400 ==0)
                {
                    Console.WriteLine("It is a leap year");
                }
                else
                {
                    Console.WriteLine("It is not a leap year");
                }
            }
        }
    }

}
   

