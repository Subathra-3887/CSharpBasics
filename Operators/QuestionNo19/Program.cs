using System;

namespace QuestionNo19
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the radius of Sphere:");
            int radius = int.Parse(Console.ReadLine());
            double surfaceArea = 4*3.14*(Math.Pow(radius,2));
            double volume = ((4)*3.14*(Math.Pow(radius,3))/3);
            Console.WriteLine($"Surface Area: {surfaceArea}");
            Console.WriteLine($"Volume: {volume}");
        }
    }

}
