using System;

namespace QuestionNo7
{
    class Program
    {
        static void Main(string[] args)
        {
            string cpass = "s3cr3t!P@ssw0rd";
            Console.WriteLine("Enter the password:");
            string pass = Console.ReadLine();
            if(pass==cpass)
            {
                Console.WriteLine("Welcome!");
            }
            else 
            {
                Console.WriteLine("Wrong Password");
            }
        }
    }

}
   
