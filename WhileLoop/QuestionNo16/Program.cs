using System;

namespace QuestionNo16
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=0;
            int sum=0;
            int flag=0;
            while(flag == 0)
            {
                Console.WriteLine("Enter a number:");
                num = int.Parse(Console.ReadLine());
                if (num>0)
                {
                    sum = sum+num;
                }
                else{
                    flag =1;
                }
            }
            Console.WriteLine($"Total:{sum}");
        }
    }

}
   
