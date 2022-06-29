using System;

namespace QuestionNo11
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter word1:");
            string word1 = Console.ReadLine().ToLower();
            Console.WriteLine("Enter word2:");
            string word2 = Console.ReadLine().ToLower();
            if(word1==word2)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }

}
   
