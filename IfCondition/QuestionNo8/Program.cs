using System;

namespace QuestionNo8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter the sugar level:");
            int sugarLevel = int.Parse(Console.ReadLine());
            if (sugarLevel<90)
            {
                Console.WriteLine("Low Sugar");
            }
            else if(sugarLevel>=90 && sugarLevel<=130)
            {
                Console.WriteLine("Normal");
            }
            else if(sugarLevel>=130 && sugarLevel<=140)
            {
                Console.WriteLine("Medium");
            }
            else if (sugarLevel>=140 && sugarLevel<=170)
            {
                Console.WriteLine("High sugar – try to reduce it from now");
            }
            else if (sugarLevel > 170)
            {
                Console.WriteLine("You are a very high Sugar Patient ");
            }
        }
    }

}