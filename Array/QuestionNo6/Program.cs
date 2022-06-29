using System;

namespace QuestionNo6
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Input the number of elements to be stored in the array :");
            int num = int.Parse(Console.ReadLine());
            int [] numbers = new int[num];
            int element,i,j,temp=0;

            for(i=0;i<num;i++)
            {
                Console.Write($"Element-{i} =");
                element = int.Parse(Console.ReadLine());
                numbers[i] = element;
            }
            Console.WriteLine("Elements of original array:");
            foreach(int num1 in numbers)
            {
                Console.WriteLine($"{num1}");
            }
            for(i=0;i<num;i++)
            {
                for(j=i+1;j<num;j++)
                {
                if(numbers[i]>numbers[j])
                {
                    temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                }
                
            }
           
            }
            Console.WriteLine("Elements of original array:");
            foreach(int num1 in numbers)
            {
                Console.WriteLine($"{num1}");
            }
            
            }
    }

    
}
   

