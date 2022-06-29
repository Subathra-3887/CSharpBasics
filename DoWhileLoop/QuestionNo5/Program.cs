using System;

namespace QuestionNo5
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "";
            do
            {
                Console.WriteLine("Enter the number:");
                int num = int.Parse(Console.ReadLine());
                if (num%2==0 )
                {
                    Console.WriteLine("EVEN NUMBER");
                }
                else
                {
                    Console.WriteLine("ODD NUMBER");
                }
                Console.WriteLine("Do you want to continue?");
                value = Console.ReadLine().ToLower();
                if(value!="yes"&& value!= "no")
                {
                    Console.WriteLine("Provided input is invalid!");
                    value="yes";
                }
            }while(value =="yes");
        }
    }

}
   
