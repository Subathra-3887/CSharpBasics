using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Choose the alphabets for the grades:\nE:Excellent \nV:Very Good \nG:Good \nA:Average \nF:Fail");
            char choice = char.Parse(Console.ReadLine());
            switch(choice)
            {
                case 'E':
                {
                    Console.WriteLine("Excellent");
                    break;
                }
                case 'V':
                {
                    Console.WriteLine("Very Good");
                    break;
                }
                case 'G':
                {
                    Console.WriteLine("Good");
                    break;
                }
                case 'A':
                {
                    Console.WriteLine("Average");
                    break;
                }
                case 'F':
                {
                    Console.WriteLine("Fail");
                    break;
                }
                default:
                {
                    Console.WriteLine("Invalid input!");
                    break;
                }
            }
        }
    }

}
