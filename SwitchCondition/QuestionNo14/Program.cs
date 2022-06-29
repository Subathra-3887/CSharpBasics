using System;

namespace QuestionNo14
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a number:");
            int choice = int.Parse(Console.ReadLine());
            switch(choice % 2 ==0)
            {
                case true:
                {   
                    int odd = choice+1;
                    Console.WriteLine($"Nearest upper odd is:{odd}");
                    break;
                }
                case false:
                {   
                    int even = choice-1;
                    Console.WriteLine($"Nearest lower even is:{even}");
                    break;
                }
            }
        }
    }

}
   
