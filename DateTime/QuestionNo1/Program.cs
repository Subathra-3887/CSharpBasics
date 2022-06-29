using System;

namespace QuestionNo1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DateTime now =DateTime.Today;
            Console.WriteLine($"General format is: {now}");
            Console.WriteLine(now.ToString("dd/MM/yyyy"));
            Console.WriteLine(now.ToString("dd/MM/yyyy hh:mm:ss tt"));
            Console.WriteLine(now.ToString());

        }
    }

}
   
