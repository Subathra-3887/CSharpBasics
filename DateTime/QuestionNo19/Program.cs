using System;

namespace QuestionNo19
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var dat = new DateTime(2016, 8, 31);
            for (int ctr = 0; ctr <= 15; ctr++)
            Console.WriteLine(dat.AddMonths(ctr).ToString("d"));
        }
    }

}
   
