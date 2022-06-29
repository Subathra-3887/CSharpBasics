using System;

namespace QuestionNo1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter your grade:");
            float grade = float.Parse(Console.ReadLine());
            if(grade>=5.50)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }

}
   
