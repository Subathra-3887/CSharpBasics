    using System;

    namespace QuestionNo9
    {
        class Program
        {
            static void Main(string[] args)
            {
            PrimeNumber();

            void PrimeNumber()
            {
            Console.WriteLine("Enter the number:");
                int num = int.Parse(Console.ReadLine());
                int count = 0;
                for(int i = 1; i<=num;i++)
                {
                    if (num%i==0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.WriteLine($"{num} is a Prime Number");            
                }
                else
                {
                    Console.WriteLine($"{num} is not a Prime Number");                
                }
            }
        
          }
        }

    }
    
