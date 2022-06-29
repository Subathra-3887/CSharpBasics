using System;

namespace QuestionNo10
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the color:");
            string choice = Console.ReadLine().ToLower();
            switch(choice)
            {
                case "blue":
                {   
                    Console.WriteLine("YOU HAVE SELECTED BLUE COLOUR");    
                    break;  
                }
                case "black":
                {   
                    Console.WriteLine("YOU HAVE SELECTED BLACK COLOUR");
                    break;
                }
                case "red":
                {
                    Console.WriteLine("YOU HAVE SELECTED RED COLOUR");
                    break;
                }
                case "yellow":
                {
                    Console.WriteLine("YOU HAVE SELECTED YELLOW COLOUR");
                    break;
                }  
                default:
                {   
                    Console.WriteLine("Invalid Input");
                    break;
                }              
            }
        }
    }

}