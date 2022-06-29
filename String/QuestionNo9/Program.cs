using System;

namespace QuestionNo9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the string:");
            string sample = Console.ReadLine();
             foreach(char item in sample)
            {
                if(item>='a' && item<='z')
                {
                    Console.Write(char.ToUpper(item));
                }
                if(item>='A' && item<='Z')
                {
                    Console.Write(char.ToLower(item));
                }
            }
            
            
           
           
        }
    }

}
   
