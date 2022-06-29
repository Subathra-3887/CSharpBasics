using System;

namespace QuestionNo15
{
    class Program
    {
        static void Main(string[] args)
        {
            
           Console.WriteLine("Enter the string");
           string str2 = Console.ReadLine();
           SpaceCount (str2);

           void SpaceCount(string name)
                {
                    int count =0;
                    string str1;
                    for(int i=0; i<name.Length;i++)
                    {
                        str1 = name.Substring(i,1);
                        if(str1 ==" ")
                        count++;
                    }
                    Console.WriteLine($"The number os spaces:{count}");
                }

        }
    }

}
   
