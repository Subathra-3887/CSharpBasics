using System;
using System.Globalization;

namespace QuestionNo15
{
    class Program
    {
        static void Main(string[] args)
        {
            int month ,year;

            Console.Write(" Input the Month No. : ");
            month = Convert.ToInt32(Console.ReadLine());	
            Console.Write(" Input the Year : ");
            year = Convert.ToInt32(Console.ReadLine());		
            DateTimeFormatInfo dinfo = new DateTimeFormatInfo();
            string mnum =  dinfo.GetMonthName(month);   
            int nodays = DateTime.DaysInMonth(year,month); 
            Console.WriteLine(" The Number of days in the month {0} is : {1} \n",mnum,nodays);
        }
    }

}
   
