using System;

namespace QuestionNo18
{
    class Program
    {
        static void Main(string[] args)
        {   
            string org = "Subathra";
            string pass ="1702";
            Console.WriteLine("Input a username");
            string sample = Console.ReadLine();
            Console.WriteLine("Input a password");
            string sample1 = Console.ReadLine(); 
           if(org==sample && pass==sample1)
           {
               Console.WriteLine("Password entered succesfully!");
           }
           else
           {
               Console.WriteLine("Invalid Password");
           }
           
        }
    }

}
   
