using System;

namespace QuestionNo11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,r, sum = 0;
            int temp =0;
            Console.WriteLine("Enter the number :");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while(n>0)
            {
                r=n%10;
                sum = (sum*10)+r;
                n=n/10;
            }
            if(temp==sum)
            {
                Console.Write("The number is a palindrome");
            }
            else
            {
                Console.Write("The number is not a palindrome");
            }
        }
    }

}
   
