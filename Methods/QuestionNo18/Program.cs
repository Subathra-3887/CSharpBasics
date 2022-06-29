using System;

namespace QuestionNo18
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the operation symbol:\n1 - Addition\n2 - Subraction \n3 - Multiplication\n4 Division \n5 - Modulus");
            int int1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the inputs:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Operations(a,b,int1);

            void Operations(int num1,int num2, int choice)
            {
                switch(choice)
            {
                case 1:
                {   
                    Console.WriteLine($"The addition of {num1} and {num2} is {num1+num2}");
                    break;
                }
                case 2:
                {   
                    Console.WriteLine($"The subraction of {num1} and {num2} is {num1-num2}");
                    break;
                }
                case 3:
                {   
                    Console.WriteLine($"The multiplication of {num1} and {num2} is {num1*num2}");
                    break;
                }
                case 4:
                {   
                    Console.WriteLine($"The division of {num1} and {num2} is {num1/num2}");
                    break;
                }
                case 5:
                {   
                    Console.WriteLine($"The modulus of {num1} and {num2} is {num1%num2}");
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

}
   
