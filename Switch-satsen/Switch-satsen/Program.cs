using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_satsen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning 1
            Console.Write("Mata in 1, 2, 3, eller 4: ");
            int tal = int.Parse(Console.ReadLine());
            switch (tal)
            {
                case 1: Console.WriteLine("Ett");   break;
                case 2: Console.WriteLine("Två");   break;
                case 3: Console.WriteLine("Tre");   break;
                case 4: Console.WriteLine("Fyra");  break;
                default: Console.WriteLine("Ogiltigt alternativ!"); break;
            }

            //Övning 2
            Console.Write("Mata in N, S, E eller W: ");
            string ord = Console.ReadLine();
            switch (ord)
            {
                case "n": Console.WriteLine("You walk north"); break;
                case "s": Console.WriteLine("You travel south"); break;
                case "e": Console.WriteLine("You wander east"); break;
                case "w": Console.WriteLine("You stroll west"); break;
                default: Console.WriteLine("I don't understand!"); break;
            }
            Console.ReadKey();
        }
    }
}
