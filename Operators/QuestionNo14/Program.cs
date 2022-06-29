using System;

namespace QuestionNo14
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the two numbers:");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int greaterValue = number1>number2? number1:number2;
            Console.WriteLine($"The largest number is: {greaterValue}");
            
        }
    }

}
