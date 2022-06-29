using System;

namespace QuestionNo7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the volume of the pool:");
            int poolVolume = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the flow rate of pipe 1:");
            int pipe1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the flow rate of pipe 2:");
            int pipe2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of hours:");
            float hours = float.Parse(Console.ReadLine());

            double waterFill = (pipe1*hours)+(pipe2*hours);
            if(waterFill<=poolVolume)
            {
                double pool = (waterFill/poolVolume)*100;
                double pipe1Percent = ((pipe1/waterFill)*hours)*100;
                double pipe2Percent = ((pipe2/waterFill)*hours)*100;
                
                Console.WriteLine($"The pool is {pool}% full. Pipe1 = {Math.Round(pipe1Percent,0)}%. Pipe2= {Math.Round(pipe2Percent,0)}%");
            }
            else
            {
                int overflow = (int)waterFill-poolVolume;
                Console.WriteLine($"For {hours} hours the pool overflows with {overflow} litres.");
            }
        }
    }

}
   
