using System;

namespace QuestionNo9
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the vineyard size:");
            int vineYardSize = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the kg of grapes:");
            float grapesKg = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the letres needed for wine:");
            int litres = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of workers:");
            int workers = int.Parse(Console.ReadLine());

            double harvest = (vineYardSize*grapesKg)*0.4;
            double vine = harvest/2.5;
            if(vine>litres)
            {
                double diff = vine-litres;
                Console.WriteLine($"Good Harvest this year!Total wine = {Math.Round(vine,0)}");
                Console.WriteLine($"{Math.Round(diff,0)} litres left -> {Math.Ceiling(diff/workers)}litrs wine needed");
            }
            else
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(litres-vine)}litres per person");
            }

        }
    }

}
   
