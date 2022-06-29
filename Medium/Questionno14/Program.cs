using System;

namespace QuestionNo14
{
    class Program
    {
        static void Main(string[] args)
        {   
            double p1 = 0;double p2 = 0;double p3 = 0;double p4 = 0;double p5 = 0;
            int count1 =0; int count2 =0;int count3 =0;int count4 =0;int count5 =0;
            Console.WriteLine("Enter the number of terms:");
            int terms = int.Parse(Console.ReadLine());

            for(int i =1;i<=terms;i++)
            {

                int numbers = int.Parse(Console.ReadLine());
                if (numbers <200)
                {
                    count1++;
                }
                else if(numbers>=200 && numbers<=399)
                {
                    count2++;
                }

                else if(numbers>=400 &&numbers<=500)
                {
                    count3++;
                }
                else if(numbers>=600 &&numbers<=799)
                {
                    count4++;
                }
                else
                {
                    count5++;
                }
            }
            p1 = count1*100/terms;
            p2 = count2*100/terms;
            p3 = count3*100/terms;
            p4 = count4*100/terms;
            p5 = count5*100/terms;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }

}
   
