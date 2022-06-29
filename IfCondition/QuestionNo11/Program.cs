using System;

namespace QuestionNo11
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter the m value:");
            int mValue = int.Parse(Console.ReadLine());
            if(mValue>0)
            {
                Console.WriteLine("The value of n is 1");
            }
            if(mValue == 0)
            {
                Console.WriteLine("The value of n is 0");
            }
            if (mValue<0)
            {
                Console.WriteLine("The value of n is -1");
            }
        }
    }

}