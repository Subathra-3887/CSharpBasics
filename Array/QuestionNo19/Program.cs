using System;

namespace QuestionNo19
{
    class Program
    {
        static void Main(string[] args)
        {
            
           int[]array = {1,3,3,7,4,3,2,3,3};
           int n= 8;
           int i,j;
           int majCount = 1;
           for(i = 0;i< n;i=i+1)
           {
               majCount=1;
               for(j=0;j<n;j=j+1)
               {
               if (array[i]==array[j])
               majCount=majCount+1;
               }
           }
           if (majCount>n/2)
           {
           Console.WriteLine($"Majority element is :{array[i]}");
           }
        }
    }

}
   
