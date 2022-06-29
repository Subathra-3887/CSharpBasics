using System;

namespace QuestionNo4
{
    class Program
    {
        static void Main(string[] args)
        {
            int fir =0;
            int sec =1;
            int result,i=0;
            Console.WriteLine("Enter number of terms:");
            int num = int.Parse(Console.ReadLine());
            Console.Write($"{fir} {sec} ");
            while(i<+num){
                result = fir+sec;
                fir =sec;
                sec = result;
                Console.Write($"{result} ");
                i++;
            };
        }
    }

}
   
