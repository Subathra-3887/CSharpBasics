using System;

namespace QuestionNo6
{
    class Program
    {
        static void Main(string[] args)
        {
            double points=0;
            Console.WriteLine("Enter the number:");
            int num = int.Parse(Console.ReadLine());
            if (num <=100)
            {
                points+=5;
                if(num%2==0)
                {
                    points+=1;
                }
                if(num%10==5)
                {
                    points +=2;
                }
                Console.WriteLine(points);
                Console.WriteLine(num+points);
            }
            if (num >100)
            {
                points=num*0.2;
                if(num%2==0)
                {
                    points+=1;
                }
                if(num%10==5)
                {
                    points +=2;
                }
                Console.WriteLine(points);
                Console.WriteLine(num+points);
            }
            if (num >1000)
            {
                points=num*0.1;
                if(num%2==0)
                {
                    points+=1;
                }
                if(num%10==5)
                {
                    points +=2;
                }
                Console.WriteLine(points);
                Console.WriteLine(num+points);
            }
            
        }
    }

}
   
