using System;

namespace QuestionNo13
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the sides of a triangle:");
            int side1 = int.Parse(Console.ReadLine());
            int side2 = int.Parse(Console.ReadLine());
            int side3 = int.Parse(Console.ReadLine());
            if (side1 == side2 && side2== side3)
            {
                Console.WriteLine("The given triangle is an equilateral triangle");
            }
            else if(side1==side2 || side1==side3|| side3==side2)
            {
                Console.WriteLine("The given triangle is an isosceles triangle");
            }
            else
            {
                Console.WriteLine("The given triangle is an scalene triangle");
            }
        }
    }

}
            