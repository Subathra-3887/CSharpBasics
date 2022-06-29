using System;

namespace QuestionNo1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the side of square:");
            int side = int.Parse(Console.ReadLine());
            int area = 4*side;
            Console.WriteLine($"The area of the square is {area}");
        }
    }

}
   
