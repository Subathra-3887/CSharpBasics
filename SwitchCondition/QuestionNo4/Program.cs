using System;

namespace QuestionNo4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter the 1st interger:");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the 2nd integer:");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose the numbers for the operations:\n1.Addition \n2.Subraction \n3.Multiplication \n4.Division \n5.Exit");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                {
                    Console.WriteLine($"Addition of {number1} and {number2} is {number1+number2}");
                    break;
                }
                case 2:
                {
                    Console.WriteLine($"Subraction of {number1} and {number2} is {number1-number2}");
                    break;
                }
                case 3:
                {
                    Console.WriteLine($"Multiplication of {number1} and {number2} is {number1*number2}");
                    break;
                }
                case 4:
                {
                    Console.WriteLine($"Division of {number1} and {number2} is {number1/number2}");
                    break;
                }
                case 5:
                {
                    break;
                }
            }
        }
    }

}