using System;

namespace QuestionNo13
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Input the string:");
            string sample =Console.ReadLine();
            int [] count = new int[256];
            int strLength = sample.Length;
            for(int i=0;i<strLength;i++)
            {
                count[sample[i]]++;
            }
            int maxCount =-1;
            char character = ' ';
            for(int i =0;i<strLength;i++)
            {
                if(maxCount<count[sample[i]])
                {
                    maxCount = count[sample[i]];
                    character = sample[i];
                }
            }
            Console.WriteLine($"The highest occuring string is {character}");
            Console.WriteLine($"Number of times occuring = {maxCount}");
        }
    }

}
   
