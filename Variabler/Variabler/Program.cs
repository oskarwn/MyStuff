using System;

namespace Variabler
{
    class Program
    {
        static void Main(string[] args)
        {

            //Övning 1
            int tal1, tal2;
            Console.WriteLine("Mata in tal 1;");
            string input1 = Console.ReadLine();
            tal1 = int.Parse(input1);
            Console.WriteLine("Mata in tal 2:");
            string input2 = Console.ReadLine();
            tal2 = int.Parse(input2);
            Console.WriteLine("Summa: " + (tal1 + tal2));
            Console.WriteLine("Produkten: " + (tal1 * tal2));
            Console.WriteLine("Kvoten: " + (tal1 / tal2));

            //Övning 2
            string firstName, lastName;
            Console.WriteLine("Mata in ditt förnamnnamn:");
            firstName = Console.ReadLine();
            Console.WriteLine("Mata in ditt efternamn: ");
            lastName = Console.ReadLine();
            Console.WriteLine("Hej " + firstName + " " + lastName + "!");

            //Övning 3
            int celsius;
            Console.WriteLine("Mata in grader i Celsius:");
            string inputCelsius = Console.ReadLine();
            celsius = int.Parse(inputCelsius);
            Console.WriteLine("Det blir " + (celsius * 1.8 + 32) + " grader Farenheit");

            //Övning 4
            int celsius2;
            Console.Write("Mata in grader i Celsius: ");
            string inputCelsius2 = Console.ReadLine();
            celsius2 = int.Parse(inputCelsius2);
            Console.WriteLine("Det blir " + (celsius2 * 1.8 + 32) + " grader Farenheit");

            //Övning 5
            double radie;
            Console.Write("Cirkelns radie: ");
            string inputradie = Console.ReadLine();
            radie = double.Parse(inputradie);
            Console.WriteLine("Area: " + (radie * radie * 3.14));
            Console.WriteLine("Omkrets: " + (radie * 2) * 3.14);
            Console.ReadKey();
        }
    }
}
