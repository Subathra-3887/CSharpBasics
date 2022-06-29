using System;

namespace QuestionNo17
{
    class Program
    {
        static void Main(string[] args)
        {
            int id = 500;
            int password = 000;
            Console.WriteLine("Enter your User ID:");
            int userId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Password:");
            int pass = int.Parse(Console.ReadLine());
            switch(id==userId && password==pass)
            {
                case true:
                {   
                    Console.WriteLine("Welcome Dear Programmer"); 
                    break;
                }
                case false:
                {
                    Console.WriteLine("Incorrect ID");
                    break;
                }
            }
        }
    }

}
   
