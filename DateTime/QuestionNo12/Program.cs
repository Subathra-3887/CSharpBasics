using System;
using System.Globalization;

namespace QuestionNo12
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] formats = {"d", "D", "f", "F", "g", "G", "m", "o", "r", 
                          "s", "t", "T", "u", "U", "Y"};
                                     
            CultureInfo[] cultures = {CultureInfo.CreateSpecificCulture("zh-HK"), CultureInfo.CreateSpecificCulture("en-US"), CultureInfo.CreateSpecificCulture("es-GB"),CultureInfo.CreateSpecificCulture("fr-CA")};
      
            DateTime dateToDisplay = new DateTime(2015, 10, 16, 17, 4, 32);

            foreach (string formatSpecifier in formats)
            {
            foreach (CultureInfo culture in cultures)
            Console.WriteLine($"{formatSpecifier} Format Specifier {culture.Name, 10} Culture {dateToDisplay.ToString(formatSpecifier, culture), 40}");
             Console.WriteLine();
      }   
   }
           
        }
    }


   
