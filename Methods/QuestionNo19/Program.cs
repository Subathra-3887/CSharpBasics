using System;

namespace QuestionNo19
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            double baseValue;
            double power, result; 
            Console.WriteLine("Enter the base number:");
            baseValue= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the exponent:");
            power = int.Parse(Console.ReadLine());
            result= Math.Pow(baseValue,power);
            Console.WriteLine($"{baseValue} ^ {power} = {result}");
            Power( baseValue,power);
            
            double Power(double a,double p)
            {
                if (power==0)
                {
                    return 0;
                }
                if (power ==1)
                {
                    return baseValue;
                }
                return baseValue*Math.Pow(baseValue,power-1);
                
            }
            
        }
    }

}
   

