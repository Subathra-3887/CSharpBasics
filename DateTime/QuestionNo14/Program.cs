using System;

namespace QuestionNo14
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DateTime current = DateTime.Now;
            Console.WriteLine($"The date of today is: {current.ToString("d")}");
            Console.WriteLine("The twelve months are:");
            Console.WriteLine($"{current.ToString("MMM")}");
            for(int i = 1;i<12;i++)
            {
                current = current.AddDays(30);
                Console.WriteLine($"{current.ToString("MMM")}");

            }
            
        }
    }

}
   

