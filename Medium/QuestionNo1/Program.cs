using System;

namespace QuestionNo1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the value of length and width of the room:");
            float length = float.Parse(Console.ReadLine());
            float width = float.Parse(Console.ReadLine());
            if(3<=width && width<=100 &&3<= length&& length<=100)
            {
                length=length*100;
                width=width*100;

                int length1 =(int) (length/120);
                int width1 =(int) (width-100)/70;
                int total = (int)(length1*width1)-3;
                Console.WriteLine(total);
            }
        }
    }

}
   
