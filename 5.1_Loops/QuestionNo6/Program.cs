using System;

namespace QuestionNo6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the string:");
            string sample = Console.ReadLine().ToLower();
            int sum=0;
            foreach(char item in sample)
            {
                if(item=='a'||item=='e'||item=='i'||item=='o'||item=='u')
                {
                    if(item=='a')
                    {
                        sum=sum+1;
                    }
                    if(item=='e')
                    {
                        sum=sum+2;
                    }
                    if(item=='i')
                    {
                        sum=sum+3;
                    }if(item=='o')
                    {
                        sum=sum+4;
                    }if(item=='u')
                    {
                        sum=sum+5;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }

}
   
