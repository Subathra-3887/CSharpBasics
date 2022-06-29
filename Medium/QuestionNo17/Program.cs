using System;

namespace QuestionNo17
{
    class Program
    {
        static void Main(string[] args)
        {
            int doctors = 7;
            int treatedPatients = 0;
            int unTreatedPatients = 0;
            Console.WriteLine("Enter the number of days:");
            int days = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of patients for current day:");
            
            for(int i =1;i<=days;i++)
            {
                int patientCount = int.Parse(Console.ReadLine());
                
                if((i%3==0) && (unTreatedPatients>treatedPatients))
                {
                    doctors++;
                }
                if(patientCount>doctors)
                {
                    treatedPatients=treatedPatients+doctors;
                    unTreatedPatients=unTreatedPatients+patientCount-doctors;
                }
                else
                {
                    treatedPatients=treatedPatients+ patientCount;
                }
            }
            Console.WriteLine($"Treated Patients: {treatedPatients}");
            Console.WriteLine($"Untreated Patients: {unTreatedPatients}");
        }
    }
}
   
