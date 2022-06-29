using System;

namespace QuestionNo10
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());
            if(num<100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (num>=100&&num<=200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }

}
   
