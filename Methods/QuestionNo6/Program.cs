using System;

namespace QuestionNo6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Circle();

            void Circle()
            {
                Console.WriteLine("Enter the radius of the cicle:");
                int radius = int.Parse(Console.ReadLine());
                Console.WriteLine($"Diameter of the cicle is {2*radius}");
                Console.WriteLine($"Circumference of the circle is:{2*3.14*radius}");
                Console.WriteLine($"Area of the circle is {3.14*radius*radius}");
            }
        }
    }

}
   
