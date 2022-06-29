using System;

namespace QuestionNo11
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsPalindrom  (string text)
            {
                if (text.Length<=1){
                    return true;
                }
                else
                {
                    if(text[0] != text[text.Length -1])
                    {
                        return false;
                    }
                    else
                    {
                        return IsPalindrom(text.Substring(1,text.Length-2));
                    }
            }
                Palindrom();
                void Palindrom(){
                
                string string1;
                bool func;

                Console.WriteLine("Input a string: ");
                string1 = Console.ReadLine();
                func =IsPalindrom(string1);
                if (func==true)
                {
                Console.WriteLine("The string is a Palindrom");
                }
                else{
                    Console.WriteLine("The string is a not Palindrom");
                   
                }
            }
            }
        }
    }

}   
