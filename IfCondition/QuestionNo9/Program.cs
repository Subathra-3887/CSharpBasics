using System;

namespace QuestionNo9
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter the season:");
            string season = Console.ReadLine().ToLower();
            if (season == "december" || season=="january" || season=="february")
            {
                Console.WriteLine("Winter");
            }
            if(season == "march" || season=="april" || season=="may")
            {
                Console.WriteLine("Spring");
            }
            if(season == "june" || season=="july" || season=="august")
            {
                Console.WriteLine("Summer");
            }
            if (season == "september" || season=="october" || season=="november")
            {
                Console.WriteLine("Rainfall");
            }
        }
    }

}