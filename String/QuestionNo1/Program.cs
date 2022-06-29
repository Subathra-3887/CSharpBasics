using System;

namespace QuestionNo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count =0;
            Console.WriteLine("Input the string");
            string sample = Console.ReadLine();
            foreach(char item in sample)
            {
             count++;
            }
            Console.WriteLine("Length of the string is:"+count);
           
        }
    }

}
   
