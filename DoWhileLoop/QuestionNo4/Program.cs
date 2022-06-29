using System;

namespace QuestionNo4
{
    class Program
    {
        static void Main(string[] args)
        {   
            char ans = ' ';
            int value = 0;
            do{
            Console.WriteLine("Enter the input value(1-10):");
            char num = char.Parse(Console.ReadLine());
            if(num>='1' && num<='9')
            {   
                value=1;
                Console.WriteLine($"The entered number is {num} and is valid ");
                Console.WriteLine("Do you want to continue?(Y/N)");
                ans = char.Parse(Console.ReadLine());
                if (ans=='N')
                {
                    value=1;
                }
                else
                {
                    value=0;
                }
            }
            else
            {   
                value=0;
                Console.WriteLine("Invalid input! Try again");
            }
            }while(value ==0);
        }
    }

}
   
