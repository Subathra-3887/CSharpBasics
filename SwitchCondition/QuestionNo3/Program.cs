using System;

namespace QuestionNo3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a number:");
            int choice = int.Parse(Console.ReadLine());
            switch(choice%2 == 1)
            {
                case true:
                {
                    Console.WriteLine("Month has 31 days");
                    break;
                }
                case false:
                {
                    switch(choice == 2)
                    {
                        case true:
                        {   
                            Console.WriteLine("Month has 28 days");
                            break;
                        }
                        case false:
                        {
                            Console.WriteLine("Month has 30 days");
                            break;
                        }

                    }
                    
                    break;
                }
            }
                
            
        }
    }

}