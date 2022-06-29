using System;

namespace QuestionNo2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the price of vegtables:");
            float vegPrice = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the price of fruits:");
            float fruPrice = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the kg of vegtables:");
            int vegKg = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the kg of fruits:");
            int fruKg = int.Parse(Console.ReadLine());
            if(vegPrice>=0.00 && vegPrice<=1000.00 && fruPrice>=0.00 && fruPrice<=1000.00 && vegKg>=0.00 && vegKg<=1000.00 &&fruKg>=0.00 && fruKg<=1000.00 )
            {
                float veg =  vegPrice*vegKg;
                float fru =  fruPrice*fruKg;
                float total = (float)((fru+veg)/1.94);
                Console.WriteLine(Math.Round(total,0));
            }
        }
    }

}
   
