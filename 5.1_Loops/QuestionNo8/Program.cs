using System;

namespace QuestionNo8
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] even= new int[250];
            int [] odd = new int[250];
            int evenSum=0;
            int oddSum=0;
            int oddMax=0;
            int evenMax=0;
            int oddMin=0;
            int evenMin=0;
            int evenCount=-1;
            int oddCount=-1;
            Console.WriteLine("Enter the number of terms:");
            int terms = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the numbers:");
            for(int i=0;i<terms;i++)
            {
            int number= int.Parse(Console.ReadLine());
            if(number%2==0)
            {
                evenCount++;
            }
            else
            {
                oddCount++;
            }
            if(number%2==0){
                even[evenCount]=number;
            }
            
            if(number%2==1){
                odd[oddCount] =number;
            }
            }
            for(int j=0;j<=evenCount;j++)
            {   
                if(even[j]%2==0)
                {
                    evenSum=evenSum+even[j];
                }
                if(j==0)
                {
                    evenMax=even[j];
                    evenMin=even[j];
                }
                if(even[j]>evenMax)
                {
                    evenMax=even[j];
                }
                if(even[j]<evenMin)
                {
                    evenMin=even[j];
                }
            }
            for(int j=0;j<=oddCount;j++)
            {   
                if(odd[j]%2==1)
                {
                    oddSum=oddSum+odd[j];
                }if(j==0)
                {
                    oddMax=odd[j];
                    oddMin=odd[j];
                }
                if(odd[j]>oddMax)
                {
                    oddMax=odd[j];
                }
                if(odd[j]<oddMin)
                {
                    oddMin=odd[j];
                }
            }
            if(evenMin==0||evenMax==0)
            {
                Console.WriteLine($"Odd Sum = {oddSum}");
                Console.WriteLine($"Odd Min = {oddMin}");
                Console.WriteLine($"Odd Max = {oddMax}");
                Console.WriteLine($"Even Sum = {evenSum}");
                Console.WriteLine("Even Min = No");
                Console.WriteLine("Even Max = No");
                
            }
             if(oddMin==0||oddMax==0)
            {
                Console.WriteLine($"Odd Sum = {oddSum}");
                Console.WriteLine("Odd Min = No");
                Console.WriteLine("Odd Max = No");
                Console.WriteLine($"Even Sum = {evenSum}");
                Console.WriteLine($"Even Min = {evenMin}");
                Console.WriteLine($"Even Max = {evenMax}");
                
            }
            if(evenMin!=0 && oddMin!=0){
            Console.WriteLine($"Odd Sum = {oddSum}");
            Console.WriteLine($"Odd Min = {oddMin}");
            Console.WriteLine($"Odd Max = {oddMax}");
            Console.WriteLine($"Even Sum = {evenSum}");
            Console.WriteLine($"Even Min = {evenMin}");
            Console.WriteLine($"Even Max = {evenMax}");}


        }
    }

}
   
