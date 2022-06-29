using System;

namespace QuestionNo13
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter your date of birth in dd-MM-yyyy format:");
            string date = Console.ReadLine();
            DateTime dob = DateTime.ParseExact(date,"dd/MM/yyyy",null);
            DateTime new1 = dob.AddDays(1000);
            Console.WriteLine(new1.ToString("d"));
        }
    }

}
   
