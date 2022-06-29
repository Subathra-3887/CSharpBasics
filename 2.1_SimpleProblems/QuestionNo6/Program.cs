using System;

namespace QuestionNo6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the radius of circle:");
            int rad = int.Parse(Console.ReadLine());
            double area = 3.14 * Math.Pow(rad,2);
            double peri = 2*3.14*rad;
            Console.WriteLine($"The area an perimeter of the circle of radius {rad} is {area} and {peri}");
        }
    }

}
   
