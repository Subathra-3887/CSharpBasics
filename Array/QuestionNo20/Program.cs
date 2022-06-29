using System;

namespace QuestionNo20
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Enter the number of names:");
            int num = int.Parse(Console.ReadLine());
            string [] names = new string[num];
            int i=0;
            string target = "";
            for(i=0;i<num;i++)
            {
                Console.Write($"Names-{i} =");
                names[i] =(Console.ReadLine());
                 
            }
            Console.WriteLine("DISPLAYING NAME: USING FOR EACH");
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("DISPLAYING NAME: USING FOR ");
            for(i = 0;i<num;i++)
            {
                Console.WriteLine($"{names[i]}");
            }
            
            Console.WriteLine("Enter the name:");
            target = Console.ReadLine();

            Console.WriteLine("COMPARING NAME: USING FOR EACH");
            foreach(string name in names)
            {
                Console.WriteLine(name);
            if (name == target)
            {
                Console.WriteLine($"{target} is present");
            }
            }
        }
    }

}
   
