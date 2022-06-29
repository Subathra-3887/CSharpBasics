using System;

namespace QuestionNo11
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalIncome =0;
            Console.WriteLine("Enter the screen type:");
            string screenType = Console.ReadLine().ToLower();
            Console.WriteLine("Enter the number of rows:");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of columns:");
            int columns = int.Parse(Console.ReadLine());

            int cinemaFull = rows*columns;
            if(screenType=="premiere")
            {
                totalIncome = cinemaFull*12.00;
                Console.WriteLine(totalIncome);
            }
            if(screenType=="Normal")
            {
                totalIncome = cinemaFull*7.50;
                Console.WriteLine(totalIncome);
            }
            if(screenType=="Discount")
            {
                totalIncome = cinemaFull*5.00;
                Console.WriteLine(totalIncome);
            }
        }
    }

}
   
