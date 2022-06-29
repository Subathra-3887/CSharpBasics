using System;

namespace QuestionNo14
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the string:");
            string inputString = Console.ReadLine();
            Console.WriteLine("Enter the substring:");
            string subString = Console.ReadLine();

            int freq = inputString.Split(subString).Length-1;
            Console.WriteLine($"String searched count is: {freq}");
        }
    }

}
   
