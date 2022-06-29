using System;

namespace QuestionNo9
{
    class Program
    {
        static void Main(string[] args)
        {   int count =0;
            int count1=0;
            int count2=0; 
            Console.Write("Input the string:");
            string sample = Console.ReadLine();
             foreach(char item in sample)
            {
                if(item>='a' && item<='z'|| item>='A' && item<='Z')
                {
                    count++;
                }
                else if(item>='0' && item<='1')
                {
                    count1++;
                }
                
                else{
                    count2++;
                }

            }
            Console.WriteLine($"The number of alphabets are: {count}");
            Console.WriteLine($"The number of numerics are: {count1}");
            Console.WriteLine($"The number of special characters are: {count2}");

            
           
           
        }
    }

}
   

