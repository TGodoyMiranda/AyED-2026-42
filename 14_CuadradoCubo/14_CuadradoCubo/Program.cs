using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_CuadradoCubo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserte un Numero aqui: ");
            double Numero = int.Parse(Console.ReadLine());
            double Cuadrado = Math.Pow(Numero, 2);
            double Cubo = Math.Pow(Numero, 3);
            Console.WriteLine("Su numero al cuadrado es: " + Cuadrado);
            Console.WriteLine("Su numero al cubo es: " + Cubo);
            Console.ReadKey();
        }
    }
}
