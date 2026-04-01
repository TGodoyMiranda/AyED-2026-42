using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_CapacidadHDD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de cilindros del HDD: ");
            int CantCil = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de pistas por cilindro del HDD: ");
            int CantPist = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de sectores por pista del HDD: ");
            double SectPist = int.Parse(Console.ReadLine());
            double MultSP = SectPist * 512;
            double ConvKiloB = MultSP / 1000;
            double ConvMegaB = MultSP / 1000000;
            double ConvGigaB = MultSP / 1000000000;
            Console.WriteLine("La capacidad total de su almacenamiento en Kilobytes es " + ConvKiloB);
            Console.WriteLine("La capacidad total de su almacenamiento en Megabytes es " + ConvMegaB);
            Console.WriteLine("La capacidad total de su almacenamiento en Gigabytes es " + ConvGigaB);
            Console.ReadKey();
        }
    }
}
