using System;

namespace QuestionNo10
{
    class Program
    {
        static void Main(string[] args)
        {   int count =0;
        int count1=0; 
            Console.Write("Input the string:");
            string sample = Console.ReadLine();
             foreach(char item in sample)
            {
                if(item>='a' && item<='z')
                {
                    count++;
                }
                else if(item>='A' && item<='Z')
                {
                    count1++;
                }
            }
            Console.WriteLine($"The number of uppercase letters are: {count1}");
            Console.WriteLine($"The number of lowercase letters are: {count}");
            
           
           
        }
    }

}
   

