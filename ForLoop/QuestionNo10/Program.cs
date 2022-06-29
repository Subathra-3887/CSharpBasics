using System;

namespace QuestionNo10
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the number of terms:");
            int range = int.Parse(Console.ReadLine());
            int a = range -1;
            int b = a+3;
            for(int i=1; i<=(range/2);i++)
            {
                Console.Write($"{a++}  {b++}  ");
            }
        }
    }

}
   
