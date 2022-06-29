using System;

namespace QuestionNo7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a ;
            int b;
            Console.WriteLine("Enter the value of x1:");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of x2:");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of y1:");
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of y2:");
            int y2 = int.Parse(Console.ReadLine());
            if(x1>x2 &&y1<y2)
            {
                a = x1-x2;
                b = y2-y1;
            }
            else
            {
                a= x2-x1;
                b= y1-y2;
            }
            int area = a*b;
            int perimeter = 2*(a+b);
            Console.WriteLine($"The area and the perimeter of given coordinates is {area} and {perimeter}");
        }
    }

}
   
