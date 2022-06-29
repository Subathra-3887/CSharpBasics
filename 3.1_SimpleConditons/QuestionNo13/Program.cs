using System;

namespace QuestionNo13
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Choose between geometric figures:\nsquare \nrectangle \ncircle \ntriangle");
            string shape = Console.ReadLine().ToLower();
            if(shape=="square")
            {
                Console.WriteLine("Enter the length of the side:");
                float side = float.Parse(Console.ReadLine());
                Console.WriteLine($"{side*side}");
            }
            if(shape=="rectangle")
            {
                Console.WriteLine("Enter the length and breath:");
                float length = float.Parse(Console.ReadLine());
                float breath=float.Parse(Console.ReadLine());
                Console.WriteLine($"{length*breath}");
            }
            if (shape=="circle")
            {
                Console.WriteLine("Enter the radius of the circle:");
                float rad = float.Parse(Console.ReadLine());
                double area = 3.14*(Math.Pow(rad,2));
                Console.WriteLine(area);
            }
            if(shape=="triangle")
            {
                Console.WriteLine("Enter the side and length:");
                float side1 = float.Parse(Console.ReadLine());
                float len1 =float.Parse(Console.ReadLine());
                double area = 0.5*side1*len1;
                Console.WriteLine(area);
            }
        }
    }

}
   
