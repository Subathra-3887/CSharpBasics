using System;

namespace QuestionNo10
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the needed hours:");
            int workHours = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of days the firm has:");
            int availableDays = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of workers:");
            int workers = int.Parse(Console.ReadLine());

            double workDays = availableDays*0.1;
            double overTime = workers*availableDays*2;
            double totalWorkHours = workDays*overTime;
            double totalHours = Math.Floor(overTime+totalWorkHours);
            if(totalHours<workHours)
            {
                Console.WriteLine($"YES! {workHours-totalHours} hours left.");
            }
            else{
                Console.WriteLine($"No enough time! {totalHours-workHours} hours needed.");
            }
        }
    }

}
   
