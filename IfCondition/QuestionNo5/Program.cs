using System;

namespace QuestionNo5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Physics:");
            int physics = int.Parse(Console.ReadLine());
            Console.Write("Chemistry:");
            int chemistry = int.Parse(Console.ReadLine());
            Console.Write("Mathematics:");
            int maths = int.Parse(Console.ReadLine());
            int total = physics+chemistry+maths;
            int average = (total/3) ;
            if (average > 75)
            {
                Console.WriteLine("The candidate is eligible for admission");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission");
            }
        }
    }

}
