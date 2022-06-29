using System;

namespace QuestionNo23
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=0;
            Console.WriteLine("Enter the string:");
            string inputString =Console.ReadLine();
            foreach(int item in inputString)
            {
                if(item >='0'&& item <='9')
                {
                    int num = item -'0';
                    sum = sum+num;
                }
            }
            Console.WriteLine($"The sum of all integers in the string is : {sum}");
        }
    }

}
   
