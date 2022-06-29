using System;

namespace QuestionNo15
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Select the number for operation:\n1.Student Registration \n2.Staff Registration \n3.Exit");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                {   
                    Console.Write("Enter Student's Name:");
                    string name = Console.ReadLine();
                    Console.Write("Enter Father's Name:");
                    string fname = Console.ReadLine();
                    Console.Write(" Age:");
                    int age = int.Parse(Console.ReadLine()); 
                    Console.Write("Gender:");
                    string gender = Console.ReadLine();
                    Console.Write("Class:");
                    int classValue = int.Parse(Console.ReadLine());
                    Console.Write("City:");
                    string city = Console.ReadLine();
                    Console.Write("Phone Number:");
                    long phNo = long.Parse(Console.ReadLine());
                    Console.WriteLine("\nStudent's Details are:");
                    Console.WriteLine($"Student Name: {name}");
                    Console.WriteLine($"Father Name: {fname}");
                    Console.WriteLine($"Age: {age}");
                    Console.WriteLine($"Gender: {gender}");
                    Console.WriteLine($"Class: {classValue}");
                    Console.WriteLine($"City: {city}");
                    Console.WriteLine($"Phone Number: {phNo}");  
                    break;
                }
                case 2:
                {   
                    Console.Write("Enter Staff's Name:");
                    string name = Console.ReadLine();
                    Console.Write("Enter Department Name:");
                    string dname = Console.ReadLine();
                    Console.Write("Enter your Gender:");
                    string gender = Console.ReadLine();
                    Console.Write("Contact Number:");
                    long coNo = long.Parse(Console.ReadLine());
                    Console.Write("Location:");
                    string loc = Console.ReadLine();
                    Console.WriteLine("\nStaff's Details are:");
                    Console.WriteLine($"Staff Name: {name}");
                    Console.WriteLine($"Department Name: {dname}");
                    Console.WriteLine($"Gender: {gender}");
                    Console.WriteLine($"Location: {loc}");
                    Console.WriteLine($"Contact Number: {coNo}");  
                    break;
                }
                case 3:
                {   
                    break;
                }
            }
            
        }
    }

}
   
