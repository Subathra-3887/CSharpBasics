using System;

namespace QuestionNo4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter your first name:");
            string fname = Console.ReadLine();
            Console.Write("Enter your last name:");
            string lname = Console.ReadLine();
            Console.Write("Enter your age:");
            int age= int.Parse(Console.ReadLine());
            Console.Write("Enter your city:");
            string city = Console.ReadLine();
            Console.WriteLine($"You are {fname} {lname}, a {age}-years old person from {city}.");

           
        }
    }

}
   
