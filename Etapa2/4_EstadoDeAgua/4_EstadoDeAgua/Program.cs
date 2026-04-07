using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_EstadoDeAgua
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una temperatura aqui: ");
            int Temp = int.Parse(Console.ReadLine());
            if (Temp <= 0)
            {
                Console.WriteLine("El agua esta congelada");
            }
            if (Temp >= 100)
            {
                Console.WriteLine("El agua esta hirviendo");
            }
            if (Temp <= 99 && Temp >= 1)
            {
                Console.WriteLine("El agua esta en estado liquido");
            }
            Console.ReadKey();
        }
    }
}
