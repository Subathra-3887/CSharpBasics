using System;

namespace QuestionNo12
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the type of year:");
            string type = Console.ReadLine();
            Console.WriteLine("Enter the number of holidays:");
            int holidays = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the count of weekends:");
            int weekEndCount = int.Parse(Console.ReadLine());

            int sofiaDays = 48*weekEndCount;
            double playInSofia = (3*sofiaDays/4) +(2*holidays/3);
            double playTotal = weekEndCount*playInSofia;

            if(type=="leap")
            {
                playTotal=Math.Floor((playTotal*15/100)+playTotal);
                Console.WriteLine($"{playTotal}");
            } 
            else
            {
                Console.WriteLine($"{Math.Floor(playTotal)}");
            }
        }
    }

}
   
