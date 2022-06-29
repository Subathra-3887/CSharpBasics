using System;

namespace QuestionNo12
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Input the speed:");
            int speed = int.Parse(Console.ReadLine());
            if(speed <=10)
            {
                Console.WriteLine("Slow");
            }
            if(speed>10&&speed<=50)
            {
                Console.WriteLine("Average");
            }
            if(speed>50&&speed<=150)
            {
                Console.WriteLine("Fast");
            }
            if(speed>150&&speed<=1000)
            {
                Console.WriteLine("Ultra fast");
            }
            if(speed>1000)
            {
                Console.WriteLine("Extremely fast");
            }
        }
    }

}
   
