using System;

namespace QuestionNo16
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentAge = 18;
            Console.WriteLine("Enter the herited money:");
            float heritedMoney = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the year until living:");
            int yearsToLive = int.Parse(Console.ReadLine());

            for(int i =1800;i<=yearsToLive;i++)
            {
                if(i%2==0)
                {
                    heritedMoney= heritedMoney-12000;
                }
                else
                {
                    heritedMoney=heritedMoney-(12000+50*currentAge);
                }
                currentAge++;
            }
            if(heritedMoney>=0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {heritedMoney} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {heritedMoney} dollars to survive.");
            }
        }
    }

}
   
