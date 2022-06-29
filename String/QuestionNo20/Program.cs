using System;

namespace QuestionNo20
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString, resultString = ""; 
            Console.WriteLine("Enter the string:");
            inputString = Console.ReadLine();
            for(int i =0;i<inputString.Length;i++)
            {
                if(!resultString.Contains(inputString[i]+""))
                {
                    resultString=resultString+inputString[i];
                }
            }
            Console.WriteLine("Final String: "+resultString);
        }
    }

}
   
