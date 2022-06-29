using System;

namespace QuestionNo8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the side of the triangle:");
            float side = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height of the triangle:");
            float height = float.Parse(Console.ReadLine());
            double area = side*height/2;
            Console.WriteLine($"The area of the triangle is: {Math.Round(area,2)}");
        }
    }

}
   
