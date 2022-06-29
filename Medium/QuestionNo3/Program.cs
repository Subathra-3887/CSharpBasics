using System;

namespace QuestionNo3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the side of the ground:");
            int ground = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width of the tile:");
            float wtile = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the length of the tile:");
            float ltile = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width of the bench:");
            int wbench = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the length of the bench:");
            int lbench = int.Parse(Console.ReadLine());
            if(ground>=1 &&ground<=100 && wtile>=0.1 && wtile<=10.00 && ltile>=0.1 && ltile<=10.00 && wbench>=1 && wbench<=10 && lbench>=1 && lbench<=10)
            {
                int groundArea = ground*ground;
                float tileArea = ltile*wtile;
                int benchArea = lbench*wbench;
                groundArea = groundArea-benchArea;
                float total = groundArea/tileArea;
                float price = (float) (total*0.2);
                Console.WriteLine(Math.Round(total,1));
                Console.WriteLine(Math.Round(price,2));
            }
            

        }
    }

}
   
