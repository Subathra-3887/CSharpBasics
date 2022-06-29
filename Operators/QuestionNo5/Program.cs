using System;

namespace QuestionNo5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Physics:");
            float physics = float.Parse(Console.ReadLine());
            Console.WriteLine("Chemistry:");
            float chemistry = float.Parse(Console.ReadLine());
            Console.WriteLine("Maths:");
            float maths = float.Parse(Console.ReadLine());
            Console.WriteLine($"Sum: {physics+chemistry+maths}");
            Console.WriteLine($"Percentage: {(physics+chemistry+maths)/300 *100}%");
        }
    }

}
