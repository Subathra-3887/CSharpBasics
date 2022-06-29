using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter angle 1 of triangle:");
            int angle1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter angle 2 of triangle:");
            int angle2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter angle 3 of triangle:");
            int angle3 = int.Parse(Console.ReadLine());
            int choice = angle1+angle2+angle3;
            switch(choice==180)
            {
                case true:
                {   
                    Console.WriteLine("The triangle is valid");
                    break;
                }
                case false:
                {
                    Console.WriteLine("The triangle is not valid");
                    break;
                }

            }
        }
    }

}