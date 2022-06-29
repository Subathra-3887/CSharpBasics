using System;

namespace QuestionNo19
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum =0; int miniBusSum =0; int truckSum=0;
            int trainSum=0;
            Console.WriteLine("Enter the number of cargos");
            int cargoNos = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the tonnes of cargos:");
            for(int i =1;i<=cargoNos;i++)
            {   int cargoTon = int.Parse(Console.ReadLine());
                sum = sum+cargoTon;
                if(cargoTon<3)
                {
                    miniBusSum= miniBusSum + cargoTon;
                }
                if(cargoTon>3&& cargoTon<11)
                {
                    truckSum=truckSum+cargoTon;
                }
                if(cargoTon>11)
                {
                    trainSum = trainSum+cargoTon;
                }
            }
            Console.WriteLine($"{(miniBusSum/sum)/100}");
            Console.WriteLine($"{(truckSum/sum)/100}");
            Console.WriteLine($"{(trainSum/sum)/100}");

            Console.WriteLine($"{(miniBusSum*200+truckSum*175+trainSum*120)/100}");

        }
    }

}
   
