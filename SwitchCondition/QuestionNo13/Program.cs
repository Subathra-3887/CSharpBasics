using System;

namespace QuestionNo13
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter th number for the conversion:\n1.Negative to Positive \n2.Positive to Negative");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                {   
                    Console.WriteLine("Enter the negative number:");
                    int nNum = int.Parse(Console.ReadLine());
                    int num1 = Math.Abs(nNum);
                    Console.WriteLine($"The positive form of number is: {num1}");
                    break;
                }
                case 2:
                {   
                    Console.WriteLine("Enter the negative number:");
                    int nNum = int.Parse(Console.ReadLine());
                    int num1 = -Math.Abs(nNum);
                    Console.WriteLine($"The positive form of number is: {num1}");
                    break;
                }
            }
        }
    }

}
   
