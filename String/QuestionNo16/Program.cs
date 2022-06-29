using System;

namespace QuestionNo16
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] array;
            int c=0;
            Console.WriteLine("Enter the string");
            string sample =Console.ReadLine();
            int length = sample.Length;
            array = sample.ToCharArray(0,length);

            Console.Write("Input the position to start:");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Length of substring:");
            int ln = int.Parse(Console.ReadLine());

            Console.WriteLine("The substring is:");
            while(c<ln)
            {
                Console.Write(array[start+c-1]);
                c++;
            }
        }
    }

}
   
