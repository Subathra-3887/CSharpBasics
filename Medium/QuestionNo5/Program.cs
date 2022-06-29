using System;

namespace QuestionNo5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the workdays per month:");
            int workdays = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the earnings per day:");
            float salaryPerDay = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the exchange rate");
            float rate = float.Parse(Console.ReadLine());
            double salaryPerMonth = salaryPerDay*workdays;
            double bonus = salaryPerMonth*2.5;
            double salaryPerYear = (salaryPerMonth *12)+bonus;
            double tax = 0.25 *salaryPerYear;
            double netSalary = salaryPerYear-tax;
            double salaryEur = netSalary*rate;
            double avrgPerDay = salaryEur/365;
            Console.WriteLine(Math.Round(avrgPerDay,3));
        }
    }

}
   
