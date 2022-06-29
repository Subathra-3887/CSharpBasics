using System;

namespace QuestionNo20
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the mark:");
            int marks=int.Parse(Console.ReadLine());
            if (marks>80)
            {
                Console.WriteLine("Grade A");
            }
            else if (marks>60 && marks<=80)
            {
                Console.WriteLine("Grade B");
            }
            else if (marks>35 && marks<=60)
            {
                Console.WriteLine("Grade C");
            }
            else if (marks<35)
            {
                Console.WriteLine("Grade D");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }

}
   
