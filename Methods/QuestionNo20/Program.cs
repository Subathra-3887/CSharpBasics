using System;

namespace QuestionNo19
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            int srange,erange;
            int sum =0; 
            Console.WriteLine("Enter the stating range:");
            srange= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the ending range:");
            erange = int.Parse(Console.ReadLine());
            Console.WriteLine($"Sum of all even numbers= {sum}");
            Even( srange,erange);
            
            int Even(int num1,int num2)
            {
                if (num1<1)
                {
                    return 1;
                }
                if (num2>num1)
                {
                if(num1 %2 ==0)
                {
                    return num1;
                }
                return num1+ num1%2;
                }
                else{
                    num1=Even(num1,num2-2);
                    sum = sum+num1;
                    return num1= num1+2;
                }
                
            }
            
        }
    }

}
   

