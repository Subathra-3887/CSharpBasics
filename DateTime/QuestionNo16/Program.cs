using System;

namespace QuestionNo16
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int yr,mn,dt;
	
                Console.Write(" Input the Day : ");
                dt = Convert.ToInt32(Console.ReadLine());	
                Console.Write(" Input the Month : ");
                mn = Convert.ToInt32(Console.ReadLine());	
                Console.Write(" Input the Year : ");
                yr = Convert.ToInt32(Console.ReadLine());		
                DateTime d = new DateTime(yr, mn, dt);
                Console.WriteLine(" The formatted Date is : {0}",d.ToString("dd/MM/yyyy"));
                Console.WriteLine(" The last day of the month for the above date is : {0}\n", LastDayOfMonth(d).ToString("dd/MM/yyyy"));
                
                DateTime LastDayOfMonth(DateTime dt)
                {
                    DateTime ss= new DateTime(dt.Year, dt.Month, 1);
                    return ss.AddMonths(1).AddDays(-1);
                    }
                }
    }
}
   
