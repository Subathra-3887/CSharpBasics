using System;

namespace QuestionNo16
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the character:");
            char value = char.Parse(Console.ReadLine());
            switch(value>='a'&& value <= 'z')
            {
                case true:
                {   
                    Console.WriteLine("The given character is lowercase");
                    break;
                }
                case false:
                {    
                    Console.WriteLine("The given character is a uppercase");
                    break;
                }

            }
        }
    }

}
   
