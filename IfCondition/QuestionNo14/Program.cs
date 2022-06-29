using System;

namespace QuestionNo14
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the alphabet in uppercase");
            char alpha = char.Parse(Console.ReadLine());
            if(alpha=='A'||alpha=='E'||alpha=='I'||alpha=='O'||alpha=='U')
            {
                Console.WriteLine("The given alphabet is a Vowel");
            }
            else
            {
                Console.WriteLine("The given alphabet is a Consonant");
            }
        }
    }

}