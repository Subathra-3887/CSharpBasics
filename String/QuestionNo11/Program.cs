using System;

namespace QuestionNo11
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Input the 1st string:");
            string a= Console.ReadLine();
            Console.WriteLine("Input the 2nd string:");
            string b= Console.ReadLine();
            if (a==b)
            {
                Console.WriteLine("The length of both strings are equal and also, both strings are equal");
            }
            else
            {
                Console.WriteLine("Both strings are not equal");
            }
        }
    }

}
   
