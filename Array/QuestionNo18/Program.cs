using System;

namespace QuestionNo18
{
    class Program
    {
        static void Main(string[] args)
        {
            
           int[]array = {1,3,2,4,5,6,8,9};
           int n= 8;
           int sum = (n+1)*(n+2)/2;
           for(int i = 0;i< n;i++)
           {
               sum= sum- array[i];
           }
           Console.WriteLine($"Missing element is :{sum}");
        }
    }

}
   
