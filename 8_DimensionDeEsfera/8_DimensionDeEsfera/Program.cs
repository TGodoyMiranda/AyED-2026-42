using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_DimensionDeEsfera
{
    class Program
    {
        static void Main(string[] args)
        {
            float Pi = 3.14f;
            Console.Write("Inserte Un Radio: ");
            float Radio = int.Parse(Console.ReadLine());
            float Superficie = 4 * Pi * Radio * Radio;
            float Volumen = 1.33f * Pi * Radio * Radio * Radio;
            Console.WriteLine("La superficie de una esfera dado un radio de " + Radio + " Es " + Superficie + "cm2");
            Console.WriteLine("La volumen de una esfera dado un radio de " + Radio + " Es " + Volumen + "cm3");
            Console.ReadKey();
        }
    }
}
