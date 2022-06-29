using System;

namespace QuestionNo3
{
    class Program
    {
        static void Main(string[] args)
        {
            
           int cube = Cube();
           Console.WriteLine($"The cube of the number is {cube}");

           int Cube(){
           Console.WriteLine("Enter the number:");
           int num = int.Parse(Console.ReadLine());
           return num*num*num;
           }

        }
    }

}
   
