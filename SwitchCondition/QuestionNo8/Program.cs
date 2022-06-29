using System;

namespace QuestionNo8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the alphabet:");
            char choice = char.Parse(Console.ReadLine());
            switch(choice == 'A'||choice=='E'||choice=='I'||choice=='O'||choice=='U')
            {
                case true:
                {
                    Console.WriteLine("The given character is a Vowel");
                    break;
                }
                case false:
                {
                    Console.WriteLine("The given character is a Consonant");
                    break;
                }
            }
        }
    }

}