using System;

namespace QuestionNo12
{
    class Program
    {
        static void Main(string[] args)
        {
            string ans = "";
           
            while(ans!="N")
            {   
                Console.WriteLine("Enter a number:");
                int num = int.Parse(Console.ReadLine());
                if(num==0)
                {
                    Console.WriteLine("Number is ZERO");
                }
                else if (num>0)
                {
                    Console.WriteLine("Number is POSITIVE");
                }
                else{
                    Console.WriteLine("Number is NEGATIVE");
                }
                Console.WriteLine("Do you want to continue?(Y/N)");
                ans = Console.ReadLine();
            }
        }
    }

}
   
