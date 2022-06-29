using System;

namespace QuestionNo12
{
    class Program
    {
        static void Main(string[] args)
        {
            double result;
            Console.WriteLine("Enter the value of money:");
            float money = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the type of currency:");
            string type = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter the type to convert the money value:");
            string ctype = Console.ReadLine().ToUpper();
            if (type =="BGN")
            {   
                if(ctype=="USD")
                {
                    result= money*1.79549;
                    Console.WriteLine(result);
                }
                if(ctype=="EUR")
                {
                    result=money*1.95583;
                    Console.WriteLine(result);
                }
                if(ctype=="GBP")
                {
                    result=money*2.53405;
                    Console.WriteLine(result);
                }
            }
            if (type =="USD")
            {   
                if(ctype=="BGN")
                {
                    result= money/1.79549;
                    Console.WriteLine(result);
                }
                if(ctype=="EUR")
                {
                    result=money/(1.95583/1.79549);
                    Console.WriteLine(result);
                }
                if(ctype=="GBP")
                {
                    result=money/(2.53405/1.79549);
                    Console.WriteLine(result);
                }
            }
            if (type =="EUR")
            {   
                if(ctype=="BGN")
                {
                    result= money/1.95583;
                    Console.WriteLine(result);
                }
                if(ctype=="USD")
                {
                    result=money/(1.79549/1.95583);
                    Console.WriteLine(result);
                }
                if(ctype=="GBP")
                {
                    result=money/(2.53405/1.95583);
                    Console.WriteLine(result);
                }
            }
            if (type =="GBP")
            {   
                if(ctype=="BGN")
                {
                    result= money/2.53405;
                    Console.WriteLine(result);
                }
                if(ctype=="EUR")
                {
                    result=money*(1.95583/2.53405);
                    Console.WriteLine(result);
                }
                if(ctype=="USD")
                {
                    result=money*(1.79549/2.53405);
                    Console.WriteLine(result);
                }
            }
        }
    }

}
   
