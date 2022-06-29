using System;

namespace QuestionNo20
{
    class Program
    {
        static void Main(string[] args)
        {   
            int baby=0;;
            int school =0;
            int adult=0;
            Console.WriteLine("Enter the number of person:");
            int num = int.Parse(Console.ReadLine());
            while(num>0)
            {  
                Console.WriteLine("Enter age of a person:");
                int age = int.Parse(Console.ReadLine());
                if (age >=0 && age<=4)
                {
                    baby = baby+1;
                }
                else if(age>=4 && age<=17)
                {
                    school =school+1;
                }
                else
                {
                    adult = adult+1;
                }
                num--;
            }
            Console.WriteLine($"School age: {school}");
            Console.WriteLine($"Baby age: {baby}");
            Console.WriteLine($"Adult age: {adult}");
        }
    }

}
  