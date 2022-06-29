using System;

namespace QuestionNo17
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Input Speed in km/hr:");
            float speedValue = float.Parse(Console.ReadLine());
            Console.WriteLine("Time in sec:");
            float timeValue = float.Parse(Console.ReadLine());
            float distanceValue = speedValue*timeValue*5/18;
            Console.WriteLine($"Distance travelled: {distanceValue}");
        }
    }

}
