using System;

namespace QuestionNo7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the number for respective gender:\n1.Male\n2.Female\n3.Transgender");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                {   
                    Console.WriteLine("The entered genger value is MALE");
                    break;
                }
                case 2:
                {   
                    Console.WriteLine("The entered gender value is FEMALE");
                    break;
                }
                case 3:
                {   
                    Console.WriteLine("The entered gender value is TRANSGENDER");
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