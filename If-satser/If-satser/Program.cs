using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_satser
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning 1
            double hjul;
            Console.Write("Skriv in mönsterdjup: ");
            string inputhjul = Console.ReadLine();
            hjul = double.Parse(inputhjul);
            if (hjul<1.6)
            {
                Console.WriteLine("Olagligt däck!");
            }
            else
            {
                Console.WriteLine("Lagligt däck!");
            }

            //Övning 2
            int alder;
            Console.Write("Mata in ålder: ");
            string inputalder = Console.ReadLine();
            alder = int.Parse(inputalder);
            if (alder < 13)
            {
                Console.WriteLine("Färg: vit");
            }
            else if (alder>12 && alder < 19)
            {
                Console.WriteLine("Färg: grön");
            }
            else if (alder > 18 && alder < 26)
            {
                Console.WriteLine("Färg: röd");
            }
            else if (alder > 25 && alder < 100)
            {
                Console.WriteLine("Färg: blå");
            }
            else
            {
                Console.WriteLine("Ogiltig ålder");
            }

            //Övning 3
            decimal tal1, tal2;
            Console.Write("Mata in tal 1: ");
            string inputtal1 = Console.ReadLine();
            Console.Write("Mata in tal 2: ");
            string inputtal2 = Console.ReadLine();
            tal1 = int.Parse(inputtal1);
            tal2 = int.Parse(inputtal2);
            if (tal1 > tal2)
            {
                Console.WriteLine("Tal 1 var störst: " + tal1);
            }
            else if (tal2 > tal1)
            {
                Console.WriteLine("Tal 2 var störst: " + tal2);
            }
            else
            {
                Console.WriteLine("Talen var lika!");
            }

            //Övning 4
            int tal;
            Console.Write("Mata in ett tal: ");
            string inputtal = Console.ReadLine();
            tal = int.Parse(inputtal);
            if (tal % 7 == 0)
            {
                Console.WriteLine("Talet är delbart med 7!");
            }
            else
            {
                Console.WriteLine("Talet är ej delbart med 7. Resten blir " + (tal % 7));
            }
            Console.ReadKey();

        }
    }
}
