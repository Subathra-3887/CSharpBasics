using System;

namespace QuestionNo9
{
    class Program
    {
        static void Main(string[] args)
        {
            double result=1;
            Console.WriteLine("Enter the number for converting:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Input unit:");
            string iunit = Console.ReadLine();
            Console.WriteLine("Output unit:");
            string ounit = Console.ReadLine();
            if (iunit=="mm")
            {
                result = num/1000; 
            }
            if (iunit=="cm")
            {
                result = num/100; 
            }
            if (iunit=="mi")
            {
                result = num/0.000621371192; 
            }
            if (iunit=="in")
            {
                result = num/39.3700787; 
            }
            if (iunit=="km")
            {
                result = num/0.001; 
            }
            if (iunit=="ft")
            {
                result = num/3.2808399; 
            }
            if (iunit=="yd")
            {
                result = num/1.0936133; 
            }

            if(ounit=="mm")
            {
                Console.WriteLine($"{result*1000}");
            }
            if(ounit=="cm")
            {
                Console.WriteLine($"{result*100}");
            }
            if(ounit=="mi")
            {
                Console.WriteLine($"{result*0.000621371192}");
            }
            if(ounit=="in")
            {
                Console.WriteLine($"{result*39.3700787}");
            }
            if(ounit=="km")
            {
                Console.WriteLine($"{result*0.001}");
            }
            if(ounit=="ft")
            {
                Console.WriteLine($"{result*3.2808399}");
            }
            if(ounit=="yd")
            {
                Console.WriteLine($"{result*1.0936133}");
            }
            }
        }
    }


   
