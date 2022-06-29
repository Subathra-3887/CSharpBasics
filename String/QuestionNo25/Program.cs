using System;

namespace QuestionNo25
{
    class Program
    {
        static void Main(string[] args)
        {
             
            Console.WriteLine("Enter the string:");
            string inputString = Console.ReadLine();
            char[] ch = new char[inputString.Length];
            for(int i =0;i<inputString.Length;i++)
            {
                ch[i] = inputString[i];
            }
            Array.Sort(ch);
            Console.WriteLine(String.Join (" ",ch));
        }
    }

}
   
