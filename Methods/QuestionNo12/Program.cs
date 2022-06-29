using System;

namespace QuestionNo12
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Mark 1:");
            int mark1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Mark 2:");
            int mark2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Mark 3:");
            int mark3 = int.Parse(Console.ReadLine());

            Percentage(mark1,mark2,mark3);

            void Percentage(int a ,int b, int c)
            {
                Console.WriteLine($"Mark 1: {a}");
                Console.WriteLine($"Mark 2: {b}");
                Console.WriteLine($"Mark 3: {c}");
                int percent = ((a+b+c)/3);
                Console.WriteLine($"Percentage: {percent}");
            }

        }
    }

}
   
