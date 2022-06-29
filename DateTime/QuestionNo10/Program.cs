using System;

namespace QuestionNo10
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i =1994;i<=2014;i++)
            {
                string leap = DateTime.IsLeapYear(i) ? "Leap year":"";
                if(leap == "Leap year")
                {
                Console.WriteLine($"{i} is {leap}");
                }
            }
        }
    }

}
   
