using System;

namespace QuestionNo8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the time in seconds:");
            int s1 =int.Parse(Console.ReadLine());
            int s2 = int.Parse(Console.ReadLine());
            int s3 = int.Parse(Console.ReadLine());
            int secs = s1+s2+s3;
            TimeSpan secTime = TimeSpan.FromSeconds(secs);
            DateTime dateTime = DateTime.Today.Add(secTime);
            string min1 = dateTime.ToString("mm:ss");
            Console.WriteLine(min1);
        }
    }

}
   
