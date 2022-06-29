using System;

namespace QuestionNo14
{
    class Program
    {
        static void Main(string[] args)
        {
           int result = Square();
           Console.WriteLine($"The square of the number is {result}");

           int Square(){
           Console.WriteLine("Enter the number:");
           int num = int.Parse(Console.ReadLine());
           return num*num;
           }
        }
    }

}
   
