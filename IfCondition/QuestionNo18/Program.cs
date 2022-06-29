using System;

namespace QuestionNo18
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the salary");
            int salary = int.Parse(Console.ReadLine());
            if (salary<=10000)
            {
                double hra = salary*0.2;
                double da = salary*0.8;
                double grossSalary = salary+hra+da;
                Console.WriteLine($"Gross Salary is: {grossSalary}");
            }
            if (salary<=20000)
            {
                double hra = salary*0.25;
                double da = salary*0.9;
                double grossSalary = salary+hra+da;
                Console.WriteLine($"Gross Salary is: {grossSalary}");
            }
            if (salary>20000)
            {
                double hra = salary*0.3;
                double da = salary*0.95;
                double grossSalary = salary+hra+da;
                Console.WriteLine($"Gross Salary is: {grossSalary}");
            }
        }
    }

}