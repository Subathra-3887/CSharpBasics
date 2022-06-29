using System;

namespace QuestionNo16

{
    class Program
    {
        static void Main(string[] args)
        {
            string words= null;
            Console.WriteLine("Enter the number:");
            int num = int.Parse(Console.ReadLine());
            string result = NumberToWords(num);
            Console.WriteLine(result);

            string NumberToWords(int number)
            {
                if (number==0){
                
                    return "zero";
                }
                if(number==100)
                {
                    return "hundred";
                }
                
                if(number>0)
                {
                    if(words!="")
                    words+= "";
                    
                    var onesMap = new[]{"zero","one","two","three","four","five","six","seven","eight","nine","ten","eleven","twelve","thirteen","fourteen","fifteen","sixteen","seventeen","eighteen","nineteen"};
                    var tensMap = new[]{"zero","ten","twenty","thirty","fourty","fifty","sixty","seventy","eighty","ninety"};

                    if (number<20)
                    {
                        words=words+onesMap[number];
                    }
                    else
                    {
                        words=words+tensMap[number/10];
                        if((number%10)>0)
                        {
                        
                            words=words+"-"+onesMap[number%10];
                        }
                    }
                }
                return words;
                
            }
        }
    }

}
   
