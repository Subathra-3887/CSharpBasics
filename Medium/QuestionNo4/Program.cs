using System;

namespace QuestionNo4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the number of bitcoins:");
            int coins = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of chinese yuans:");
            float yuans = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the rate of commission:");
            float comm = float.Parse(Console.ReadLine());
            if(coins>=0 && coins<=20 && yuans>=0.00 && yuans<=50000.00 && comm>=0.00 && comm<=5.00)
            {
               double btcBgn = 1168;
               double cnyBgn = 0.15*1.76;

               double btc = btcBgn*coins;
               double cny = cnyBgn*yuans;

               double totalEuro = (btc+cny)/1.95;
               double total = totalEuro - (totalEuro*(comm/100));

               Console.WriteLine(total);
            }
        }
    }

}
   
