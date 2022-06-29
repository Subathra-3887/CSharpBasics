using System;

namespace QuestionNo24
{
    class Program
    {
        static void Main(string[] args)
        {
            int count =0;
            Console.WriteLine("Input the string:");
            string inputString = Console.ReadLine();
            foreach(char item in inputString)
            {
                if(item=='\n')
                {
                    count++;
                }
            }
            Console.WriteLine($"The number of lines is: {count}");
        }
    }

}
   
