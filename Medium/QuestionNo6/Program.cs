using System;

namespace QuestionNo6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the number of kilometers:");
            int km = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the period of the day:");
            string period = Console.ReadLine().ToLower();
            if(km>=1 && km<=1000)
            {
                if(period=="day")
                {   
                    if(km<20)
                    {
                    double taxiDay = 0.70 + (0.79 * km);
                    Console.WriteLine(taxiDay);
                    }
                    else if(km>20 && km<100)
                    {
                        double busDay =0.09 *km;
                        Console.WriteLine(busDay);
                    }
                    else if(km>100)
                    {
                        double trainDay = 0.06*km;
                        Console.WriteLine(trainDay);
                    }
                   
                }
                if(period=="night")
                {   
                    if(km<20)
                    {
                        double taxiDay = 0.70 + (0.90 * km);
                        Console.WriteLine(taxiDay);
                    }
                    else if(km>20 && km<100)
                    {
                            double busDay =0.09 *km;
                            Console.WriteLine(busDay);
                    }
                    else if(km>100)
                    {
                            double trainDay = km*0.06;
                            Console.WriteLine(trainDay);
                    }
                  
                }
            }
        }
    }

}
   
