using System;

namespace QuestionNo15
{
    class Program
    {
        static void Main(string[] args)
        {
            int toysCount =0; 
            int MoneySaved =0;
            int moneyEachBirthday = 0;
            Console.WriteLine("Enetr the age of Lily:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the price of washing machine:");
            float priceMachine = float.Parse(Console.ReadLine());
            Console.WriteLine("Price of each toy:");
            int priceToy = int.Parse(Console.ReadLine());

            for(int i =1;i<=age;i++)
            {
                if(i%2==0)
                {
                    MoneySaved = MoneySaved+(moneyEachBirthday-1);
                    moneyEachBirthday = moneyEachBirthday+10;
                }
                else
                {
                    toysCount++;
                }
            }
            if(MoneySaved>=priceMachine)
            {
                Console.WriteLine($"YES! {MoneySaved - priceMachine}");
            }
            else
            {
                Console.WriteLine($"NO! {priceMachine-MoneySaved}");
            }

        }
    }

}
   
