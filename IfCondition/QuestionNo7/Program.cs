using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the customer name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the customer ID No:");
            int idNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the units consumed:");
            int units = int.Parse(Console.ReadLine());
            if (units<199)
            {   
                Console.WriteLine($"Customer ID No:{idNo}");
                Console.WriteLine($"Customer Name:{name}");
                Console.WriteLine($"Units Consumed:{units}");
                double amount = units*1.20;
                Console.WriteLine($"Amount Charges @Rs. 1.20 per unit :{amount}");
                if(amount>400)
                {   
                    double surcharge = amount*0.15;
                    Console.WriteLine($"Surcharge amount: {surcharge}");
                    Console.WriteLine($"Net Amount paid by the customer: {amount+surcharge}");
                }
                else
                {
                    Console.WriteLine($"Net Amount paid by the customer: {amount}");
                }
            }
            if (units>=200 && units<400)
            {   
                Console.WriteLine($"Customer ID No:{idNo}");
                Console.WriteLine($"Customer Name:{name}");
                Console.WriteLine($"Units Consumed:{units}");
                double amount = units*1.50;
                Console.WriteLine($"Amount Charges @Rs. 1.50 per unit :{amount}");
                if(amount>400)
                {   
                    double surcharge = amount*0.15;
                    Console.WriteLine($"Surcharge amount: {surcharge}");
                    Console.WriteLine($"Net Amount paid by the customer: {amount+surcharge}");
                }
                else
                {
                    Console.WriteLine($"Net Amount paid by the customer: {amount}");
                }
            }
            if (units>=400 && units<600)
            {
                Console.WriteLine($"Customer ID No:{idNo}");
                Console.WriteLine($"Customer Name:{name}");
                Console.WriteLine($"Units Consumed:{units}");
                double amount = units*1.80;
                Console.WriteLine($"Amount Charges @Rs. 1.80 per unit :{amount}");
                if(amount>400)
                {   
                    double surcharge = amount*0.15;
                    Console.WriteLine($"Surcharge amount: {surcharge}");
                    Console.WriteLine($"Net Amount paid by the customer: {amount+surcharge}");
                }
                else
                {
                    Console.WriteLine($"Net Amount paid by the customer: {amount}");
                }
            }
            if (units>=600)
            {
                Console.WriteLine($"Customer ID No:{idNo}");
                Console.WriteLine($"Customer Name:{name}");
                Console.WriteLine($"Units Consumed:{units}");
                double amount = units*2.0;
                Console.WriteLine($"Amount Charges @Rs. 2.0 per unit :{amount}");
                if(amount>400)
                {   
                    double surcharge = amount*0.15;
                    Console.WriteLine($"Surcharge amount: {surcharge}");
                    Console.WriteLine($"Net Amount paid by the customer: {amount+surcharge}");
                }
                else
                {
                    Console.WriteLine($"Net Amount paid by the customer: {amount}");
                }
            }
            
        }
    }

}
