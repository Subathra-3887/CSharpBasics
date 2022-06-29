using System;

namespace QuestionNo6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of circle:");
            float radius = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number for the respective calculation:\n1.Area\n2.Perimeter\n3.Diameter");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                {   
                    double area = 3.14 * Math.Pow(radius,2); 
                    Console.WriteLine($"The area of the circle is {area}");
                    break;
                }
                case 2 :
                {   
                    double perimeter = 2*3.14*radius;
                    Console.WriteLine($"The perimeter of the circle is {perimeter}");
                    break;
                }
                case 3 :
                {   
                    float dia = 2*radius;
                    Console.WriteLine($"The diameter of the circle is {dia}");
                    break;
                }
                default:
                {   Console.WriteLine("Invalid Input");
                    break;
                }
            }
        }
    }

}