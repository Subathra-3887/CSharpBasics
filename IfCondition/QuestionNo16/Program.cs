using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the character");
            char value = char.Parse(Console.ReadLine());
            if(value>='a'&& value <= 'z'||value>='A'&& value <= 'Z' )
            {
                Console.WriteLine("The given character is an alphabet");
            }
            if(value>='0'&& value <= '9')
            {
                Console.WriteLine("The given character is a number");
            }
            else
            {
                Console.WriteLine("The given character is a special character");
            }
        }
    }

}