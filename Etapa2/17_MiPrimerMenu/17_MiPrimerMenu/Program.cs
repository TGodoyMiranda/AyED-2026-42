using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_MiPrimerMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- Menu --"); Console.WriteLine("Calculo de TRI = 1"); Console.WriteLine("Consejo del dia = 2");
            Console.WriteLine("BYE BYE = 3");
            int Menu = int.Parse(Console.ReadLine());
                switch (Menu)
                {
                    case 1:
                        Console.WriteLine("6 dividido 2 es " + 6 / 2);
                        break;
                    case 2:
                        Console.WriteLine("Labura.");
                        break;
                    case 3:
                        Console.WriteLine("BYE BYE!");
                        break;
                    default:
                        Console.WriteLine("No.");
                        break;
                }
            Console.ReadKey();
        }
    }
}
