using System;

namespace QuestionNo15
{
    class Program
    {
        static void Main(string[] args)
        {   char sample1;
            int count =0;
            int count1=0;
            Console.Write("Input the string:");
            string sample = Console.ReadLine();

             foreach(char item in sample)
            {
                sample1 =  char.ToLower(item);
                if (sample1=='a'||sample1=='e'||sample1=='i'||sample1=='o'||sample1=='u')
                {
                    count++;
                }
                else
                {
                    count1++;
                }
            }
            Console.WriteLine($"The total number of wovels in the string :{count}");
            Console.WriteLine($"The total number of consonabts in the string :{count1}");

            
           
           
        }
    }

}
   
