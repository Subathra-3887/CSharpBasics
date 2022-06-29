using System;

namespace QuestionN016
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the value in meters:");
            float meterValue = float.Parse(Console.ReadLine());
            float centiMeter = meterValue * 100;
            float milliMeter = centiMeter * 10;
            double inchValue = 39.3 * meterValue ;
            float footValue = 12 * meterValue;
            double mileValue = 0.0006213715277778 * meterValue; 
            Console.WriteLine($"Values in:");
            Console.WriteLine($"Centimeter: {centiMeter}");
            Console.WriteLine($"Millimeter: {milliMeter}");
            Console.WriteLine($"Inches: {inchValue}");
            Console.WriteLine($"Foot: {footValue}");
            Console.WriteLine($"Mile: {mileValue}");
        }
    }

}
