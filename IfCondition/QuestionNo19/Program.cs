using System;

namespace QuestionNo19
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the value for X coordinate:");
            int cor1= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value for Y coordinate:");
            int cor2= int.Parse(Console.ReadLine());

            if (cor1>0 && cor2>0)
            {
                Console.WriteLine($"The coordinate point ({cor1},{cor2}) lies in first quadrant");
            }
            else if (cor1<0 && cor2>0)
            {
                Console.WriteLine($"The coordinate point ({cor1},{cor2}) lies in second quadrant");
            }
            else if (cor1<0 && cor2<0)
            {
                Console.WriteLine($"The coordinate point ({cor1},{cor2}) lies in third quadrant");
            }
            else if (cor1>0 && cor2<0)
            {
                Console.WriteLine($"The coordinate point ({cor1},{cor2}) lies in fourth quadrant");
            }
            else if (cor1==0 && cor2==0)
            {
                Console.WriteLine($"The coordinate point ({cor1},{cor2}) lies at the origin");
            }
        }
    }

}
   
