using System;

namespace QuestionNo17
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
                int percent = ((a+b+c)/3);
                Console.WriteLine($"Percentage: {percent}");
                int average = ((a+b+c)/3);
                Console.WriteLine($"Average: {percent}%");
                if(average>=80 && average<=100)
                {
                    Console.WriteLine("Grade A");
                }
                else if(average>=60 && average<=80)
                {
                    Console.WriteLine("Grade B");
                }
                else if(average>=40 && average<=60)
                {
                    Console.WriteLine("Grade C");
                }
                else if(average<=40)
                {
                    Console.WriteLine("Grade F");
                }

            }

        }
    }

}
   
