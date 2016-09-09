using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning 1
           
            Console.WriteLine("Mata in ett heltal:");
            int tal = int.Parse(Console.ReadLine());

            switch (tal)
            {
                case 1: Console.WriteLine("Ett");
                    break;
                case 2:
                    Console.WriteLine("Två");
                    break;
                case 3:
                    Console.WriteLine("Tre");
                    break;
                case 4:
                    Console.WriteLine("Fyra");
                    break;
                default:
                    Console.WriteLine("Ogiltig inmatning");
                    break;

        }
            //Övning 2
            Console.WriteLine("Kompasssssss broriiii:");
            Console.WriteLine("Lär dig vad bokstaverna på din kompass betyder.");
            string bokstav = Console.ReadLine();
            char bokstav1 = char.Parse(bokstav); 
            switch (bokstav1)
            {
                case 'N': Console.WriteLine("You walk North"); 
                        break;
                case 'S': Console.WriteLine("You walk South");
                    break;
                case 'E': Console.WriteLine("You walk East");
                    break;
                case 'W': Console.WriteLine("You walk West");
                    break;
                case 'n':
                    Console.WriteLine("You walk North");
                    break;
                case 's':
                    Console.WriteLine("You walk South");
                    break;
                case 'e':
                    Console.WriteLine("You walk East");
                    break;
                case 'w':
                    Console.WriteLine("You walk West");
                    break;
            }

    }


    }
}
