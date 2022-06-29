using System;

namespace QuestionNo17
{
    class Program
    {
        static void Main(string[] args)
        {
            bool temp ;
            Console.WriteLine("Input the string");
            string sample = Console.ReadLine();
            Console.WriteLine("Input the string to search");
            string sample1 = Console.ReadLine();
            temp =sample.Contains(sample1);
            if(temp==true)
            {
                Console.WriteLine("The substring exists in the string");
            }
            else{
                Console.WriteLine("The substring doesn't exists in the string");
            }
            
           
        }
    }

}
   
