using System;

namespace QuestionNo5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int num=0; 
            bool temp = int.TryParse(Console.ReadLine(), out num); 
            while(!temp)
            {
                Console.WriteLine("Enter the number:");
                temp = int.TryParse(Console.ReadLine(), out num);
            }
            if(num>=1 && num<=5)
            {
            Console.WriteLine($"{num}-valid input");
            }
            else
            {
                temp=false;
            }
        }
    }

}
   
