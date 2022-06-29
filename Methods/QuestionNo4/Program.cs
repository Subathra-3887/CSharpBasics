using System;

namespace QuestionNo4
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("Enter the number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number:");
            int num3 = int.Parse(Console.ReadLine());
            
            Largest(num1,num2,num3);  

           
         void Largest(int a ,int b, int c)
         {
             if(a>b && a>c)
             {
                 Console.WriteLine($"{a} is the largest number");
             }
             if(b>c && b>a)
             {
                 Console.WriteLine($"{b} is the largest number");
             }
             if(c>a && c>b)
             {
                 Console.WriteLine($"{c} is the largest number");
             }

         }


        }
    }

}
   
