using System;

namespace QuestionNo9
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the character");
            char value = char.Parse(Console.ReadLine());
            switch(value>='a'&& value <= 'z'||value>='A'&& value <= 'Z')
            {
                case true:
                {   
                    Console.WriteLine("The given character is a alphabet");
                    break;
                }
                case false:
                {    
                    switch(value>='0'&& value <= '9')
                    {
                        case true:
                        {
                            Console.WriteLine("The given character is a number");
                            break;
                        }
                        case false:
                        {
                            Console.WriteLine("The given character is a special character");
                            break;
                        }

                    }
                
                    break;
                }

            }
        }
    }

}
   
