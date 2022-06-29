using System;

namespace QuestionNo18
{
    class Program
    {
        static void Main(string[] args)
        {
            int count2=0; int count3=0; int count4=0;
            Console.WriteLine("Enter the number of terms:");
            int terms = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number:");
            for(int i =1;i<=terms;i++)
            {   
                int number=int.Parse(Console.ReadLine());
                
                if(number%2==0)
                {
                    count2++;
                }
                if(number%3==0)
                {
                    count3++;
                }
                if(number%4==0)
                {
                    count4++;
                }
            }
            Console.WriteLine($"{(count2/terms)*100}%");
            Console.WriteLine($"{(count3/terms)*100}%");
            Console.WriteLine($"{(count4/terms)*100}%");

        }
    }

}
   
