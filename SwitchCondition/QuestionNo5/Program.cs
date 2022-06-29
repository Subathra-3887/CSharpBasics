using System;

namespace QuestionNo5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the name of Country:\nIndia \nPakisthan \nBangladesh");
            string choice = Console.ReadLine().ToLower();
            switch(choice)
            {
                case "india":
                {
                    Console.WriteLine("The favourite players are:\n1.Gambhir\n2.Ashwin\n3.Dhoni");
                    break;
                }
                case "pakisthan":
                {
                    Console.WriteLine("The favourite players are:\n1.Ahmed\n2.Mohammed\n3.Irfan");
                    break;
                }
                case "bangladesh":
                {
                    Console.WriteLine("The favorite players are:\n1.Suresh \n2.Jadeja \n3.Rajesh Mohan");
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
