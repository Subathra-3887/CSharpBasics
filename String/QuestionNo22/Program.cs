using System;

namespace QuestionNo22
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Input the string:");
            string inputString = Console.ReadLine();
            Console.WriteLine("Input the substring:");
            string subString = Console.ReadLine();
            
            int index = inputString.IndexOf(subString);
            Console.WriteLine($"Found {subString} in {inputString} at position: {index}");

        }
    }

}
   
