using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_AreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserte el ancho de su triangulo: ");
            double Base = int.Parse(Console.ReadLine());
            Console.Write("Inserte el alto de su triangulo: ");
            double Altura = int.Parse(Console.ReadLine());
            double Area = (Base * Altura) / 2;
            Console.Write("El area de su triangulo es " + Area);
            Console.ReadKey();
        }
    }
}
