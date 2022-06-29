using System;

namespace QuestionNo13
{
    class Program
    {
        static void Main(string[] args)
        {
            char alphabet = 'A';
            Console.WriteLine("Uppercase Alphabets:");
            while(alphabet<='Z')
            {
                Console.Write($"{alphabet} ");
                alphabet++;
            }
        }
    }

}
   
