using System;

namespace QuestionNo8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the number of holidays");
            int holidays = int.Parse(Console.ReadLine());
            int norm = 30000;
            int workingDayPlay = (365-holidays)*63;
            int holiDayPlay = holidays*127;
            int totalMinutes = norm-(holiDayPlay+workingDayPlay);
            if(norm<totalMinutes)
            {
                Console.WriteLine("Tom sleeps well");
                TimeSpan free = TimeSpan.FromMinutes(totalMinutes);
                string answer = string.Format($"{free.Hours:D2}h:{free.Minutes:D2}m");
                Console.WriteLine($"{answer} less for play");
            }
            else
            {
                 Console.WriteLine("Tom will run away");
                TimeSpan free = TimeSpan.FromMinutes(totalMinutes);
                string answer = string.Format($"{free.Hours:D2}h:{free.Minutes:D2}m");
                Console.WriteLine($"{answer} more for play");
            }

        }
    }

}
   
