using System;

namespace QuestionNo19
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,syear,eyear;
            Console.WriteLine("Enter the starting year:");
            syear=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the ending year:");
            eyear=int.Parse(Console.ReadLine());
            Console.WriteLine($"Leap years between {syear} and {eyear} are:");
            i = syear;
            while(i<=eyear)
            {
                if(((i%4==0)&&(i%100!=0)) || (i%400==0))
                {
                    Console.Write($"{i}\t");
                }
                i++;
            }
            
        }
    }

}
   
