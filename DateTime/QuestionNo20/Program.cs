using System;

namespace QuestionNo20
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DateTime baseDate = new DateTime(2016, 2, 29);
            Console.WriteLine("    Base Date:        {0:d}\n", baseDate);

     
             for (int ctr = -1; ctr >= -15; ctr--)
            Console.WriteLine("{0,2} year(s) ago:        {1:d}", Math.Abs(ctr), baseDate.AddYears(ctr));
            Console.WriteLine();

      
            for (int ctr = 1; ctr <= 15; ctr++)
            Console.WriteLine("{0,2} year(s) from now:   {1:d}", ctr, baseDate.AddYears(ctr));
        }
    }

}
   
