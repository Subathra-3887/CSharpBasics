using System;

namespace QuestionNo5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the value of base1:");
            int b1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of base2:");
            int b2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of height:");
            int height = int.Parse(Console.ReadLine());
            double area = (b1+b2)*height/2;
            Console.WriteLine($"The area of the trapezoid is {area}");
        }
    }

}
   
