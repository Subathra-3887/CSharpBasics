using System;

namespace QuestionNo10
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "HiTeam";
            Console.Write("Enter the password:");
            string userPassword = (Console.ReadLine());
            if (password == userPassword)
            {
                Console.WriteLine("Right Password");
            }
            else
            {
                Console.WriteLine("Wrong Password");
            }
        }
    }

}
