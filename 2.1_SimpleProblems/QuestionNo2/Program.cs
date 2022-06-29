using System;

namespace QuestionNo2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the mumber in inches:");
            float inch = float.Parse(Console.ReadLine());
            double cm = inch*2.54;
            Console.WriteLine($"The number in centimeter is {cm}");
        }
    }

}
   
