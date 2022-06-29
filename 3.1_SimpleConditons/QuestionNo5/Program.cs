using System;

namespace QuestionNo5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the number(0-9):");
            int num = int.Parse(Console.ReadLine());
            if(num>=0 &&num<=9)
            {   
                if(num==0)
                {
                    Console.Write("Zero");
                }
                if(num==1)
                {
                    Console.Write("One");
                }
                if(num==2)
                {
                    Console.Write("Two");
                }
                if(num==3)
                {
                    Console.Write("Three");
                }
                if(num==4)
                {
                    Console.Write("Four");
                }
                if(num==5)
                {
                    Console.Write("Five");
                }
                if(num==6)
                {
                    Console.Write("Six");
                }
                if(num==7)
                {
                    Console.Write("Seven");
                }
                if(num==8)
                {
                    Console.Write("Eight");
                }
                if(num==9)
                {
                    Console.Write("Nine");
                }
            }
            else
            {
                Console.WriteLine("Number too big");
            }
        }
    }

}
   
