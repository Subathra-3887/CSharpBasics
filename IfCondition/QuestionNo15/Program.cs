using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter angle1 of the triangle:");
            int angle1 = int.Parse(Console.ReadLine());
            Console.Write("Enter angle2 of the triangle:");
            int angle2 = int.Parse(Console.ReadLine());
            Console.Write("Enter angle3 of the triangle:");
            int angle3 = int.Parse(Console.ReadLine());
            int total = angle1+angle2+angle3;
            if (total == 180)
            {
                Console.WriteLine("The triangle can be formed by the given angles");
            }
            else
            {
                Console.WriteLine("The triangle cannot be formed by the given angles");
            }
        }
    }

}