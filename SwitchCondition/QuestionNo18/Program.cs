using System;

namespace QuestionNo18
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Input Hours:");
            int hours = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Minutes:");
            int mins = int.Parse(Console.ReadLine());
            switch(hours>=1 && hours<=12)
            {
                case true:
                {
                    Console.WriteLine("The time is AM");
                    break;
                }
                case false:
                {   
                    Console.WriteLine("The time is PM");
                    break;
                }
            }
        }
    }

}
   
