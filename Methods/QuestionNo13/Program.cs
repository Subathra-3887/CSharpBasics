using System;

namespace QuestionNo13
{
    class Program
    {
        static void Main(string[] args)
        {
        
           int n=1;
           Console.WriteLine("Print narutal numbers upto 50");
           numPrint(n);

           int numPrint(int n)
           {
               if (n<=50)
               {
                   Console.Write($"{n}\t");
                   numPrint(n+1);
               }
               return 0;
           }
        }
    }

}
   
