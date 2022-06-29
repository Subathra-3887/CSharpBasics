using System;

namespace QuestionNo3
{
    class Program
    {
        static void Main(string[] args)
        {
           int value = 0; 
           Console.Write("Enter a name:");
           while(value==0)
           {  
               Console.WriteLine("");
               string name = Console.ReadLine().ToUpper();
               Console.WriteLine($"{name}");
               if (name=="END")
               {
                   value = 1;
                   Console.WriteLine("Iam done");
               }
           }
        }
    }

}
  