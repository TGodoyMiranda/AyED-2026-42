using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_PerimetroCuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserte la longitud de uno de los lados de tu cuadrado: ");
            Double Lado = int.Parse(Console.ReadLine());
            double Perimetro = Lado * 4;
            double Superficie = Lado * Lado;
            Console.Write("El lado ingresado posee un perimetro de " + Perimetro + " y su area es de " + Superficie);
            Console.ReadKey();
        }
    }
}
