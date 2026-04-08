using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_MonedasDelNivel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de puntos que obtuvo: ");
            int Puntos = int.Parse(Console.ReadLine());
            if (Puntos < 50)
            {
                Console.WriteLine("Nivel insuficiente.");
            }
            else if (Puntos >= 50 && Puntos <= 99)
            {
                Console.WriteLine("Nivel superado.");
            }
            else if (Puntos >= 100)
            {
                Console.WriteLine("Nivel superado con BONUS.");
            }
            Console.ReadKey();
        }
    }
}
