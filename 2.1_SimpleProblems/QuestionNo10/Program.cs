using System;

namespace QuestionNo10
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter tha value in radians:");
            float rad = float.Parse(Console.ReadLine());
            double degree= rad*57.296;
            Console.WriteLine($"The value in degrees is {Math.Round(degree,1)}");
        }
    }

}
   
