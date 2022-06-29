using System;

namespace QuestionNo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the string");
            string sample = Console.ReadLine();
            Console.WriteLine("The caharaters of the string are:");
            foreach(char item in sample)
            {
             Console.Write($"{item} ");
            }
           
           
        }
    }

}
   
