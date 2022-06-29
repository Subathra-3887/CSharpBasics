using System;

namespace QuestionNo16
{
    class Program
    {
        static void Main(string[] args)
        {

            DisplayDetails();

            void DisplayDetails()
            {
                Console.Write("Enter your name:");
                string name = Console.ReadLine();
                Console.Write("Enter your gender:");
                string gender = Console.ReadLine();
                Console.Write("Age:");
                int age = int.Parse(Console.ReadLine());
                Console.Write("Address:");
                string address = Console.ReadLine();
                Console.Write("Contact number:");
                double num = double.Parse(Console.ReadLine());
                Console.Write("City:");
                string city = Console.ReadLine();

                Console.WriteLine("\n");
                Console.WriteLine($"Your name: {name}");
                Console.WriteLine($"Gender: {gender}");
                Console.WriteLine($"Age: {age}");
                Console.WriteLine($"Address: {address}");
                Console.WriteLine($"Gender: {gender}");
                Console.WriteLine($"Contact Number: {num}");
                Console.WriteLine($"City: {city}");

            }
            
        }
    }

}
   
