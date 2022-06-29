using System;

namespace QuestionNo17
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the character");
            char value = char.Parse(Console.ReadLine());
            if(value>='a'&& value <= 'z' )
            {
                Console.WriteLine("The given character is lowercase");
            }
            else
            {
                Console.WriteLine("The given character is uppercase");
            }
        }
    }

}