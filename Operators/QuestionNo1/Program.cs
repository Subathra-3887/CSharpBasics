using System;

namespace QuestionNo1
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Subathra";
            Console.WriteLine("Hello: "+myName);    //concatenation
            Console.WriteLine($"Hello: {myName}");  //interpolation($)
            Console.WriteLine("Hello: {0}",myName); //placeholder
            Console.ReadLine();
        }
    }

}
