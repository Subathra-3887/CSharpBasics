using System;

namespace QuestionNo20
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the inputs:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the operation symbol:\n + - Addition\n- - Subraction \n* - Multiplication\n/ - Division \n% - Modulus");
            char choice = char.Parse(Console.ReadLine());
            switch(choice)
            {
                case '+':
                {   
                    Console.WriteLine($"The addition of {num1} and {num2} is{num1+num2}");
                    break;
                }
                case '-':
                {   
                    Console.WriteLine($"The subraction of {num1} and {num2} is{num1-num2}");
                    break;
                }
                case '*':
                {   
                    Console.WriteLine($"The multiplication of {num1} and {num2} is{num1*num2}");
                    break;
                }
                case '/':
                {   
                    Console.WriteLine($"The division of {num1} and {num2} is{num1/num2}");
                    break;
                }
                case '%':
                {   
                    Console.WriteLine($"The modulus of {num1} and {num2} is{num1%num2}");
                    break;
                }
                default:
                {   
                    Console.WriteLine("Invalid Input");
                    break;
                }
            }
        }
    }

}
   
